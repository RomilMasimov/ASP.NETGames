using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETGames.Models
{

    public class ScreenshotsByIdResponce
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public IEnumerable<Screenshots> results { get; set; }
    }

}
