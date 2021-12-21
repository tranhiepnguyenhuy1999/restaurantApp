using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.Helpers
{
    public static class FoodValidationHelper
    {
        public static bool isFoodValid(string name, string price, string type)
        {
            float _price = 0;
            if (String.IsNullOrEmpty(name) ||
                String.IsNullOrEmpty(price) ||
                String.IsNullOrEmpty(type) ||
                !IsFloatOrInt(price, ref _price))
            {
                return false;
            }
            return _price > 0 ? true : false;
        }

        static bool IsFloatOrInt(string value, ref float price)
        {
            int intValue;
            return Int32.TryParse(value, out intValue) || float.TryParse(value, out price);
        }
    }
}
