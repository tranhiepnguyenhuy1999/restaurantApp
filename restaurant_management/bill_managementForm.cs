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

namespace restaurant_management
{
    public partial class bill_managementForm : Form
    {
        int check;
        bool check_date = false;
        int month = DateTime.Today.Month;
        void LoadListBill()
        {
            dgv.DataSource = billDAO.Instance.getListBillByMonth(month, 0);
        }
        void findtotal()
        {
            int count = dgv.Rows.Count;
            long sum = 0;
            bill_count_txtbox.Text = count.ToString();
            for (int i =0;i<count-1;i++)
            {
                sum += int.Parse(dgv.Rows[i].Cells[1].Value.ToString());
            }
            sum_txtbox.Text = sum.ToString();
        }
        void date_check()
        {
            if (check_date)
            {
                comboBox3.Visible = false;
                label9.Visible = false;
                dateTimePicker1.Visible = true;
                label6.Visible = true;
            }
            else
            {
                comboBox3.Visible = true;
                label9.Visible = true;
                dateTimePicker1.Visible = false;
                label6.Visible = false;
            }
        }
        public bill_managementForm()
        {
            InitializeComponent();
            date_check();
            LoadListBill();
            findtotal();
            dateTimePicker1.Value = DateTime.Today;
            comboBox1.Items.Add("Latest");
            comboBox1.Items.Add("Highest Amount");
            comboBox1.Items.Add("Lowest Amount");
            comboBox2.SelectedIndex = 2;
            comboBox1.SelectedIndex = 0;
            comboBox3.SelectedIndex = comboBox3.FindString(month.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }



        private void Date_Find_Button_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                check = 5;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                check = 4;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                check = 3;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    dgv.DataSource = billDAO.Instance.getListBillByDate(dateTimePicker1.Value,0);
                    break;
                case 1:
                    int year = dateTimePicker1.Value.Year;
                    dgv.DataSource = billDAO.Instance.getListBillByYear(year,check);
                    break;
                case 2:
                    int month = dateTimePicker1.Value.Month;
                    dgv.DataSource = billDAO.Instance.getListBillByMonth(month, check);
                    break;
            }
            findtotal();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0: 
                    Date_Find_Button.Text = "Find by Date";
                    check_date = true;
                    break;
                case 1:
                    Date_Find_Button.Text = "Find by Year";
                    check_date = true;
                    break;
                case 2:
                    Date_Find_Button.Text = "Find by Month";
                    check_date = false;
                    break;
            }
            date_check();
            findtotal();
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
            }
            else if (IsDigit(ID_Find.Text))
            {
                int num = int.Parse(ID_Find.Text.ToString());
                dgv.DataSource = billDAO.Instance.getListBillById(num);
                findtotal();
            }
            else MessageBox.Show("Please enter number only");
        }
    }
}
