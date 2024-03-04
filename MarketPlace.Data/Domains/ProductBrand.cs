using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Domains
{
    public class ProductBrand:BaseObject
    {
        public ProductBrand()
        {
            Products = new HashSet<Product>();
            ProductModels = new HashSet<ProductModel>();
        }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProductModel> ProductModels { get; set; }
    }
}
