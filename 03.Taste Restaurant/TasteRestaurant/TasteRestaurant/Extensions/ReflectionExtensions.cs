namespace TasteRestaurant.Extensions
{
    public static class ReflectionExtensions
    {
        public static string GetPropertyValue<T>(this T item, string propertyName) {

            //We take the value of a property we pass
            return item.GetType().GetProperty(propertyName).GetValue(item, null).ToString();
        }

    }
}
