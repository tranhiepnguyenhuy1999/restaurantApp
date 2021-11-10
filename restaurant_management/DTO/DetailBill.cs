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
        private int iD_food;
        public DetailBill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Amount = (int)row["amount"];
            this.ID_bill = (int)row["id_bill"];
            this.ID_food = (int)row["id_food"];
        }
        public int ID { get => iD; set => iD = value; }
        public int Amount { get => amount; set => amount = value; }
        public int ID_food { get => iD_food; set => iD_food = value; }
        public int ID_bill { get => iD_bill; set => iD_bill = value; }


    }
}
