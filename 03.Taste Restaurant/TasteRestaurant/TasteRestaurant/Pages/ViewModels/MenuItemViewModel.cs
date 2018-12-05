using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasteRestaurant.Data;

namespace TasteRestaurant.Pages.ViewModels
{
    public class MenuItemViewModel
    {
        public MenuItem menuItem { get; set; }

        public IList<CategoryType> categoryTypes { get; set; }

        public IList<FoodType> foodTypes { get; set; }
    }
}
