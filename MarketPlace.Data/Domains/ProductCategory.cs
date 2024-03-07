using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Domains
{
    public class ProductCategory:BaseObject
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }
        public string Name { get; set; }

        [ForeignKey("ProductTypeId")]
        public long? ProductTypeId {  get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
