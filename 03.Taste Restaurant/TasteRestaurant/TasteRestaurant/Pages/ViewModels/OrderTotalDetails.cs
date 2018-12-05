using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasteRestaurant.Data;

namespace TasteRestaurant.Pages.ViewModels
{
    public class OrderTotalDetails
    {
        public OrderTotalDetails()
        {
            orderHeader = new OrderHeader();
            orderDetailsList = new List<OrderDetails>();
        }

        public OrderHeader orderHeader { get; set; }

        public List<OrderDetails> orderDetailsList { get; set; }
    }
}
