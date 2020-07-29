using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETGames.Models.ViewModels;
using ASP.NETGames.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP.NETGames.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGamesService _gamesService;
        private readonly IRecentGamesService _recentGamesService;

        public GamesController(IGamesService gamesService, IRecentGamesService recentGamesService)
        {
            _gamesService = gamesService;
            _recentGamesService = recentGamesService;
        }

        public IActionResult Index()
        {
            return RedirectToAction(nameof(Search));
        }

        public async Task<IActionResult> Search(string search, string ordering, int page = 1)
        {
            var response = await _gamesService.SearchByTitleAsync(search, ordering, page);
            var model = new GamesViewModel()
            {
                Responce = response,
                Search = search,
                Ordering = ordering
            };
            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        {
            var gameDetails = await _gamesService.SearchByIdAsync(id);
            _recentGamesService.AddGame(gameDetails);
            return View(gameDetails);
        }
    }
}