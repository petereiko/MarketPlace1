using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Domains
{
    public class ProductType:BaseObject
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
            ProductCategories = new HashSet<ProductCategory>();
        }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
