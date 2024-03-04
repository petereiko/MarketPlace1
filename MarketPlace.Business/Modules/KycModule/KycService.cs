using MarketPlace.Business.Modules.Auth;
using MarketPlace.Data;
using MarketPlace.Data.DataObjects.ApplicationConfig;
using MarketPlace.Data.DataObjects.KycModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
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
        public KycService(ApplicationDbContext context, ILogger<KycService> logger, IAuthUser authUser, IOptions<AppSetting> appSetting)
        {
            _context = context;
            _logger = logger;
            _authUser = authUser;
            _appSetting = appSetting.Value;
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
                    Country = kyc.Country,
                    DateOfBirth = kyc.DateOfBirth,
                    Id = kyc.Id,
                    PassportName = kyc.PassportName,
                    Phone = kyc.Phone,
                    ResidentialAddress = kyc.ResidentialAddress,
                    State = kyc.State,
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

                if (!string.IsNullOrEmpty(kyc.PassportName))
                {
                    kyc.PassportName = $"{_appSetting.BaseUrl}/images/{kyc.PassportName}";
                }
            }
            return model;
        }
    }
}
