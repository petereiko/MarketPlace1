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
        public long? StateId { get; set; }
        public string StateName { get; set; }
        public string City { get; set; }
        public long? CountryId { get; set; }
        public string CountryName { get; set; }
        public long? ContinentId { get; set; }
        public string ContinentName { get; set; }
        public string ResidentialAddress { get; set; }
        public string UserId { get; set; }
        public long Id { get; set; }
        public ApplicationUserViewModel User { get; set; }
    }
}
