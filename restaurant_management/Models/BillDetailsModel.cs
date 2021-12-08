using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.Models
{
    public class BillDetailsModel
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }
        public BillDetailsModel(string name, int quantity, float totalPrice)
        {
            Name = name;
            Quantity = quantity;
            TotalPrice = totalPrice;
        }
    }
}
