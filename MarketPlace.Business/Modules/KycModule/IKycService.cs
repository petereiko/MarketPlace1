using MarketPlace.Data.DataObjects.KycModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Business.Modules.KycModule
{
    public interface IKycService
    {
        Task<KycViewModel> Get();
    }
}
