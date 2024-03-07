using MarketPlace.Data;
using MarketPlace.Data.DataObjects.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Business.Modules.Purchase
{
    public class BuyService:IBuyService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<BuyService> _logger;
        public BuyService(ApplicationDbContext context, ILogger<BuyService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<NameCount>> FetchProductTypes()
        {
            var productTypeList = await _context.ProductTypes.AsNoTracking()
                .GroupBy(x => x.Name)
                .Select(x => new NameCount
                {
                    Count = x.Count(),
                    Name = x.Key
                }).OrderBy(x => x.Name)
                .ToListAsync();
            return productTypeList;
        }
    }
}
