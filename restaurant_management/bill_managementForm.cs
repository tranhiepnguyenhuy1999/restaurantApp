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
        }
        public bill_managementForm()
        {
            InitializeComponent();
            LoadListBill();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = new int();
            id = int.Parse(ID_Find.Text);
            dgv.DataSource = billDAO.Instance.getListBillById(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Date_Find_Button_Click(object sender, EventArgs e)
        {
            int day, month, year = new int();
            day = int.Parse(Day_Find.Text);
            month = int.Parse(Month_Find.Text);
            year = int.Parse(Year_Find.Text);
            DateTime date = new DateTime(year,month,day);
            dgv.DataSource = billDAO.Instance.getListBillByDate(date);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bill_detailForm frm = new bill_detailForm();
            frm.Sender(ID_Find.Text);
            frm.ShowDialog();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            int num = dgv.CurrentCell.RowIndex;
            ID_Find.Text = dgv.Rows[num].Cells[0].Value.ToString();
        }
    }
}
