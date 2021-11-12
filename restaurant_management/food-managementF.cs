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
        DAO.kindDAO testkind = DAO.kindDAO.Instance;

        public foodManagementF()
        {
            InitializeComponent();
        }

        private void foodManagementF_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            PopulateDataGridView();
        }

        private void SetupDataGridView()
        {
        }

        private void PopulateDataGridView()
        {
            foodsDataGridView.DataSource = foodDAO.Instance.getListFood();
        }

        private void foodsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idTextBox.Text = e.RowIndex.ToString();
            nameTextBox.Text = foodsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            priceTextBox.Text = foodsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void cashOutBtn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
