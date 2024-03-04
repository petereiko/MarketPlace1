using MarketPlace.Business.Modules.Notification;
using MarketPlace.Data;
using MarketPlace.Data.DataObjects.ApplicationConfig;
using MarketPlace.Data.DataObjects.Auth;
using MarketPlace.Data.DataObjects.KycModels;
using MarketPlace.Data.Domains;
using MarketPlace.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text;

namespace MarketPlace.Business.Modules.Auth
{
    public class AccountService:IAccountService
    {
        private readonly AppSetting _appSettings;
        protected readonly UserManager<ApplicationUser> _userManager;
        protected readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUrlHelper _urlHelper;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<AccountService> _logger;
        protected readonly RoleManager<ApplicationRole> _roleManager;
        private readonly ISmsService _smsService;
        private readonly IEmailService _emailManager;

        public AccountService(IOptions<AppSetting> options, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IUrlHelper urlHelper, ApplicationDbContext context, ILogger<AccountService> logger, RoleManager<ApplicationRole> roleManager, ISmsService smsService, IEmailService emailManager)
        {
            _appSettings = options.Value;
            _userManager = userManager;
            _signInManager = signInManager;
            _urlHelper = urlHelper;
            _context = context;
            _logger = logger;
            _roleManager = roleManager;
            _smsService = smsService;
            _emailManager = emailManager;
        }

        public async Task<LoginResponse> Login(LoginViewModel model)
        {
            LoginResponse result = new();
            try
            {
                var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == model.Email);

                if (user == null || user.IsDeleted == true)
                {
                    result.Message = "User does not exist";
                    result.LoginStatus = LoginStatus.UserDoesNotExist;
                    return result;
                }
                if (user.IsActive == false)
                {
                    result.LoginStatus = LoginStatus.InactiveAccount;
                    result.Message = "User is inactive";
                    return result;
                }
                var signInResult = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, true);

                if (signInResult.IsLockedOut)
                {
                    result.LoginStatus = LoginStatus.AccountLockedOut;
                    result.Message = "You are locked out. Kindly use the Forgot password link to reset your password";
                    return result;
                }

                if (signInResult.Succeeded)
                {
                    user.LastLoginDate = DateTime.Now;

                    await _signInManager.SignInAsync(user, model.RememberMe, "Cookie");

                    await _userManager.UpdateAsync(user);
                    string baseUrl = $"{_urlHelper.ActionContext.HttpContext.Request.Scheme}://{_urlHelper.ActionContext.HttpContext.Request.Host}{_urlHelper.ActionContext.HttpContext.Request.PathBase}";

                    string referralLink = baseUrl + "?code=" + user.MyReferralCode;

                    var kyc = await _context.Kycs.AsNoTracking().FirstOrDefaultAsync(x => x.UserId == user.Id);

                    result = new LoginResponse
                    {
                        ApplicationUser = new ApplicationUserViewModel
                        {
                            ReferralLink = referralLink,
                            WhoReferredMeCode = user.WhoReferredMeCode,
                            LastLoginDate = user.LastLoginDate,
                            MyReferralCode = user.MyReferralCode,
                            CreatedDate = user.CreatedDate,
                            IsActive = user.IsActive,
                            IsDeleted = user.IsDeleted,
                            LastModified = user.LastLoginDate,
                            Kyc = new KycViewModel
                            {
                                DateOfBirth = kyc.DateOfBirth,
                                Id = kyc.Id,
                                City = kyc.City,
                                PassportName = kyc.PassportName,
                                Phone = kyc.Phone,
                                ResidentialAddress = kyc.ResidentialAddress,
                                State = kyc.State,
                                Country = kyc.Country
                            }
                        },
                        LoginStatus = LoginStatus.Success,
                        Message = "You are logged in successfully",
                        Status = true
                    };
                    return result;
                }
                else
                {
                    string msg = string.Empty;
                    int maxCount = 3;
                    if ((maxCount - user.AccessFailedCount) == 1)
                        msg = "You have only one attempt remaining";
                    else if ((maxCount - user.AccessFailedCount) < 0)
                        msg = "You have exceeded your attempts";
                    else
                        msg = $"You have {maxCount - user.AccessFailedCount} attempts remaining";

                    result.LoginStatus = LoginStatus.LoginFailedAttempt;
                    result.Message = msg;
                    return result;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                result.LoginStatus = LoginStatus.LoginServerError;
                result.Message = "An error occurred while trying to log you in. Please try again later.";
                return result;
            }
        }

        public async Task SignOut()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<RegisterResponse> Register(RegisterViewModel payload)
        {
            RegisterResponse result = new();
            var context = _context;
            var scope = await context.Database.BeginTransactionAsync();
            using (scope)
            {
                try
                {
                    if (payload == null)
                    {
                        await scope.RollbackAsync();
                        result.Message = "Invalid request";
                        return result;
                    }

                    //Check if user exist
                    bool userExist = await context.Users.AsNoTracking()
                        .AnyAsync(x => x.Email == payload.Email);
                    if (userExist)
                    {
                        await scope.RollbackAsync();
                        result.Message = "Email/Phone is in use";
                        return result;
                    }

                    //Validate Referral Code
                    if (!string.IsNullOrEmpty(payload.WhoReferredMeCode))
                    {
                        var whoReferredMeCodeExist = await _context.ApplicationUsers.AnyAsync(x => x.WhoReferredMeCode == payload.WhoReferredMeCode);
                        if (!whoReferredMeCodeExist)
                        {
                            await scope.RollbackAsync();
                            result.Message = "Invalid Referral Code";
                            return result;
                        }
                    }

                    var role = await _roleManager.Roles.FirstOrDefaultAsync(x => x.Name.ToLower() == RoleConstants.USER.ToLower());
                    if (role == null)
                    {
                        role = new ApplicationRole
                        {
                            IsActive = true,
                            CreatedDate = DateTime.Now,
                            Name = RoleConstants.USER,
                            NormalizedName = RoleConstants.USER.ToUpper(),
                            ConcurrencyStamp = Guid.NewGuid().ToString(),
                            Id = Guid.NewGuid().ToString(),
                        };
                        context.Roles.Add(role);
                        var roleResult = await context.SaveChangesAsync();
                        if (roleResult <= 0)
                        {
                            await scope.RollbackAsync();
                            result.Message = "User Role could not be created";
                            return result;
                        }
                    }

                    string referralCode = payload.FirstName.Substring(0, 3) + context.Users.Count().ToString().PadLeft(3, '0');

                    var user = new ApplicationUser()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Email = payload.Email.Trim(),
                        UserName = payload.Email.Trim(),
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        PhoneNumberConfirmed = false,
                        EmailConfirmed = false,
                        WhoReferredMeCode = payload.WhoReferredMeCode,
                        SecurityStamp = Guid.NewGuid().ToString("D"),
                        ConfirmationLinkExpireDate = Convert.ToDateTime(DateTime.Now.AddMinutes(20)),
                        NormalizedEmail = payload.Email?.Trim().ToUpper(),
                        NormalizedUserName = payload.Email?.Trim().ToUpper(),
                        ForcePwdChange = false,
                        AccessFailedCount = 0,
                        LockoutEnabled = true,
                        MyReferralCode = referralCode
                    };
                    user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, payload.Password.Trim());
                    context.Users.Add(user);
                    await context.SaveChangesAsync();

                    //Add user to role
                    var addToRoleResult = await _userManager.AddToRoleAsync(user, RoleConstants.USER);
                    if (!addToRoleResult.Succeeded)
                    {
                        await scope.RollbackAsync();
                        result.Message = addToRoleResult?.Errors?.FirstOrDefault()?.Description;
                        return result;
                    }
                    Kyc kyc = new()
                    {
                        UserId = user.Id,
                        FirstName = payload.FirstName,
                        LastName = payload.LastName,
                        Phone = payload.Phone
                    };
                    _context.Kycs.Add(kyc);
                    await _context.SaveChangesAsync();
                    //save the request

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"Dear {payload.FirstName}");
                    sb.AppendLine("An account has been created for you. Kindly click the link below to activate the account");
                    sb.AppendLine($"<a href='{_appSettings.BaseUrl}/Account/Confirmation?id={user.Id}'>Click to Activate your account</a>");
                    sb.AppendLine("MarketPlace Team!");
                    string message = sb.ToString();
                    sb.Clear();
                    await _emailManager.Send(user.Email, subject: "Account Creation", message);
                    await scope.CommitAsync();

                    result.Message = "Account created successfully";
                    result.Success = true;

                    return result;
                }
                catch (Exception ex)
                {
                    await scope.RollbackAsync();
                    _logger.LogError(ex.Message, ex);
                    result.HasError = true;
                    return result;
                }
            }
        }
    }
}
