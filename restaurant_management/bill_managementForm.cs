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
        void LoadListBill()
        {
            dgv.DataSource = billDAO.Instance.getListBill();
            dateTimePicker1.Value = DateTime.Today;
        }
        void findtotal()
        {
            int count = dgv.Rows.Count-1;
            long sum = 0;
            bill_count_txtbox.Text = count.ToString();
            for (int i =0;i<count;i++)
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
            comboBox1.Items.Add("Latest");
            comboBox1.Items.Add("Highest Amount");
            comboBox1.Items.Add("Lowest Amount");
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }



        private void Date_Find_Button_Click(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    dgv.DataSource = billDAO.Instance.getListBillByDate(dateTimePicker1.Value);
                    break;
                case 1:
                    int year = dateTimePicker1.Value.Year;
                    dgv.DataSource = billDAO.Instance.getListBillByYear(year, 0);
                    break;
                case 2:
                    int month = dateTimePicker1.Value.Month;
                    dgv.DataSource = billDAO.Instance.getListBillByMonth(month, 0);
                    break;
                case 3:
                    int day = dateTimePicker1.Value.Day;
                    dgv.DataSource = billDAO.Instance.getListBillByDay(day, 0);
                    break;
            }
            findtotal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bill_detailForm frm = new bill_detailForm();
            if (selected_id_txtbox.Text == "")
            {
                MessageBox.Show("Please select a bill");
            }
            else
            {
                frm.Sender(selected_id_txtbox.Text);
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
                    break;
                case 1:
                    Date_Find_Button.Text = "Find by Year";
                    break;
                case 2:
                    Date_Find_Button.Text = "Find by Month";
                    break;
                case 3:
                    Date_Find_Button.Text = "Find by Day";
                    break;
            }
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
            if (ID_Find.Text == "")
            {
                dgv.DataSource = billDAO.Instance.getListBill();
            }
            if (IsDigit(ID_Find.Text))
            {
                int num = int.Parse(ID_Find.Text.ToString());
                dgv.DataSource = billDAO.Instance.getListBillById(num);
                findtotal();
            }
            else MessageBox.Show("Please enter number only");
        }
    }
}
