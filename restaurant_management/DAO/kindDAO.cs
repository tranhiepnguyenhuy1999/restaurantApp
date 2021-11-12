using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace restaurant_management.DAO
{
    class kindDAO
    {
        private static kindDAO instance;

        public static kindDAO Instance
        {
            get { if (instance == null) { return instance = new kindDAO(); } return instance; }
            private set => instance = value;
        }

        private kindDAO() { }

        public List<DTO.Kind> getListKind()
        {
            List<DTO.Kind> res = new List<DTO.Kind>();

            string query = "select * from kind";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.AsEnumerable().Select(m => new DTO.Kind()
            {
                ID = m.Field<int>("id"),
                Kind_name = m.Field<string>("kind_name"),
                From_age = m.IsNull(2) ? 0 : m.Field<int>("from_age"),
                To_age = m.IsNull(3) ? 0 : m.Field<int>("to_age"),
                Create_date = m.Field<DateTime>("create_date")
            }).ToList();

        }

        public bool insertKind(int id, string kind_name, int from_age, int to_age, DateTime create_date)
        {
            int result = 0;
            string proc = "call insertKindFood ( @id , @kind_name , @from_age , @to_age , @create_date )";
           
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(proc, new object[] { id, kind_name, from_age, to_age, create_date.ToShortDateString()});
            }
            catch(MySql.Data.MySqlClient.MySqlException error)
            {
                return false;
            }

            return result > 0 ? true : false;
        }
    }
}
