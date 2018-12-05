using System.Collections.Generic;
using TasteRestaurant.Data;

namespace TasteRestaurant.Pages.ViewModels
{
    public class OrderDetailsCart
    {
        public OrderHeader OrderHeader { get; set; }

        public List<ShoppingCart> ShoppingCart { get; set; }
    }
}
