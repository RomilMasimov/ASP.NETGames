using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETGames.Models
{
    public class StoreForGame
    {
        public int id { get; set; }
        public string url { get; set; }
        public Store store { get; set; }
    }
}
