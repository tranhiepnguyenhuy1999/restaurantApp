using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

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
            string create_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string query = "call insertNewFood ( @food_name , @price , @id_kind , @create_date )";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, price, id_kind, create_date});
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
        public void exportExcelListFood(string name = "")
        {
            string query;
            if (!name.Equals(""))
            {
                query = "select * from food where food_name=" + '"' + name + '"';
            }
            else query = "select * from food";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            try
            {
                if (data == null || data.Columns.Count == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                var excelApp = new Excel.Application();
                excelApp.Workbooks.Add();

                // single worksheet
                Excel._Worksheet workSheet = excelApp.ActiveSheet;

                // column headings
                for (var i = 0; i < data.Columns.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = data.Columns[i].ColumnName;
                }

                // rows
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (var j = 0; j < data.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1] = data.Rows[i][j];
                    }
                }

                // check file path
                if (!string.IsNullOrEmpty(""))
                {
                    try
                    {
                        workSheet.SaveAs("excelFilePath");
                        excelApp.Quit();
                        MessageBox.Show("Excel file saved!");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                            + ex.Message);
                    }
                }
                else
                { // no file path is given
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }
        public List<DTO.Food> getListFoodByName(string name)
        {
            return this.getListFood(name);
        }

        public bool updateProps(int id, string food_name, float price, int id_kind)
        {
            int result = 0;
            string proc = "call updateFood ( @id_in , @food_name_in , @price_in , @id_kind_in )";
            result = DataProvider.Instance.ExecuteNonQuery(proc, new object[] { id, food_name, price, id_kind});
            return result > 0 ? true : false;
        }

        public bool deleteFood(int id)
        {
            int res = 0;
            string query = "call deleteFood ( @id_in )";
            res = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return res > 0 ? true : false;
        }
    }
}
