using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETGames.Models.ViewModels;
using ASP.NETGames.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

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

        public async Task<IActionResult> GamesAsync(string search, int page = 1)
        {
            var responce = await GamesService.SearchByTitleAsync(search, page);
            var model = new GamesViewModel()
            {
                Responce = responce,
                Search = search
            };
            return View(model);
        }
    }
}