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
    public partial class cashOutF : Form
    {
        public cashOutF()
        {
            InitializeComponent();
        }
        private void cashOutF_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
        }

        private void PopulateDataGridView(int id)
        {
            billDetailsDataGridView.DataSource = detailBillDAO.Instance.getListBillById(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameValueLabel.Text = button1.Text;
            totalPriceValueLabel.Text = "70000";

            PopulateDataGridView(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameValueLabel.Text = button2.Text;
            totalPriceValueLabel.Text = "70000";

            PopulateDataGridView(2);
        }
    }
}
