using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Domains
{
    public class ProductCondition:BaseObject
    {
        public ProductCondition()
        {
            Products = new HashSet<Product>();
        }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; } 
    }
}
