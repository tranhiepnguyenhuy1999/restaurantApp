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
        public List<Bill> getListBillByDate(int day0,int month0,int year0)//tim kiem theo ngay thang nam
        {
            List<Bill> listbill = new List<Bill>();
            string day = day0.ToString();
            string month = month0.ToString();
            string year= year0.ToString();
            string query = "SELECT * FROM bill WHERE day(create_date)=" +day+ " and monnth(create_date)="+month+" and year(create_date)="+year;
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in datatb.Rows)
            {
                Bill bill = new Bill(item);
                listbill.Add(bill);
            }
            return listbill;
        }
        public List<Bill> getListBillByDay(int day0) //tim kiem theo ngay
        {
            List<Bill> listbill = new List<Bill>();
            string day = day0.ToString();
            string query = "SELECT * FROM bill WHERE day(create_date)="+day;
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in datatb.Rows)
            {
                Bill bill = new Bill(item);
                listbill.Add(bill);
            }
            return listbill;
        }
        public List<Bill> getListBillByMonth(int month0) //tim kiem theo thang
        {
            List<Bill> listbill = new List<Bill>();
            string month = month0.ToString();
            string query = "SELECT * FROM bill WHERE month(create_date)=" + month;
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in datatb.Rows)
            {
                Bill bill = new Bill(item);
                listbill.Add(bill);
            }
            return listbill;
        }
        public List<Bill> getListBillByBillMoney_ASC() //sap xep bill theo tong gia tien tang dan
        {
            List<Bill> listbill = new List<Bill>();
            string query = "select * from bill order by total_money ASC";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in datatb.Rows)
            {
                Bill bill = new Bill(item);
                listbill.Add(bill);
            }
            return listbill;
        }
        public List<Bill> getListBillByBillMoney_DESC() //sap xep bill theo  tong gia tien giam dan
        {
            List<Bill> listbill = new List<Bill>();
            string query = "select * from bill order by total_money DESC";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in datatb.Rows)
            {
                Bill bill = new Bill(item);
                listbill.Add(bill);
            }
            return listbill;
        }
        public List<Bill> getListBillByBillDate_Latest() //sap xep theo thoi gian som nhat ->muon nhat
        {
            List<Bill> listbill = new List<Bill>();
            string query = "select * from bill order by create_date DESC;";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in datatb.Rows)
            {
                Bill bill = new Bill(item);
                listbill.Add(bill);
            }
            return listbill;
        }
        public List<Bill> getListBillByBillDate_Oldest() //sap xep theo thoi gian muon nhat ->som nhat
        {
            List<Bill> listbill = new List<Bill>();
            string query = "select * from bill order by create_date ASC;";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in datatb.Rows)
            {
                Bill bill = new Bill(item);
                listbill.Add(bill);
            }
            return listbill;
        }
        public List<Bill> getListBillByBill_LowestAmount() //sap xep theo tong so luong mon an it nhat->nhieu nhat
        {
            List<Bill> listbill = new List<Bill>();
            string query = "select * from bill order by total_amount ASC;";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in datatb.Rows)
            {
                Bill bill = new Bill(item);
                listbill.Add(bill);
            }
            return listbill;
        }
        public List<Bill> getListBillByBill_HighestAmount() //sap xep theo tong so luong mon an nhieu nhat->it nhat
        {
            List<Bill> listbill = new List<Bill>();
            string query = "select * from bill order by total_amount DESC;";

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
