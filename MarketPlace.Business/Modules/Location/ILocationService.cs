using MarketPlace.Data.DataObjects.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Business.Modules.Location
{
    public interface ILocationService
    {
        Task<List<SelectListItem>> FetchStates();
    }
}
