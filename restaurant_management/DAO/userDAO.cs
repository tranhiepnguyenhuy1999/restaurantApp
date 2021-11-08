using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_management.DAO
{
    class userDAO
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
            string query = " CALL insertUser ( @first_name , @last_name , @birthday , @create_date )";

            result = DataProvider.Instance.ExecuteNonQuery(query, new object[]{ firstName, lastName, birthDay, createDate});

            return result;
                
        }
    }
}
