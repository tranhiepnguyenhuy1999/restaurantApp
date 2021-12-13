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
        private int gender;
        private string user_name;
        private string user_password;
        private string phone;
        private string userRole;
        public User(DataRow row) {
            this.ID = (int)row["id"];
            this.First_name = row["first_name"].ToString();
            this.Last_name = row["last_name"].ToString();
            this.Birthday = DateTime.Parse(row["birthday"].ToString());
            this.Create_date = DateTime.Parse(row["create_date"].ToString());
            this.Gender = (int)row["gender"];
            this.User_name= row["user_name"].ToString();
            this.User_password = row["user_password"].ToString();
            this.Phone = row["phone"].ToString();
            this.UserRole = row["userRole"].ToString();
        }

        public int ID { get => iD; set => iD = value; }
        public int Gender { get => gender; set => gender = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public DateTime Create_date { get => create_date; set => create_date = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string User_password { get => user_password; set => user_password = value; }
        public string Phone { get => phone; set => phone = value; }
        public string UserRole { get => userRole; set => userRole = value; }
    }
}
