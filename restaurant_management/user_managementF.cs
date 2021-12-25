using System;
using restaurant_management.DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace restaurant_management
{ 
    public partial class user_managementF : Form
    {
        void LoadListUser()
        {
            string id = UserInfo.Instance.ID.ToString();
            dgv_user.DataSource = userDAO.Instance.getUserList();
        }
        public user_managementF()
        {
            InitializeComponent();
            LoadListUser();
            dgv_user.Columns[0].Visible = false;
            dgv_user.Columns[4].Visible = false;
            dgv_user.Columns[5].Visible = false;
            dgv_user.Columns[6].Visible = false;
            dgv_user.Columns[7].Visible = false;
            dgv_user.Columns[8].Visible = false;
            dgv_user.Columns[9].Visible = false;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void dgv_user_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void update_btn_Click_1(object sender, EventArgs e)
        {
            int num = dgv_user.CurrentCell.RowIndex;
            if ( ((pass_txtbox.Enabled == true) && (String.IsNullOrEmpty(pass_txtbox.Text))) || String.IsNullOrEmpty(firstname_txtbox.Text) || String.IsNullOrEmpty(lastname_txtbox.Text) || String.IsNullOrEmpty(phone_txtbox.Text))
            {
                MessageBox.Show("Thông tin không được để trống");
            }
            else if (dateTimePicker1.Value > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
            }
            else if (isValid(phone_txtbox.Text))
            {
                string gender = cbo_gender.SelectedItem.ToString();
                int g;
                if (gender == "Nữ")
                    g = 1;
                else
                    g = 0;
                DateTime birthday = Convert.ToDateTime(dateTimePicker1.Value);
                int id = userDAO.Instance.getidbyname(user_txtbox.Text);
                bool s=userDAO.Instance.updateUser(id, firstname_txtbox.Text, lastname_txtbox.Text, phone_txtbox.Text, birthday, user_txtbox.Text, pass_txtbox.Text, g,rolecbo.SelectedItem.ToString());
                //userDAO.Instance.updateUser(int.Parse(dgv_user.Rows[num].Cells[0].Value.ToString()), firstname_txtbox.Text, lastname_txtbox.Text, phone_txtbox.Text, birthday, user_txtbox.Text, pass_txtbox.Text,g);
                dgv_user.Rows[num].Cells[1].Value = firstname_txtbox.Text;
                dgv_user.Rows[num].Cells[2].Value = lastname_txtbox.Text;
                dgv_user.Rows[num].Cells[3].Value = phone_txtbox.Text;
                dgv_user.Rows[num].Cells[5].Value = birthday.Date.ToString("dd/MM/yyyy");
                dgv_user.Rows[num].Cells[7].Value = user_txtbox.Text;
                dgv_user.Rows[num].Cells[8].Value = pass_txtbox.Text;
                dgv_user.Rows[num].Cells[10].Value = rolecbo.SelectedItem.ToString();
                LoadListUser();
                MessageBox.Show("Cập nhập thành công !");
            }
            else MessageBox.Show("SĐT không hợp lệ");
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            add_user frm = new add_user();
            frm.ShowDialog();
            LoadListUser();
        }
        public bool isValid(string s)
        {
            if (s[0] == '0' && s.Length == 10 && IsDigit(s))
                return true;
            return false;
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

        private void user_managementF_Load(object sender, EventArgs e)
        {
            if (UserInfo.Instance.Role == "admin")
            {
                rolecbo.Items.Add("admin");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string name = user_txtbox.Text;
            userDAO.Instance.deleteUser(name);
            MessageBox.Show("Xoá user thành công !");
            LoadListUser();
        }

        private void dgv_user_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.Value != null )
            {
                e.Value = new string ('*',e.Value.ToString().Length);
            }
        }

        private void pass_change_btn_Click(object sender, EventArgs e)
        {
            if (pass_txtbox.Enabled == false)
            {
                pass_txtbox.Enabled = true;
            }
            else pass_txtbox.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(searchTextBox.Text == null) dgv_user.DataSource = userDAO.Instance.getUserList();
            else dgv_user.DataSource = userDAO.Instance.getUserList(searchTextBox.Text);
        }

        private void printTable_btn_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)(dgv_user.DataSource);

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

        private void dgv_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else
            {
                int num = dgv_user.CurrentCell.RowIndex;
                string role = dgv_user.Rows[num].Cells[10].Value.ToString();
                DateTime date = Convert.ToDateTime(dgv_user.Rows[num].Cells[5].Value.ToString());
                firstname_txtbox.Text = dgv_user.Rows[num].Cells[1].Value.ToString();
                lastname_txtbox.Text = dgv_user.Rows[num].Cells[2].Value.ToString();
                phone_txtbox.Text = dgv_user.Rows[num].Cells[3].Value.ToString();
                dateTimePicker1.Value = date.Date;
                if (int.Parse(dgv_user.Rows[num].Cells[6].Value.ToString()) == 0) cbo_gender.SelectedIndex = 0;
                else cbo_gender.SelectedIndex = 1;
                user_txtbox.Text = dgv_user.Rows[num].Cells[7].Value.ToString();
                pass_txtbox.Text = "";
                rolecbo.SelectedIndex = rolecbo.FindString(role);
                if ((rolecbo.SelectedItem.ToString() == UserInfo.Instance.Role) && !(UserInfo.Instance.Role == "admin") && (user_txtbox.Text != UserInfo.Instance.Username))
                {
                    pass_change_btn.Enabled = false;
                    firstname_txtbox.ReadOnly = true;
                    lastname_txtbox.ReadOnly = true;
                    phone_txtbox.ReadOnly = true;
                    dateTimePicker1.Enabled = false;
                    cbo_gender.Enabled = false;
                    rolecbo.Enabled = false;
                }
                else
                {
                    pass_change_btn.Enabled = true;
                    firstname_txtbox.ReadOnly = false;
                    lastname_txtbox.ReadOnly = false;
                    phone_txtbox.ReadOnly = false;
                    dateTimePicker1.Enabled = true;
                    cbo_gender.Enabled = true;
                    rolecbo.Enabled = true;
                }
            }
        }
    }
}
