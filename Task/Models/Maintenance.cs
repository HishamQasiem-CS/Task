using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Task.Models
{
    public class Maintenance
    {
        public int MaintenanceId { get; set; }
        [Display(Name = "Maintenance Date Start")]
        [Required]
        public DateTime MaintenanceDateStart { get; set; }
        [Required]
        [Display(Name = "Maintenance Date End")]
        public DateTime MaintenanceDateEnd { get; set; }
        [Required]
        public ImpactRestaurant ImpactRestaurant { get; set; }
        [Required]
        [Display(Name = "Quota")]
        public decimal Quota { get; set; }
        [Required]
        [Display(Name = "Comments")]

        public string Comments { get; set; }
        [Display(Name = "Restaurant Name")]
        [Required]
        public string RestaurantName { get; set; }

    }

    public enum ImpactRestaurant
    {
        Complete_Shutdown, Partial_Shutdown, Normal_operations

    }
}
    

