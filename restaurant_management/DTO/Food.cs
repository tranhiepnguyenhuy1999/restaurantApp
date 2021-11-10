using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    public class Food
    {
        private int iD;
        private string food_name;
        private float price;
        private int id_kind;
        private DateTime create_date;

        public Food(DataRow row)
        {
            this.ID = 1;
            this.Food_name = row["food_name"].ToString();
            this.Price = (float)row["price"];
            this.Id_kind = (int)row["id_kind"];
            this.Create_date = DateTime.Parse(row["create_date"].ToString());
        }

        public Food(int id, string food_name, float price, int id_kind, DateTime create_date)
        {
            this.iD = id;
            this.food_name = food_name;
            this.price = price;
            this.id_kind = id_kind;
            this.create_date = create_date;
        }

        public Food() { }
        public int ID { get => iD; set => iD = value; }
        public string Food_name { get => food_name; set => food_name = value; }
        public float Price { get => price; set => price = value; }
        public int Id_kind { get => id_kind; set => id_kind = value; }
        public DateTime Create_date { get => create_date; set => create_date = value; }
    }
}
