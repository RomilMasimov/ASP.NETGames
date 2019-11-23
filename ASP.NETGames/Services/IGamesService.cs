using ASP.NETGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETGames.Services
{
    public interface IGamesService
    {
        Task<SearchByNameResponce> SearchByTitleAsync(string title, string ordering = "name", int page = 1, int pageSize = 12);
        Task<GameDetails> SearchByIdAsync(int id);
    }
}
