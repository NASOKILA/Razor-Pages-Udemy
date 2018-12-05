using System;
using System.ComponentModel.DataAnnotations;

namespace TasteRestaurant.Data
{
    public class OrderHeader
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public double OrderTotal { get; set; }

        [Required]
        public DateTime PickUpTime { get; set; }
        
        public string Status { get; set; }

        public string Comments { get; set; }
    }
}
