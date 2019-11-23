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
        public IGamesService GamesService { get; }
        public IRecentGamesService RecentGamesService { get; }

        public GamesController(IGamesService gamesService, IRecentGamesService recentGamesService)
        {
            GamesService = gamesService;
            RecentGamesService = recentGamesService;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Search");
        }

        public async Task<IActionResult> SearchAsync(string search, string ordering, int page = 1)
        {
            var responce = await GamesService.SearchByTitleAsync(search, ordering, page);
            var model = new GamesViewModel()
            {
                Responce = responce,
                Search = search,
                Ordering = ordering
            };
            loadDropdown();
            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        {
            var gameDetails = await GamesService.SearchByIdAsync(id);
            RecentGamesService.AddGame(gameDetails);
            return View(gameDetails);
        }

        private void loadDropdown()
        {
            ViewBag.Ordering = new SelectList(
                new[] {
                    new { Name = "Not Sorting", Value = "" },
                    new { Name = "Rating", Value = "-rating" },
                    new { Name = "Name", Value = "-name" },
                    new { Name = "Released", Value = "-released" },
                    new { Name = "Created", Value = "-created" },
                    new { Name = "Added", Value = "added" }
                },
                "Value", "Name");
        }
    }
}