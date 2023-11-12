using Microsoft.AspNetCore.Mvc;
using Task.Models;

namespace Task.Components
{
    [ViewComponent(Name ="First")]
    public class ViewComponentEE:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(BasicInformation basicInformation)
        {
            return View(basicInformation);
        }
    }
}
