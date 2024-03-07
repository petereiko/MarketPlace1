using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Domains
{
    public class Kyc:BaseObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassportName { get; set; }
        public string DateOfBirth { get; set; }
        public string Phone { get; set; }

        [ForeignKey("StateId")]
        public long? StateId { get; set; }
        public virtual State State { get; set; }
        public string City { get; set; }
        
        public string ResidentialAddress { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
