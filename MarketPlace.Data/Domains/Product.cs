using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Domains
{
    public class Product:BaseObject
    {
        public string Name { get; set; }

        [ForeignKey("ProductModelId")]
        public long? ProductModelId { get; set; }
        public virtual ProductModel ProductModel { get; set; }

        [ForeignKey("ProductCategoryId")]
        public long? ProductCategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }

        [ForeignKey("ProductTypeId")]
        public long? ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }

        [ForeignKey("CountryId")]
        public long? CountryId { get; set; }
        public virtual Country Country { get; set; }

        [ForeignKey("ContinentId")]
        public long? ContinentId {  get; set; }
        public virtual Continent Continent { get; set; }

        [ForeignKey("StateId")]
        public long? StateId { get; set; }
        public virtual State State { get; set; }
    }
}
