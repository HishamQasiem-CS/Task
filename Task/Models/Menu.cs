using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Task.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
       
        public ItemName ItemName { get; set; }
        [Display(Name = "Meal Serving time")]
        [Required]
        public TimeSpan SavingTime { get; set; }
    }
    public enum ItemName
    {
        Spaghetti_Bolognese, Chicken_Alfredo, Sushi_Rolls, Vegetable_Stir_Fry,
        Margherita_Pizza, Grilled_Salmon, Beef_Tacos, Chicken_Shawarma, Caprese_Salad,
        Penne_alla_Vodka, Shrimp_Pad_Thai, Vegetarian_Lasagna, Mushroom_Risotto, Pizza
    } }

