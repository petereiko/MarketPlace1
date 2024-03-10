using MarketPlace.Business.Modules.Location;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Application.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationService _service;

        public LocationController(ILocationService service)
        {
            _service = service;
        }
    }
}
