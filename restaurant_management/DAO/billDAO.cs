using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using restaurant_management.DTO;
using System.Data;
namespace restaurant_management.DAO
{
    public class billDAO
    {
        private static billDAO instance;
        public static billDAO Instance
        {
            get { if (instance == null) { return instance = new billDAO(); } return instance; }
            private set => instance = value;
        }
        private billDAO() { }
        public List<Bill> getListBillById(int id)
        {
            List<Bill> listbill = new List<Bill>();
            string Id = id.ToString();
            string query = "SELECT * FROM bill WHERE id=" + Id;
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in datatb.Rows)
            {
                Bill bill = new Bill(item);
                listbill.Add(bill);
            }
            return listbill;
        }
        public List<Bill> getListBillByDate(DateTime date)
        {
            List<Bill> listbill = new List<Bill>();
            string Date = date.ToString();
            string query = "SELECT * FROM bill WHERE date=" + Date;
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in datatb.Rows)
            {
                Bill bill = new Bill(item);
                listbill.Add(bill);
            }
            return listbill;
        }
        public List<Bill> getListBill()
        {
            List<Bill> listbill = new List<Bill>();
            string query = "SELECT * FROM bill";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in datatb.Rows)
            {
                Bill bill = new Bill(item);
                listbill.Add(bill);
            }
            return listbill;
        }
    }
}
