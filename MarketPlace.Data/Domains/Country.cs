using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Domains
{
    public class Country:BaseObject
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string PhoneCode { get; set; }
        public string NationalCurrency { get; set; }
        public string Nationality { get; set; }
        public decimal? VatRate { get; set; }
    }
}
