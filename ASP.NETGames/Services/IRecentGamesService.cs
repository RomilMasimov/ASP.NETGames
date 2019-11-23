﻿using ASP.NETGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETGames.Services
{
    public interface IRecentGamesService
    {
        IEnumerable<GameDetails> GetGames();
        void AddGame(GameDetails game);
    }
}
