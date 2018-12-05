using System.ComponentModel.DataAnnotations;

namespace TasteRestaurant.Data
{
    public class CategoryType
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name="Display Order")]  // This is how it should look
        public int DisplayOrder { get; set; }
    }
}
