﻿using ArgentumSite.Models;
using ArgentumSite.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ArgentumSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGoodCardsProvider _goodCardsProvider;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IGoodCardsProvider goodCardsProvider)
        {
            _goodCardsProvider = goodCardsProvider;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _goodCardsProvider.GetGoodCardList();
            return View(model);
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