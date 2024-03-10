using MarketPlace.Data;
using MarketPlace.Data.DataObjects.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Business.Modules.Location
{
    public class LocationService:ILocationService
    {
        public readonly ApplicationDbContext _context;
        public readonly ILogger<LocationService> _logger;

        public LocationService(ApplicationDbContext context, ILogger<LocationService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<SelectListItem>> FetchStates()
        {
            return await _context.States.AsNoTracking()
                .Select(s => new SelectListItem
                {
                    Text = s.Name,
                    Value = s.Id.ToString()
                }).ToListAsync();
        }

        

    }
}
