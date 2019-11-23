using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETGames.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<GameDetails> RecentGames { get; set; }
        public IEnumerable<GameDetails> FavoriteGames { get; set; }
    }
}
