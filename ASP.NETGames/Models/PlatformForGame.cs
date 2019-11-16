using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETGames.Models
{
    public class PlatformForGame
    {
        public Platform platform { get; set; }
        public string released_at { get; set; }
        public Requirements requirements { get; set; }
    }
}
