using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETGames.Models
{
    public class Screenshots
    {
        public int id { get; set; }
        public string image { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
        public bool? is_deleted { get; set; }
    }
}
