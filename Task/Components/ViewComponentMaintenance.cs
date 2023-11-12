using Microsoft.AspNetCore.Mvc;
using Task.Models;

namespace Task.Components
{
    [ViewComponent(Name = "Maintenance")]
    public class ViewComponentMaintenance:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Maintenance maintenance)
        {
            return View(maintenance);
        }
    }
}
