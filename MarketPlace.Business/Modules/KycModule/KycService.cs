using MarketPlace.Business.Modules.Auth;
using MarketPlace.Data;
using MarketPlace.Data.DataObjects.ApplicationConfig;
using MarketPlace.Data.DataObjects.KycModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
        public KycService(ApplicationDbContext context, ILogger<KycService> logger, IAuthUser authUser, AppSetting appSetting)
        {
            _context = context;
            _logger = logger;
            _authUser = authUser;
            _appSetting = appSetting;
        }

        public async Task<KycViewModel> Get()
        {
            KycViewModel model = null;
            var kyc =  await _context.Kycs.AsNoTracking().Include(x => x.ApplicationUser).FirstOrDefaultAsync(x => x.UserId == _authUser.UserId);
            if (kyc != null) 
            {
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
                        CreatedDate = kyc.ApplicationUser.CreatedDate,
                        IsActive = kyc.ApplicationUser.IsActive,
                        IsDeleted = kyc.ApplicationUser.IsDeleted,
                        LastLoginDate = kyc.ApplicationUser.LastLoginDate,
                        LastModified = kyc.ApplicationUser.LastModified,
                        MyReferralCode = kyc.ApplicationUser.MyReferralCode,
                        ReferralLink = $"{_appSetting.BaseUrl}/images/{kyc.ApplicationUser.MyReferralCode}"
                    }
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
