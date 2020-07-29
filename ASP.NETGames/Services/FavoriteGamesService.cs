using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETGames.Models;

namespace ASP.NETGames.Services
{
    public class FavoriteGamesService : IFavoriteGamesService
    {
        private readonly IGamesService _gamesService;

        public FavoriteGamesService(IGamesService gamesService)
        {
            _gamesService = gamesService;
        }

        public async Task<IEnumerable<GameDetails>> GetGamesAsync()
        {
            int[] ids = { 50738, 51325, 257201 };
            var result = new List<GameDetails>();
            foreach (var id in ids)
            {
                result.Add(await _gamesService.SearchByIdAsync(id));
            }
            return result;
        }
    }
}
