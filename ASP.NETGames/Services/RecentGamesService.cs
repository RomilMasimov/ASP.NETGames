using ASP.NETGames.Models;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETGames.Services
{
    public class RecentGamesService : IRecentGamesService
    {
        ConcurrentQueue<GameDetails> games = new ConcurrentQueue<GameDetails>();

        public IEnumerable<GameDetails> GetGames()
        {
            return games.Take(3);
        }

        public void AddGame(GameDetails game)
        {
            if (!games.Any(m => m.Id == game.Id))
                games.Enqueue(game);

            if (games.Count > 3)
                games.TryDequeue(out GameDetails temp);
        }
    }
}
