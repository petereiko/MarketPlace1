using MarketPlace.Data.DataObjects.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.DataObjects.KycModels
{
    public class KycViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassportName { get; set; }
        public string DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ResidentialAddress { get; set; }
        public string UserId { get; set; }
        public long Id { get; set; }
        public ApplicationUserViewModel User { get; set; }
    }
}
