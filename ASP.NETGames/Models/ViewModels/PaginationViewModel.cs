using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETGames.Models.ViewModels
{
    public class PaginationViewModel
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public int Page { get; set; }
        public int PageCount { get; set; }
        public int FirstPage { get; set; }
        public int LastPage { get; set; }
        public Dictionary<string, string> RouteData { get; set; }
    }
}
