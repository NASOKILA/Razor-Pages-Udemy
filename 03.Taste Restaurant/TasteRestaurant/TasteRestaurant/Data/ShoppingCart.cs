using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TasteRestaurant.Data
{
    public class ShoppingCart
    {
        [Required]
        public int Id { get; set; }

        public int MenuItemId { get; set; }

        public string ApplicationUserId { get; set; }
        
        [NotMapped]
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }
        
        [NotMapped]
        [ForeignKey("MenuItemId")]
        public MenuItem MenuItem { get; set; }

        [Range(0, int.MaxValue,ErrorMessage = "Enter a value bigger than 0 !")]
        public int Count { get; set; }
    }
}
