using Microsoft.EntityFrameworkCore;
using Task.Models;

namespace Task.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        
        }
        public DbSet<BasicInformation> BasicInformation { get; set; }
        public DbSet<Menu> menus { get; set; }

        public DbSet<Maintenance> maintenances { get; set; }


    }
}
