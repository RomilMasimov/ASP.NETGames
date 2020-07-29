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
        private readonly IFavoriteGamesService _favoriteGamesService;
        private readonly IRecentGamesService _recentGamesService;

        public HomeController(IFavoriteGamesService favoriteGamesService, IRecentGamesService recentGamesService)
        {
            _favoriteGamesService = favoriteGamesService;
            _recentGamesService = recentGamesService;
        }

        public async Task<IActionResult> Index()
        {
            var recentGames = _recentGamesService.GetGames();
            var favoriteGames = await _favoriteGamesService.GetGamesAsync();
            var model = new HomeIndexViewModel()
            {
                RecentGames = recentGames,
                FavoriteGames = favoriteGames
            };
            return View(model);
        }
    }
}