using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.Models
{
    public class FoodModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Type { get; set; }
        public DateTime CreatedDate { get; set; }

        public FoodModel(int id, string name, float price, string type, DateTime createdDate)
        {
            ID = id;
            Name = name;
            Price = price;
            Type = type;
            CreatedDate = createdDate;
        }
    }
}
