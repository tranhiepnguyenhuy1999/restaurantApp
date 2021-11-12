using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using restaurant_management.DTO;
using System.Data;
namespace restaurant_management.DAO
{
    public class detailBillDAO
    {
        private static detailBillDAO instance;
        public static detailBillDAO Instance
        {
            get { if (instance == null) { return instance = new detailBillDAO(); } return instance; }
            private set => instance = value;
        }
        private detailBillDAO() { }
        public List<DetailBill> getListBillById(int id)
        {
            List<DetailBill> list = new List<DetailBill>();
            string Id = id.ToString();
            string query = "SELECT * FROM bill_detail WHERE id_bill=" + Id;
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in datatb.Rows)
            {
                DetailBill dtbill = new DetailBill(item);
                list.Add(dtbill);
            }
            return list;
        }
    }
}
