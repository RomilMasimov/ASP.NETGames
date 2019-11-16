using ASP.NETGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETGames.Services
{
    public interface IGamesService
    {
        Task<SearchByNameResponce> SearchByTitleAsync(string title);
        Task<GameDetails> SearchByIdAsync(int id);
    }
}
