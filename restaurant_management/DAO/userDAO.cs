using System;
using restaurant_management.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

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

        public DataTable getUserList (string name = "")
        {
            DataTable data;
            string query;
            if (!name.Equals(""))
            {
                query = "SELECT * FROM user WHERE LOWER(first_name) LIKE CONCAT('%', CONVERT('" + name + "', BINARY), '%') OR  LOWER(last_name) LIKE CONCAT('%', CONVERT('" + name + "', BINARY), '%')";
            }
            else
            {
                query = "select * from user";
            }
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public int insertNewUser(string firstName, string lastName,string phone, DateTime birthDay, string user_name, string user_password, DateTime create_date,int gender) {

            byte[] temp = ASCIIEncoding.ASCII.GetBytes(user_password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hashPassword = "";

            foreach (byte item in hasData)
            {
                hashPassword += item;
            }


            int result = 0;
            string query = "call insertUser0 ( @first_name , @last_name , @phone , @birthday , @user_name , @user_password , @create_date , @gender )";

            result = DataProvider.Instance.ExecuteNonQuery(query, new object[]{ firstName, lastName, phone ,birthDay, user_name, hashPassword, create_date ,gender});

            return result;
                
        }

        public bool updateUser(int id0,string first_name,string last_name ,string phone,DateTime birthday, string user_name, string user_password,int gender)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(user_password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hashPassword = "";

            foreach (byte item in hasData)
            {
                hashPassword += item;
            }


            int result = 0;
            string query = "call updateUser0 ( @id0 ,  @first_name , @last_name , @phone , @birthday , @user_name , @user_password , @gender )";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id0, first_name, last_name ,phone, birthday,user_name, hashPassword, gender });
            if (result == 0)
                return false;
            return true;
        }

        internal void insertNewUser(string text1, string text2, string text3, DateTime date, string text4, string text5, int g)
        {
            throw new NotImplementedException();
        }

        public User GetUserByID(int ID)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from user where id = " + ID);
            foreach (DataRow item in data.Rows)
            {
                return new User(item);
            }
            return null;
        }

        public User GetIdByUsernamePwd(String username, String password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hashPassword = "";
             
            foreach (byte item in hasData)
            {
                hashPassword += item;
            }
            
            string query = "SELECT * FROM user WHERE user_name = '" + username + "' AND user_password = '" + hashPassword + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                return new User(item);
            }
            return null;
        }
        public void deleteUser(string userName)
        {
            string query = "delete from user where user_name=" + "'"+userName+ "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            System.Windows.Forms.MessageBox.Show("Xoa thanh cong!");

        }
        public int getidbyname(string user_name)
        {
            int  id = 0;
            string query2 = "SELECT  id FROM user  where user_name=" + "'" + user_name + "'";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query2);
            foreach (DataRow item in datatb.Rows)
            {
                id = (int)item["id"];
            }
            return id; //lay id bang user name
        }
    }
}
