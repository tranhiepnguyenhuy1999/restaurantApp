using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace restaurant_management.DTO
{
    public class DetailBill
    {
        private int iD;
        private int amount;
        private int iD_bill;
        private string food_name;
        public DetailBill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Amount = (int)row["amount"];
            this.ID_bill = (int)row["id_bill"];
            this.Food_name = row["food_name"].ToString();
        }
        public int ID { get => iD; set => iD = value; }
        public int Amount { get => amount; set => amount = value; }
        public int ID_bill { get => iD_bill; set => iD_bill = value; }
        public string Food_name { get => food_name; set => food_name = value; }
    }
}
