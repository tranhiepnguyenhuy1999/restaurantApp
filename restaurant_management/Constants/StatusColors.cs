using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.Constants
{
    public class StatusColors
    {
        public static Color Empty { get; } = Color.FromArgb(0, 153, 68); // Green
        public static Color Occupied { get; } = Color.FromArgb(207, 0, 15); // Red
        public static Color Disabled { get; } = Color.Gray;
    }
}
