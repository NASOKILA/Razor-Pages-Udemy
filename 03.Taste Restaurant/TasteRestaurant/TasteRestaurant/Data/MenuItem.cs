using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TasteRestaurant.Data
{
    public class MenuItem
    {
        //[NotMapped]   We can use NotMapped for propertires which we do not want in our database or just the "virtual" keyword
        //private string PriceErrorMessage = $"The Range is between 1 and  {int.MaxValue.ToString()} !";
            
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage="Price should be greather than ${1} and less than ${2} !")]
        public double Price { get; set; }

        public string Image { get; set; }

        [Required]
        public string Spicyness { get; set; }

        public enum ESpicy {Mild=0, Moderate=1, High=2 }

        [Required]
        [Display(Name = "Category Type")]
        public CategoryType CategoryType { get; set; }

        public int CategoryTypeId { get; set; }

        [Required]
        [Display(Name="Food Type")]
        public FoodType FoodType { get; set; }

        public int FoodTypeId { get; set; }
    }
}
