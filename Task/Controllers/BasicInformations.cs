using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net.NetworkInformation;
using Task.Data;
using Task.Models;

namespace Task.Controllers
{
    public class BasicInformations : Controller
    {
        private AppDbContext _db;
        public BasicInformations(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BasicInformation basicInformation)
        {
           
                _db.BasicInformation.Add(basicInformation);
                _db.SaveChanges();
                return RedirectToAction("Done", "Home");
           
        }
        public IActionResult DisplayInformationRestaurant()
        {
            var result = _db.BasicInformation.ToList();
            return View(result);
        }


    }
}
