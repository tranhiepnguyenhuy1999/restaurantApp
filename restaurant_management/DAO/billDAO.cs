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

        private int insertNewBill(int total_amount, float total_monney, DateTime create_day, string food_name, float price, int id_kind)
        {
            int result = 0, id = 0;
            string query1 = "call  insertBill( @total_amount , @total_monney , @create_day)";
            result = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { total_amount, price, id_kind, create_day });
            string query2 = "SELECT  id FROM bill  order by id DESC  LIMIT 1";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query2);
            foreach (DataRow item in datatb.Rows)
            {
                id = (int)item["id"];
            }
            return id; //0 chen bill khong thanh cong , khac 0 thanh cong tra lai id bill
        }
        private int insertDetailBillofBill(int amount, int id_food, int id_bill) // chen detail bill dua vao id bill
        {
            int result = 0;
            string query1 = "call insertBillDetail( @amount , @id_food , @id_bill)";
            result = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { amount, id_food, id_bill });
            return result;
        }//chen vao bill dua vao id bill ,tra ve 0 thi chen k thanh cong khac 0 thi thanh cong
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
