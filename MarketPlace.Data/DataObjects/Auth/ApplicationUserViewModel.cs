using MarketPlace.Data.DataObjects.KycModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.DataObjects.Auth
{
    public class ApplicationUserViewModel
    {
        public string ReferralLink { get; set; }
        public string MyReferralCode { get; set; }
        public string WhoReferredMeCode { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModified { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public KycViewModel Kyc { get; set; }
    }
}
