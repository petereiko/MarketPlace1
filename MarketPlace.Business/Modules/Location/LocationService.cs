using MarketPlace.Data;
using MarketPlace.Data.DataObjects.Common;
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

        public async Task<List<IdName>> FetchStates(long CountryId)
        {
            return await _context.States.AsNoTracking().Where(x => x.CountryId == CountryId)
                .Select(x => new IdName
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .OrderBy(x => x.Name).ToListAsync();
        }

    }
}
