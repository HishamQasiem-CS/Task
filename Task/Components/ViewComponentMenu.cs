using Microsoft.AspNetCore.Mvc;
using Task.Models;

namespace Task.Components
{
    [ViewComponent(Name = "MenuComponent")]
    public class ViewComponentMenu: ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(Menu menu)
        {
            return View(menu);
        }
    }
}
