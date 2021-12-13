using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using restaurant_management.DTO;
using System.Data;
using restaurant_management.Models;

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
        //flag =0,khong lam gi
        //flag =1 sap xep theo so luong mon an cua bill tang dan
        //flag =2 sap xep theo so luong mon an cua bill giam 
        //flag =3 sap xep theo so tien thanh toan cua bill tang dan
        //flag =4 sap xep theo so tien thanh toan cua bill giam dan
        //flag =5 sap xep theo thoi gian som nhat ->muon nhat
        //flag =6 sap xep theo thoi gian muon nhat ->som nhat
        public List<Bill> getListBillByDate(DateTime create_day0,int flag=0)//tim kiem theo ngay thang nam/thang nam + sort
        {
            List<Bill> listbill = new List<Bill>();
            if(flag==0)
            {
                string query = "call findDateBill( @create_day0 )";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query, new object[] { create_day0 });
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if(flag==1)
            {
                string query = "call findDateBill1( @create_day0 )";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query, new object[] { create_day0 });
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 2)
            {
                string query = "call findDateBill2( @create_day0 )";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query, new object[] { create_day0 });
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 3)
            {
                string query = "call findDateBill3( @create_day0 )";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query, new object[] { create_day0 });
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 4)
            {
                string query = "call findDateBill4( @create_day0 )";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query, new object[] { create_day0 });
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 5)
            {
                string query = "call findDateBill5( @create_day0 )";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query, new object[] { create_day0 });
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 6)
            {
                string query = "call findDateBill6( @create_day0 )";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query, new object[] { create_day0 });
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            return listbill;
        }
        public List<Bill> getListBillByDay(int day0,int flag=0) //tim kiem theo ngay
        {
            List<Bill> listbill = new List<Bill>();
            string day = day0.ToString();
            if(flag==0)
            {
                string query = "SELECT * FROM bill WHERE day(create_date)=" + day;
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 1)
            {
                string query = "SELECT * FROM bill WHERE day(create_date)=" + day + " order by total_amount ASC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 2)
            {
                string query = "SELECT * FROM bill WHERE day(create_date)=" + day + " order by total_amount DESC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 3)
            {
                string query = "SELECT * FROM bill WHERE day(create_date)=" + day + " order by total_money ASC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 4)
            {
                string query = "SELECT * FROM bill WHERE day(create_date)=" + day + " order by total_money DESC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 5)
            {
                string query = "SELECT * FROM bill WHERE day(create_date)=" + day + "order by create_date DESC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 5)
            {
                string query = "SELECT * FROM bill WHERE day(create_date)=" + day + "order by create_date ASC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            return listbill;
        }
        public List<Bill> getListBillByMonth(int month0,int flag=0) //tim kiem theo thang
        {
            List<Bill> listbill = new List<Bill>();
            string month = month0.ToString();
            if(flag==1)
            {
                string query = "SELECT * FROM bill WHERE month(create_date)=" + month + " order by total_amount ASC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 2)
            {
                string query = "SELECT * FROM bill WHERE month(create_date)=" + month + " order by total_amount DESC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 3)
            {
                string query = "SELECT * FROM bill WHERE month(create_date)=" + month + "  order by total_money ASC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 4)
            {
                string query = "SELECT * FROM bill WHERE month(create_date)=" + month + "  order by total_money DESC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 5)
            {
                string query = "SELECT * FROM bill WHERE month(create_date)=" + month + " order by create_date DESC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 6)
            {
                string query = "SELECT * FROM bill WHERE month(create_date)=" + month + "  order by create_date ASC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else
            {
                string query = "SELECT * FROM bill WHERE month(create_date)=" + month;
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            return listbill;
        }
        public List<Bill> getListBillByYear(int year0,int flag=0) //tim kiem theo nam
        {
            List<Bill> listbill = new List<Bill>();
            string year = year0.ToString();
            if(flag==1)
            {
                string query = "SELECT * FROM bill WHERE year(create_date)=" + year + " order by total_amount ASC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 2)
            {
                string query = "SELECT * FROM bill WHERE year(create_date)=" + year + " order by total_amount DESC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 3)
            {
                string query = "SELECT * FROM bill WHERE year(create_date)=" + year + " order by total_money ASC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 4)
            {
                string query = "SELECT * FROM bill WHERE year(create_date)=" + year + " order by total_money DESC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 5)
            {
                string query = "SELECT * FROM bill WHERE year(create_date)=" + year + " order by create_date DESC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else if (flag == 6)
            {
                string query = "SELECT * FROM bill WHERE year(create_date)=" + year + " order by create_date ASC";
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            else
            {
                string query = "SELECT * FROM bill WHERE year(create_date)=" + year;
                DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in datatb.Rows)
                {
                    Bill bill = new Bill(item);
                    listbill.Add(bill);
                }
            }
            return listbill;
        }
        public int insertNewBill(int total_amount, float @total_monney, DateTime @create_day)
        {
            int result = 0, id = 0;
            string query1 = "call  insertBill ( @total_amount , @total_monney , @create_day )";
            result = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { total_amount, total_monney, create_day });
            string query2 = "SELECT  id FROM bill  order by id DESC  LIMIT 1";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query2);
            foreach (DataRow item in datatb.Rows)
            {
                id = (int)item["id"];
            }
            return id; //0 chen bill khong thanh cong , khac 0 thanh cong tra lai id bill
        }
        public int insertDetailBillofBill(int id_bill,int amount, string food_name,float price) // chen detail bill dua vao id bill
        {
            int result = 0;
            string query1 = "call insertBillDetail(  @id_bill , @amount , @food_name , @price  )";
            result = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { id_bill,amount, food_name, price });
            return result;
        }//chen vao bill dua vao id bill ,tra ve 0 thi chen k thanh cong khac 0 thi thanh cong
        public int insertNewBillWithBillDetails(List<BillDetailsModel> bill_details, int total_amount, float total_money)
        {
            int id = 0;
            return id;
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
