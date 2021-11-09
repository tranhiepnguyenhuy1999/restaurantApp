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
    }
}
