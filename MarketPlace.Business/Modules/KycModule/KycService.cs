using MarketPlace.Business.Modules.Auth;
using MarketPlace.Data;
using MarketPlace.Data.DataObjects.ApplicationConfig;
using MarketPlace.Data.DataObjects.KycModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Business.Modules.KycModule
{
    public class KycService:IKycService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<KycService> _logger;
        private readonly IAuthUser _authUser;
        private readonly AppSetting _appSetting;
        private readonly IHttpContextAccessor _contextAccessor;
        public KycService(ApplicationDbContext context, ILogger<KycService> logger, IAuthUser authUser, IOptions<AppSetting> appSetting, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _logger = logger;
            _authUser = authUser;
            _appSetting = appSetting.Value;
            _contextAccessor = contextAccessor;
        }

        public async Task<KycViewModel> Get()
        {
            KycViewModel model = null;
            var kyc =  await _context.Kycs.Include(x=>x.User).AsNoTracking().FirstOrDefaultAsync(x => x.UserId == _authUser.UserId);
            if (kyc != null) 
            {
                var user = kyc.User;//await _context.ApplicationUsers.AsNoTracking().FirstOrDefaultAsync(x => x.Id == _authUser.UserId);

                model = new()
                {
                    City = kyc.City,
                    CountryName = kyc.Country.Name,
                    DateOfBirth = kyc.DateOfBirth,
                    Id = kyc.Id,
                    PassportName = kyc.PassportName,
                    Phone = kyc.Phone,
                    ResidentialAddress = kyc.ResidentialAddress,
                    StateName = kyc.State.Name,
                    User = new Data.DataObjects.Auth.ApplicationUserViewModel
                    {
                        CreatedDate = user.CreatedDate,
                        IsActive = user.IsActive,
                        IsDeleted = user.IsDeleted,
                        LastLoginDate = user.LastLoginDate,
                        LastModified = user.LastModified,
                        MyReferralCode = user.MyReferralCode,
                        ReferralLink = $"{_appSetting.BaseUrl}/images/{user.MyReferralCode}",
                        Email = user.Email,
                        WhoReferredMeCode = user.WhoReferredMeCode
                    },
                    FirstName = kyc.FirstName,
                    LastName = kyc.LastName,
                    UserId = kyc.UserId
                };
            }
            return model;
        }

        public async Task<bool> UploadPassport(IFormFile file)
        {
            bool result = false;
            try
            {
                string directory = Path.Combine(Directory.GetCurrentDirectory(), "images"); //Path.Combine(_contextAccessor.HttpContext.Request.Path, "images");
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                string fileName = $"{_authUser.UserId}{Path.GetExtension(file.FileName)}";
                string fullName = Path.Combine(directory, fileName);

                File.Delete(fullName);

                using (var stream = new FileStream(fullName, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                var kyc = await _context.Kycs.FirstOrDefaultAsync(x => x.UserId == _authUser.UserId);
                if (kyc != null)
                {
                    kyc.PassportName = fileName;
                    kyc.LastModified = DateTime.Now;
                    kyc.ModifiedBy = _authUser.UserId;
                    await _context.SaveChangesAsync();
                }
                result = true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                
            }
            return result;
        }

        public async Task<bool> SaveProfile(ProfileDto model)
        {
            bool result = false;
            try
            {
                var kyc = await _context.Kycs.FirstOrDefaultAsync(x => x.UserId == _authUser.UserId);
                if (kyc != null)
                {
                    if (!string.IsNullOrEmpty(model.City))
                        kyc.City = model.City.Trim();
                    if (model.CountryId!=null)
                        kyc.CountryId = model.CountryId;
                    if (!string.IsNullOrEmpty(model.ResidentialAddress))
                        kyc.ResidentialAddress = model.ResidentialAddress.Trim();
                    if (model.StateId!=null)
                        kyc.StateId = model.StateId;
                    if (model.ContinentId != null)
                        kyc.ContinentId = model.ContinentId;
                    kyc.LastModified = DateTime.Now;
                    kyc.ModifiedBy = _authUser.UserId;
                    await _context.SaveChangesAsync();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
            }
            return result;
        }
    }
}
