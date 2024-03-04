using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Domains
{
    public class ApplicationUser : IdentityUser
    {
        public string MyReferralCode { get; set; }
        public string WhoReferredMeCode { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModified { get; set; }
        public bool ForcePwdChange { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime ConfirmationLinkExpireDate { get; set; }
    }
}
