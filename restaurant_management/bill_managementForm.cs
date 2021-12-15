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
        bool check_date = true;
        bool check_year = false;
        int month = DateTime.Today.Month;
        int year = DateTime.Today.Year;
        void LoadListBill()
        {

            dgv.DataSource = billDAO.Instance.getListBill0(dateTimePicker1.Value,0,0,0);
            dateTimePicker1.Value = DateTime.Today;

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
        void date_check()
        {
            if (check_date)
            {
                comboBox3.Visible = false;
                label9.Visible = false;
                comboBox4.Visible = false;
                label10.Visible = false;
                comboBox5.Visible = false;
                label11.Visible = false;
                dateTimePicker1.Visible = true;
                label6.Visible = true;
            }
            else if (check_year)
            {
                comboBox3.Visible = false;
                label9.Visible = false;
                dateTimePicker1.Visible = false;
                label6.Visible = false;
                comboBox4.Visible = false;
                label10.Visible = false;
                label11.Visible = true;
                comboBox5.Visible = true;
            }
            else
            {
                comboBox3.Visible = true;
                label9.Visible = true;
                dateTimePicker1.Visible = false;
                label6.Visible = false;
                comboBox4.Visible = true;
                label10.Visible = true;
                label11.Visible = false;
                comboBox5.Visible = false;
            }
        }
        public bill_managementForm()
        {
            InitializeComponent();
            date_check();
            LoadListBill();
            findtotal();
            typecb.SelectedIndex = 0;
            sortcb.SelectedIndex = 0;
            timecb.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }



        private void Date_Find_Button_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*switch (typecb.SelectedIndex)
            {
                case 0: 
                    dgv.DataSource = billDAO.Instance.getListBill0(dateTimePicker1.Value, 0, 0, 0);
                    break;
                case 1:
                    dgv.DataSource = billDAO.Instance.getListBill0(dateTimePicker1.Value, 1, 1, 0);
                    break;
                case 2:
                    dgv.DataSource = billDAO.Instance.getListBill0(dateTimePicker1.Value, 2, 1, 0);
                    break;
                case 3:
                    dgv.DataSource = billDAO.Instance.getListBill0(dateTimePicker1.Value, 3, 1, 0);
                    break;
                case 4:
                    dgv.DataSource = billDAO.Instance.getListBill0(dateTimePicker1.Value, 4, 0, 2);
                    break;
            }
            findtotal();*/
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
        private void label10_Click(object sender, EventArgs e)
        {
            dgv.DataSource = billDAO.Instance.getListBill0(dateTimePicker1.Value, typecb.SelectedIndex, timecb.SelectedIndex, sortcb.SelectedIndex);
            findtotal();
        }
    }
}
