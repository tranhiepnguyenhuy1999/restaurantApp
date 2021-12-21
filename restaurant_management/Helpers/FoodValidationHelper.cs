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

        public static bool isAgeRangeValid(decimal from, decimal to)
        {
            if (String.IsNullOrEmpty(from.ToString()) ||
                String.IsNullOrEmpty(to.ToString()))
            {
                return false;
            }
            if (from > to) return false;
            return true;
        }

        static bool IsFloatOrInt(string value, ref float price)
        {
            return float.TryParse(value, out price);
        }
    }
}
