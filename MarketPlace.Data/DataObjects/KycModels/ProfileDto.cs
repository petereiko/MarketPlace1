using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.DataObjects.KycModels
{
    public class ProfileDto
    {
        public string City { get; set; }
        public long? StateId { get; set; }
        public long? CountryId { get; set; }
        public string ResidentialAddress { get; set; }
    }
}
