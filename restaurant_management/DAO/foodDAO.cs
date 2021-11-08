using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private foodDAO() { }

        private int insertNewFood(string name, float price, int id_kind) {
            int result = 0;
            DateTime create_date = new DateTime();
            string query = "insertUser ( @food_name , @price , @id_kind , @create_date )";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, price, id_kind, create_date.ToString() });
            return result;
        }
    }
}
