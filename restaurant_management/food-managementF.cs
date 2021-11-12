using restaurant_management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_management
{
    public partial class foodManagementF : Form
    {


        public int[] foodTypes = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public foodManagementF()
        {
            InitializeComponent();
        }

        private void foodManagementF_Load(object sender, EventArgs e)
        {
            SetupData();
            PopulateDataGridView();
        }

        private void SetupData()
        {
            typeComboBox.DataSource = foodTypes;
        }

        private void PopulateDataGridView()
        {
            foodsDataGridView.DataSource = foodDAO.Instance.getListFood();
        }

        private void foodsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            nameTextBox.Text = foodsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceTextBox.Text = foodsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            typeComboBox.Text = foodsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foodAddingForm form = new foodAddingForm(foodTypes);
            form.FormClosed += new FormClosedEventHandler(addingForm_FormClosed);
            form.Show();
        }

        void addingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foodsDataGridView.DataSource = foodDAO.Instance.getListFood();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            foodDAO.Instance.insertNewFood("a", 1.2f, 1);
        }

        private void cashOutBtn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
