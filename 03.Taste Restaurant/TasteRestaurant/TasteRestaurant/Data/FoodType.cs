using System.ComponentModel.DataAnnotations;

namespace TasteRestaurant.Data
{
    public class FoodType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
