using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DTO
{
    public class User
    {
        private int iD;
        private string first_name;
        private string last_name;
        private DateTime birthday;
        private DateTime create_date;
        public User(DataRow row) {
            this.ID = (int)row["id"];
            this.First_name = row["first_name"].ToString();
            this.Last_name = row["last_name"].ToString();
            this.Birthday = DateTime.Parse(row["birthday"].ToString());
            this.Create_date = DateTime.Parse(row["create_date"].ToString());
        }

        public int ID { get => iD; set => iD = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public DateTime Create_date { get => create_date; set => create_date = value; }
    }
}
