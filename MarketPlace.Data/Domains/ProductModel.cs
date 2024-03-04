using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Domains
{
    public class ProductModel:BaseObject
    {
        [ForeignKey("BrandId")]
        public long? ProductBrandId { get; set; }

        public virtual ProductBrand ProductBrand { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

    }
}
