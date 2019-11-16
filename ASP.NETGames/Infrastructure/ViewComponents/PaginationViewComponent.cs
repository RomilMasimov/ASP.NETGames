using ASP.NETGames.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETGames.Infrastructure.ViewComponents
{
    public class PaginationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string controller, string action, int page, int pageCount, Dictionary<string, string> routeData)
        {
            int firstPage = 1;
            int lastPage = pageCount;
            if (pageCount > 6)
            {
                lastPage = page + 3;
                if (lastPage > pageCount)
                    lastPage = pageCount;
                firstPage = page - 3;
                if (firstPage < 1)
                    firstPage = 1;
            }

            var model = new PaginationViewModel
            {
                Controller = controller,
                Action = action,
                Page = page,
                PageCount = pageCount,
                FirstPage = firstPage,
                LastPage = lastPage,
                RouteData = routeData
            };

            return View(model);
        }
    }
}
