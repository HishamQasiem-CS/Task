using System.ComponentModel.DataAnnotations;

namespace Task.Models
{
    public class BasicInformation
    {
       
        public int BasicInformationId { get; set; }
        [Display(Name = "Restaurant Name")]
        public string RestaurantName { get; set; }
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }
        [Display(Name = "Street Name")]
        public string StreetName { get; set; }

        [Required]
        [Display(Name = "Opening Hourse the Restaurant")]
        public TimeSpan OpeningHourse { get; set; }
        [Required]
        [Display(Name = "Close Hourse the Restaurant")]

        public TimeSpan CloseHourse { get; set; }
        [Display(Name = "Landmarks nearby")]

        public string ListOfNearbyLandmarks { get; set; }
        public DateTime RegisterationTime { get; set; } = DateTime.Now;

    }
}
