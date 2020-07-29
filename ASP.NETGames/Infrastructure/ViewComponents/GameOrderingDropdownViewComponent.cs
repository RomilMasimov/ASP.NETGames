using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP.NETGames.Infrastructure.ViewComponents
{
    public class GameOrderingDropdownViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string selectedValue)
        {
            return View(new SelectList(
                new[]
                {
                    new {Name = "Not Sorting", Value = ""},
                    new {Name = "Rating", Value = "-rating"},
                    new {Name = "Name", Value = "-name"},
                    new {Name = "Released", Value = "-released"},
                    new {Name = "Created", Value = "-created"},
                    new {Name = "Added", Value = "added"}
                },
                "Value", "Name", selectedValue));
        }
    }
}