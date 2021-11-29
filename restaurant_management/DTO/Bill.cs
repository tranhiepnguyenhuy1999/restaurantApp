using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace restaurant_management.DTO
{
    public class Bill
    {
        private int iD;
        private float total_money;
        private int total_amount;
        private DateTime date;
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.total_money = (float)row["total_money"];
            this.total_amount = (int)row["total_amount"];
            this.date = DateTime.Parse(row["create_date"].ToString());
        }
        public int ID { get => iD; set => iD = value; }
        public float Total_money { get => total_money; set => total_money = value; }
        public int Total_amount { get => total_amount; set => total_amount = value; }
        public DateTime Date { get => date; set => date = value; }

    }
}
