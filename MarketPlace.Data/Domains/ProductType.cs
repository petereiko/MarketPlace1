using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Domains
{
    public class ProductType:BaseObject
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
