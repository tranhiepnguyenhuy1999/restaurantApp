﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace restaurant_management.DAO
{
    public class foodDAO
    {
        private static foodDAO instance;

        public static foodDAO Instance
        {
            get { if (instance == null) { return instance = new foodDAO(); } return instance; }
            private set => instance = value;
        }

        private foodDAO() {
        }

        public int insertNewFood(string name, float price, int id_kind) {
            int result = 0;
            DateTime create_date = new DateTime();
            string query = "insertNewFood ( @food_name , @price , @id_kind , @create_date )";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, price, id_kind, create_date.ToString() });
            return result;
        }

        public List<DTO.Food> getListFood(string name = "")
        {
            string query;
            if(!name.Equals(""))
            {
                query = "select * from food where food_name=" + '"' + name + '"';
            }
            else query = "select * from food";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.AsEnumerable().Select(m => new DTO.Food()
            {
                ID = m.Field<int>("id"),
                Food_name = m.Field<string>("food_name"),
                Price = m.Field<float>("price"),
                Id_kind = m.Field<int>("id_kind"),
                Create_date = m.Field<DateTime>("create_date")
            }).ToList();
        }

        public List<DTO.Food> getListFoodByName(string name)
        {
            return this.getListFood(name);
        }
    }
}
