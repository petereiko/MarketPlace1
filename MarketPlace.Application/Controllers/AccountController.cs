using MarketPlace.Business.Modules.Auth;
using MarketPlace.Data.DataObjects.Auth;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Application.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _service;

        public AccountController(IAccountService service)
        {
            _service = service;
        }

        public async Task<IActionResult> SignOut()
        {
            await _service.SignOut();
            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if(!ModelState.IsValid) 
            {
                model.Errors.Add(ModelState.Values.SelectMany(x => x.Errors).FirstOrDefault().ErrorMessage);
                return View(model);
            }
            var result = await _service.Login(model);
            if (result.Status)
            {
                return RedirectToAction("Index", "Home");
            }
            model.Errors.Add(result.Message);
            return View(model);
        }

        [HttpGet]
        public IActionResult Register(string code)
        {
            RegisterViewModel model = new() { WhoReferredMeCode = code };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Errors.Add(ModelState.Values.SelectMany(x => x.Errors).FirstOrDefault().ErrorMessage);
                return View(model);
            }
            var result = await _service.Register(model);
            if(result.Success)
            {
                return View("Login", new LoginViewModel { Email = model.Email });
            }
            return View(model);
        }
    }
}
