﻿using System;
using restaurant_management.DTO;
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

        public int insertNewUser(string firstName, string lastName,string phone, DateTime birthDay, string user_name, string user_password, DateTime create_date) {
            int result = 0;
            string query = "insertUser ( @first_name , @last_name , @phone , @birthday , @user_name , @user_password , @create_date   )";

            result = DataProvider.Instance.ExecuteNonQuery(query, new object[]{ firstName, lastName, phone ,birthDay, user_name, user_password,create_date });

            return result;
                
        }

        public bool updateUser(int id,string first_name,string last_name ,string phone,DateTime birthday, string user_name, string user_password)
        {
            int result = 0;
            string query = "call updateUser ( @id , @first_name , @last_name ,@phone , @birthday ,@user_name, @user_password";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, first_name, last_name ,phone, birthday,user_name, user_password });
            if (result == 0)
                return false;
            return true;
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


        public int GetIdByUsernamePwd(String username, String password)
        {
            int id = -1;
            string query = "SELECT id FROM user WHERE user_name = '" + username + "' AND user_password = '" + password + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                id = int.Parse(row["id"].ToString());
            }
            return id;
        }
    }
}
