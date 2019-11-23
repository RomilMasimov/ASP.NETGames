using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETGames.Models.ViewModels
{
    public class GamesViewModel
    {
        public SearchByNameResponce Responce { get; set; }
        public string Search { get; set; }
        public string Ordering { get; set; }
    }
}
