using restaurant_management.DAO;
using restaurant_management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace restaurant_management
{
    public partial class bill_managementForm : Form
    {
        int check;
        public List<DTO.Bill> bills = new List<DTO.Bill>();
        void SaveList()
        {
            bills = (List<DTO.Bill>) dgv.DataSource;
        }
        void LoadListBill()
        {

            dgv.DataSource = billDAO.Instance.getListBill0(dateTimePicker1.Value,0,0,0);
            dateTimePicker1.Value = DateTime.Today;
            SaveList();
        }
        void findtotal()
        {
            int count = dgv.Rows.Count;
            long sum = 0;
            bill_count_txtbox.Text = count.ToString();
            for (int i =0;i<count;i++)
            {
                sum += int.Parse(dgv.Rows[i].Cells[1].Value.ToString());
            }
            sum_txtbox.Text = sum.ToString();
        }
        void findtotal1()
        {
            int count = dgv.Rows.Count-1;
            long sum = 0;
            bill_count_txtbox.Text = count.ToString();
            for (int i = 0; i < count; i++)
            {
                sum += int.Parse(dgv.Rows[i].Cells[1].Value.ToString());
            }
            sum_txtbox.Text = sum.ToString();
        }
        public bill_managementForm()
        {
            InitializeComponent();
            LoadListBill();
            findtotal();
            typecb.SelectedIndex = 0;
            sortcb.SelectedIndex = 0;
            timecb.SelectedIndex = 0;
            dgv.Columns[0].HeaderText = "Id";
            dgv.Columns[1].HeaderText = "Total money";
            dgv.Columns[2].HeaderText = "Total amount";
            dgv.Columns[3].HeaderText = "Date";
        }
        

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }




        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(selected_id_txtbox.Text))
            {
                MessageBox.Show("Please select a bill");
            }
            else
            {
                bill_detailForm frm = new bill_detailForm();
                frm.temp = selected_id_txtbox.Text;
                frm.ShowDialog();
            }
        }
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            int num = dgv.CurrentCell.RowIndex;
            selected_id_txtbox.Text = dgv.Rows[num].Cells[0].Value.ToString();
        }

        private void ID_Find_TextChanged(object sender, EventArgs e)
        {
            
        }
        public bool IsDigit(string s)
        {
            foreach (char c in s)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private void ID_Find_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(ID_Find.Text))
            {
                dgv.DataSource = billDAO.Instance.getListBill();
                findtotal();
                SaveList();
            }
            else if (IsDigit(ID_Find.Text))
            {
                int num = int.Parse(ID_Find.Text.ToString());
                dgv.DataSource = billDAO.Instance.getListBillById(num);
                findtotal();
                SaveList();
            }
            else MessageBox.Show("Please enter number only");
        }


        

        private void typecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            check = int.Parse(typecb.SelectedIndex.ToString());
            if (check == 1 )
            {
                label6.Text = "Year";
                dateTimePicker1.CustomFormat = "yyyy";
            }
            else if (check == 2 )
            {
                label6.Text = "Month";
                dateTimePicker1.CustomFormat = "MM/yyyy";
            }
            else
            {
                label6.Text = "Date";
                dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            }
        }

        private void bill_managementForm_Load(object sender, EventArgs e)
        {
            string check = UserInfo.Instance.Role;
            if (!(String.Equals(check,"admin")))
            {
                dateTimePicker1.Visible = false;
                typecb.Visible = false;
                sortcb.Visible = false;
                timecb.Visible = false;
                find_btn.Visible = false;
            }
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            if (typecb.SelectedIndex == 1)
            {
                timecb.Enabled = false;
                dgv.DataSource = billDAO.Instance.getListBillyy(dateTimePicker1.Value, typecb.SelectedIndex, timecb.SelectedIndex, sortcb.SelectedIndex);
                findtotal1();
                SaveList();
                dgv.Columns[0].HeaderText = "Month";
                dgv.Columns[1].HeaderText = "Total money";
                dgv.Columns[2].HeaderText = "Total amount";
            }
            else if (typecb.SelectedIndex == 2)
            {
                timecb.Enabled = false;
                dgv.DataSource = billDAO.Instance.getListBillmm(dateTimePicker1.Value, typecb.SelectedIndex, timecb.SelectedIndex, sortcb.SelectedIndex);
                findtotal1();
                SaveList();
                dgv.Columns[0].HeaderText = "Day";
                dgv.Columns[1].HeaderText = "Total money";
                dgv.Columns[2].HeaderText = "Total amount";
            }
            else if (typecb.SelectedIndex == 0)
            {
                timecb.Enabled = true;
                dgv.DataSource = billDAO.Instance.getListBill0(dateTimePicker1.Value, typecb.SelectedIndex, timecb.SelectedIndex, sortcb.SelectedIndex);
                findtotal();
                SaveList();
                dgv.Columns[0].HeaderText = "Id";
                dgv.Columns[1].HeaderText = "Total money";
                dgv.Columns[2].HeaderText = "Total amount";
                dgv.Columns[3].HeaderText = "Date";
            }
            else
            {
                timecb.Enabled = false;
                dgv.DataSource = billDAO.Instance.getListBill0(dateTimePicker1.Value, typecb.SelectedIndex, timecb.SelectedIndex, sortcb.SelectedIndex);
                findtotal();
                SaveList();
                dgv.Columns[0].HeaderText = "Id";
                dgv.Columns[1].HeaderText = "Total money";
                dgv.Columns[2].HeaderText = "Total amount";
                dgv.Columns[3].HeaderText = "Date";
            }
        }

        private void printTable_btn_Click(object sender, EventArgs e)
        {
            ListtoDataTableConverter converter = new ListtoDataTableConverter();

            DataTable data = converter.ToDataTable(billDAO.Instance.getListBill());

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
                        if ((data.Rows[i][j] is DateTime?))
                        {

                            workSheet.Cells[i + 2, j + 1] = (data.Rows[i][j]).ToString();
                        }
                        else
                        {
                            workSheet.Cells[i + 2, j + 1] = data.Rows[i][j];
                        }
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
    }
}
