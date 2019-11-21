using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETGames.Models
{
    public class SearchByNameResponce
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public int Page { get; set; }
        public int PageCount { get; set; }
        public IEnumerable<Game> results { get; set; }
        public bool user_platforms { get; set; }
    }
}
