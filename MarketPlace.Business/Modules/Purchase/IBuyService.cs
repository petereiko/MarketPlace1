using MarketPlace.Data.DataObjects.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Business.Modules.Purchase
{
    public interface IBuyService
    {
        Task<List<NameCount>> FetchProductTypes();
    }
}
