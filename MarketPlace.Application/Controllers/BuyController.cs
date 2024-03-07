using MarketPlace.Business.Modules.Purchase;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Application.Controllers
{
    public class BuyController : Controller
    {

        private readonly IBuyService _service;

        public BuyController(IBuyService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var productTypes = await _service.FetchProductTypes();
            return View(productTypes);
        }
    }
}
