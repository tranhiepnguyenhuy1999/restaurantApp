using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    public class userDAO
    {
        private static userDAO instance;

        public static userDAO Instance
        {
            get { if (instance == null) { return instance = new userDAO(); } return instance; }
            private set => instance = value;
        }

        private userDAO() { }

        public DataTable getUserList ()
        {
            DataTable data;
            string query = "select * from user";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public int insertNewUser(string firstName, string lastName, string birthDay, string createDate) {
            int result = 0;
            string query = "insertUser ( @first_name , @last_name , @birthday , @create_date )";

            result = DataProvider.Instance.ExecuteNonQuery(query, new object[]{ firstName, lastName, birthDay, createDate});

            return result;
                
        }
        public bool updateUser(int id,string first_name,string last_name ,DateTime birthday,int gender)
        {
            int result = 0;
            string query = "call updateUser ( @id , @first_name , @last_name , @birthday , @gender )";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, first_name, last_name, birthday, gender });
            if (result == 0)
                return true;
            return false;
        }
    }
}
