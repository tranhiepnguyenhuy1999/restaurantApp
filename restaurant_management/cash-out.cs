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
    public partial class cashOutForm : Form
    {
        public cashOutForm()
        {
            InitializeComponent();
        }
        private void cashOutForm_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            billDetailsDataGridView.ColumnCount = 3;

            billDetailsDataGridView.Columns[0].Name = "Name";
            billDetailsDataGridView.Columns[1].Name = "Price";
            billDetailsDataGridView.Columns[2].Name = "Quantity";
        }

        private void PopulateDataGridView()
        {
            billDetailsDataGridView.Rows.Clear();
            string[] row0 = { "Beef Noodles", "30000", "2" };
            string[] row1 = { "Tea", "5000", "2" };

            billDetailsDataGridView.Rows.Add(row0);
            billDetailsDataGridView.Rows.Add(row1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameValueLabel.Text = button1.Text;
            totalPriceValueLabel.Text = "70000";
            
            PopulateDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameValueLabel.Text = button2.Text;
            totalPriceValueLabel.Text = "70000";
            
            PopulateDataGridView();
        }

        private void billDetailsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
