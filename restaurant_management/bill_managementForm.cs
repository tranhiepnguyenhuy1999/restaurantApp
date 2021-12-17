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
        public bill_managementForm()
        {
            InitializeComponent();
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
        }
    }
}
