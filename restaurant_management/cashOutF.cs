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

        private void printBillBtn_Click(object sender, EventArgs e)
        {
            float tong_tien = 0, x;
            int so_luong = 0, y, g;
            string ten;
            if (billDetailsDataGridView.RowCount >= 1)
            {
                for (int i = 0; i <= billDetailsDataGridView.RowCount - 1; i++)
                {
                    y = Int32.Parse(billDetailsDataGridView.Rows[i].Cells[1].Value.ToString());
                    so_luong += Int32.Parse(billDetailsDataGridView.Rows[i].Cells[1].Value.ToString());
                    tong_tien += y * float.Parse(billDetailsDataGridView.Rows[i].Cells[2].Value.ToString());
                }
                DateTime createday = DateTime.Now;
                int id = billDAO.Instance.insertNewBill(so_luong, tong_tien, createday);
                for (int i = 0; i <= billDetailsDataGridView.RowCount - 1; i++)
                {
                    ten = billDetailsDataGridView.Rows[i].Cells[0].Value.ToString();
                    y = Int32.Parse(billDetailsDataGridView.Rows[i].Cells[1].Value.ToString());
                    x = float.Parse(billDetailsDataGridView.Rows[i].Cells[2].Value.ToString());
                    _ = billDAO.Instance.insertDetailBillofBill(id, y, ten, x);
                }
                MessageBox.Show("Cập nhập thành công !");
            }
        }

        private void deleteBillBtn_Click(object sender, EventArgs e)
        {
            billDetailsDataGridView.Rows.Clear();
            billDetailsDataGridView.Refresh();
        }
    }
}