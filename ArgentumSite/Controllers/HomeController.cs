using ArgentumSite.Models;
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
            var model = await _goodCardsProvider.GetMainGoodCardList();
            return View(model);
        }

        public async Task<IActionResult> GoodCard([FromRoute] int? id)
        {
            var model = await _goodCardsProvider.GetGoodCard(id.Value);
            return View(model);
        }

        public async Task<IActionResult> Category([FromRoute] int? id)
        {
            var model = await _goodCardsProvider.GetGoodCardsCategory(id.Value);
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

        public async Task<IActionResult> Search(string? searchString)
        {
            if (searchString != null)
            {
                var model = await _goodCardsProvider.GetSearchCards(searchString);
                return View(model);
            }
            return RedirectToAction("Index");
        }
    }
}