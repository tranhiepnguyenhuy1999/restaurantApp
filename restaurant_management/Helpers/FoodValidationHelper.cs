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
            if (String.IsNullOrEmpty(name) ||
                String.IsNullOrEmpty(price) ||
                String.IsNullOrEmpty(type) ||
                !IsFloatOrInt(price))
            {
                return false;
            }
            return true;
        }

        static bool IsFloatOrInt(string value)
        {
            int intValue;
            float floatValue;
            return Int32.TryParse(value, out intValue) || float.TryParse(value, out floatValue);
        }
    }
}
