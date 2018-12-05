using System.ComponentModel.DataAnnotations;
using TasteRestaurant.Data;

namespace TasteRestaurant.Pages.ViewModels
{
    public class MenuItemDetails : MenuItem
    {
        [Required]
        [MinLength(1)]
        public string Count { get; set; }
    }
}
