﻿using MarketPlace.Application.Models;
using MarketPlace.Business.Modules.KycModule;
using MarketPlace.Data.DataObjects.KycModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MarketPlace.Application.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IKycService _kycService;

        public HomeController(ILogger<HomeController> logger, IKycService kycService)
        {
            _logger = logger;
            _kycService = kycService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Profile()
        {
            var kyc = await _kycService.Get();
            return View(kyc);
        }

        [HttpPost]
        public async Task<IActionResult> UploadPassport(IFormFile file)
        {
            var result = await _kycService.UploadPassport(file);
            return Json(result);
        }


        [HttpPost]
        public async Task<IActionResult> SaveProfile([FromBody]ProfileDto model)
        {
            var result = await _kycService.SaveProfile(model);
            return Json(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}