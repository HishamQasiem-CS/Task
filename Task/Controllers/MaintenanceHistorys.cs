using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Task.Data;
using Task.Models;

namespace Task.Controllers
{
    public class MaintenanceHistorys : Controller
    {
        private AppDbContext _db;
        public MaintenanceHistorys(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Maintenance maintenance)
        {
           _db.maintenances.Add(maintenance);
                _db.SaveChanges();
                return RedirectToAction("Done", "Home");
         
        }
        public IActionResult DisplayInformationMaintenance()
        {
            var result = _db.maintenances.ToList();
           
            return View(result);
        }
    }
}
