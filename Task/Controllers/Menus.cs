using Microsoft.AspNetCore.Mvc;
using Task.Data;
using Task.Models;

namespace Task.Controllers
{
    public class Menus : Controller
    {
        private AppDbContext _db;
        public Menus(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Menu menu)
        {
            
                _db.menus.Add(menu);
                _db.SaveChanges();
                return RedirectToAction("Done", "Home");
            
        }
        public IActionResult DisplayMenu()
        {
            var result = _db.menus.ToList();
            return View(result);
        }
    }
}
