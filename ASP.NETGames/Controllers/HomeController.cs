using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETGames.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETGames.Controllers
{
    public class HomeController : Controller
    {
        public IGamesService GamesService { get; }

        public HomeController(IGamesService gamesService)
        {
            GamesService = gamesService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GamesAsync()
        {
            var test = await GamesService.SearchByTitleAsync("gta");
            return View(test.results);
        }
    }
}