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
        public IFavoriteGamesService FavoriteGamesService { get; }
        public IRecentGamesService RecentGamesService { get; }

        public HomeController(IFavoriteGamesService favoriteGamesService, IRecentGamesService recentGamesService)
        {
            FavoriteGamesService = favoriteGamesService;
            RecentGamesService = recentGamesService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var recentGames = RecentGamesService.GetGames();
            var favoriteGames = await FavoriteGamesService.GetGamesAsync();
            var model = new HomeIndexViewModel()
            {
                RecentGames = recentGames,
                FavoriteGames = favoriteGames
            };
            return View(model);
        }
    }
}