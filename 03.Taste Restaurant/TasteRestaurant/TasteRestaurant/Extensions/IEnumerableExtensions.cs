using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TasteRestaurant.Extensions
{
    //This is an extention method.
    //extention methods are static classes
    public static class IEnumerableExtensions
    {
        //Here we will convert IEnumerable to a SelectList SO WE CAN DISPLAY IT INTO A RAZOR PAGE

        //And the mehods inside it are static as well so they can easily be called from the ouside this class.

        //The first argument has to be from the extended class with the "this" keyword
        //The second paramered is the value
        public static IEnumerable<SelectListItem> ToSelectListItem<T>(this IEnumerable<T> items, int selectedValue) {

            //for each item in the items we select a new SelectListItem(){ ... };
            return from item in items select new SelectListItem()
            {

                //We will get the values of each property
                Text = item.GetPropertyValue("Name"), //we use another extension method that we created for excluding the value of a property
                Value = item.GetPropertyValue("Id"), //The same here only for the Id property
                Selected = item.GetPropertyValue("Id").Equals(selectedValue.ToString())
            };
        }
    }
}
