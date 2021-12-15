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
        /// </summary>
        /// <param name="create_day0"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        //flag =0,khong lam gi
        //flag2 =0 sap xep theo so luong mon an cua bill tang dan
        //flag2 =1 sap xep theo so luong mon an cua bill giam 
        //flag2 =2sap xep theo so tien thanh toan cua bill tang dan
        //flag2=3 sap xep theo so tien thanh toan cua bill giam dan
        //flag1 =0 sap xep theo thoi gian som nhat ->muon nhat
        //flag1 =1 sap xep theo thoi gian muon nhat ->som nhat
        //flag0= 0 all ,=1 year , =2 month ,=3 day ,=4 date

        public List<Bill> getListBill0(DateTime create_day0, int flag0 = 0, int flag1= 0,int flag2=0)
        {
            List<Bill> listbill = new List<Bill>();
            DataTable datatb =new DataTable();
            int year0 = create_day0.Year;
            string year = year0.ToString();
            int month0 = create_day0.Month;
            string month = month0.ToString();
            int day0 = create_day0.Day;
            string day = day0.ToString();

            if (flag0==0) //all
            {
                if(flag1==0)
                {
                    if(flag2==0)
                    {
                        string query = "select * from bill order by create_date DESC,total_amount asc";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if(flag2==1)
                    {
                        string query = "select * from bill order by create_date DESC,total_amount desc";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 2)
                    {
                        string query = "select * from bill order by create_date DESC,total_money asc";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 3)
                    {
                        string query = "select * from bill order by create_date DESC,total_money desc";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                }
                else if(flag1==1)
                {
                    if (flag2 == 0)
                    {
                        string query = "select * from bill order by create_date ASC,total_amount asc";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 1)
                    {
                        string query = "select * from bill order by create_date ASC,total_amount desc";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 2)
                    {
                        string query = "select * from bill order by create_date ASC,total_money asc";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 3)
                    {
                        string query = "select * from bill order by create_date ASC,total_money desc";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                }
            }
            else if(flag0==1) //year
            {
                if(flag1 == 0)
                {
                    if (flag2 == 0)
                    {
                        string query = "SELECT * FROM bill WHERE year(create_date)=" + year + " order by create_date DESC,total_amount ASC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 1)
                    {
                        string query = "SELECT * FROM bill WHERE year(create_date)=" + year + " order by create_date DESC,total_amount DESC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 2)
                    {
                        string query = "SELECT * FROM bill WHERE year(create_date)=" + year + " order by create_date DESC,total_money ASC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 3)
                    {
                        string query = "SELECT * FROM bill WHERE year(create_date)=" + year + " order by create_date DESC,total_money DESC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                }
                else if (flag1 == 1)
                {
                    if (flag2 == 0)
                    {
                        string query = "SELECT * FROM bill WHERE year(create_date)=" + year + " order by create_date ASC,total_amount ASC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 1)
                    {
                        string query = "SELECT * FROM bill WHERE year(create_date)=" + year + " order by create_date ASC,total_amount DESC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 2)
                    {
                        string query = "SELECT * FROM bill WHERE year(create_date)=" + year + " order by create_date ASC,total_money ASC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 3)
                    {
                        string query = "SELECT * FROM bill WHERE year(create_date)=" + year + " order by create_date ASC,total_money DESC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                }
            }
            else if (flag0 == 2) //month
            {
                if(flag1 == 0)
                {
                    if (flag2 == 0)
                    {
                        string query = "SELECT * FROM bill WHERE month(create_date)=" + month + " order by create_date DESC,total_amount ASC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 1)
                    {
                        string query = "SELECT * FROM bill WHERE month(create_date)=" + month + " order by create_date DESC,total_amount DESC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 2)
                    {
                        string query = "SELECT * FROM bill WHERE month(create_date)=" +month + " order by create_date DESC,total_money ASC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 3)
                    {
                        string query = "SELECT * FROM bill WHERE month(create_date)=" + month + " order by create_date DESC,total_money DESC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                }
                else if (flag1 == 1)
                {
                    if (flag2 == 0)
                    {
                        string query = "SELECT * FROM bill WHERE month(create_date)=" + month + " order by create_date ASC,total_amount ASC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 1)
                    {
                        string query = "SELECT * FROM bill WHERE month(create_date)=" + month + " order by create_date ASC,total_amount DESC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 2)
                    {
                        string query = "SELECT * FROM bill WHERE month(create_date)=" + month + " order by create_date ASC,total_money ASC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 3)
                    {
                        string query = "SELECT * FROM bill WHERE month(create_date)=" + month + " order by create_date ASC,total_money DESC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                }
            }
            else if (flag0 == 3)//DAY
            {
                if(flag1 == 0)
                {
                    if (flag2 == 0)
                    {
                        string query = "SELECT * FROM bill WHERE DAY(create_date)=" + day + " order by create_date DESC,total_amount ASC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 1)
                    {
                        string query = "SELECT * FROM bill WHERE DAY(create_date)=" + day + " order by create_date DESC,total_amount DESC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 2)
                    {
                        string query = "SELECT * FROM bill WHERE DAY(create_date)=" + day + " order by create_date DESC,total_money ASC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 3)
                    {
                        string query = "SELECT * FROM bill WHERE DAY(create_date)=" + day + " order by create_date DESC,total_money DESC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                }
                else if (flag1 == 1)
                {
                    if (flag2 == 0)
                    {
                        string query = "SELECT * FROM bill WHERE DAY(create_date)=" + day + " order by create_date ASC,total_amount ASC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 1)
                    {
                        string query = "SELECT * FROM bill WHERE DAY(create_date)=" + day + " order by create_date ASC,total_amount DESC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 2)
                    {
                        string query = "SELECT * FROM bill WHERE DAY(create_date)=" + day + " order by create_date ASC,total_money ASC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                    else if (flag2 == 3)
                    {
                        string query = "SELECT * FROM bill WHERE DAY(create_date)=" + day + " order by create_date ASC,total_money DESC";
                        datatb = DataProvider.Instance.ExecuteQuery(query);
                    }
                }
            }
            else if (flag0 == 4)//date
            {
                if (flag1 == 0)
                {
                    if (flag2 == 0)
                    {
                        string query = "call findDateBill01( @create_day0 )";
                        datatb = DataProvider.Instance.ExecuteQuery(query, new object[] { create_day0 });
                    }
                    else if (flag2 == 1)
                    {
                        string query = "call findDateBill02( @create_day0 )";
                        datatb = DataProvider.Instance.ExecuteQuery(query, new object[] { create_day0 });
                    }
                    else if (flag2 == 2)
                    {
                        string query = "call findDateBill03( @create_day0 )";
                        datatb = DataProvider.Instance.ExecuteQuery(query, new object[] { create_day0 });
                    }
                    else if (flag2 == 3)
                    {
                        string query = "call findDateBill04( @create_day0 )";
                        datatb = DataProvider.Instance.ExecuteQuery(query, new object[] { create_day0 });
                    }
                }
                else if (flag1 == 1)
                {
                    if (flag2 == 0)
                    {
                        string query = "call findDateBill11( @create_day0 )";
                        datatb = DataProvider.Instance.ExecuteQuery(query, new object[] { create_day0 });
                    }
                    else if (flag2 == 1)
                    {
                        string query = "call findDateBill12( @create_day0 )";
                        datatb = DataProvider.Instance.ExecuteQuery(query, new object[] { create_day0 });
                    }
                    else if (flag2 == 2)
                    {
                        string query = "call findDateBill13( @create_day0 )";
                        datatb = DataProvider.Instance.ExecuteQuery(query, new object[] { create_day0 });
                    }
                    else if (flag2 == 3)
                    {
                        string query = "call findDateBill14( @create_day0 )";
                        datatb = DataProvider.Instance.ExecuteQuery(query, new object[] { create_day0 });
                    }
                }
            }
            foreach (DataRow item in datatb.Rows)
            {
                Bill bill = new Bill(item);
                listbill.Add(bill);
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
