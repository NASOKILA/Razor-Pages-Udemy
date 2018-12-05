using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TasteRestaurant.Data
{
    public class OrderDetails
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        public OrderHeader Order { get; set; }

        [Required]
        public int MenuItemId { get; set; }

        public MenuItem MenuItem { get; set; }

        [Required]
        public int Count { get; set; }
        
        //The next properties we need to keep track of old nonexistent orders make in the past.

        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
