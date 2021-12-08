using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.Models
{
    public class TableModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public BillModel Bill { get; set; }
        public float TotalPrice { get; set; }
        public TableModel(int id, string name)
        {
            ID = id;
            Name = name;
            Random random = new Random();
            Bill = new BillModel(random.Next());
            TotalPrice = 0;
        }
        public void SetTotalPrice()
        {
            float price = 0;
            Bill.FoodList.ForEach(food => price += Bill.GetAFoodTotalPrice(food.ID));
            TotalPrice = price;
        }
    }
}
