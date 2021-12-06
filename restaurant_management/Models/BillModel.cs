using restaurant_management.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.Models
{
    public class BillModel
    {
        public int ID { get; set; }
        public List<FoodModel> FoodList { get; set; }
        public List<int> AmountList { get; set; }
        public BillModel(int id)
        {
            ID = id;
            FoodList = new List<FoodModel>();
            AmountList = new List<int>();
        }
        public float GetAFoodTotalPrice(int foodId)
        {
            FoodModel food = FoodList.Find(f => f.ID == foodId);
            var index = FoodList.IndexOf(food);
            var price = food.Price * AmountList[index];

            return price;
        }
        public List<BillDetailsModel> GetBillDetailsList()
        {
            List<BillDetailsModel> list = new List<BillDetailsModel>();
            var index = 0;
            foreach (var food in FoodList)
            {
                list.Add(new BillDetailsModel(food.Name, AmountList[index], GetAFoodTotalPrice(food.ID)));
                index++;
            }

            return list;
        }
    }
}
