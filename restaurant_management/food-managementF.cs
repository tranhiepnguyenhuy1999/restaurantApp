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
            foodsDataGridView.ColumnCount = 2;

            foodsDataGridView.Columns[0].Name = "Name";
            foodsDataGridView.Columns[1].Name = "Price";
        }

        private void PopulateDataGridView()
        {
            string[] row0 = { "Beef Noodles", "30000" };
            string[] row1 = { "Tea", "5000" };

            foodsDataGridView.Rows.Add(row0);
            foodsDataGridView.Rows.Add(row1);
        }

        private void foodsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idTextBox.Text = e.RowIndex.ToString();
            nameTextBox.Text = foodsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            priceTextBox.Text = foodsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
