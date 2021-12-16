using restaurant_management.Constants;
using restaurant_management.DAO;
using restaurant_management.Models;
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
        private List<TableModel> Tables;
        private List<DTO.Food> Foods = new List<DTO.Food>();
        private List<int> FoodIdList = new List<int>();
        private List<string> FoodNameList = new List<string>();
        public cashOutF(List<TableModel> tables)
        {
            InitializeComponent();
            Tables = tables;
        }
        private void cashOutF_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SetupDataGridView()
        {
            billDetailsDataGridView.Columns[0].HeaderText = BillDataGridViewHeaders.name;
            billDetailsDataGridView.Columns[1].HeaderText = BillDataGridViewHeaders.amount;
            billDetailsDataGridView.Columns[2].HeaderText = BillDataGridViewHeaders.price;
        }

        private List<Button> PrepareTables()
        {
            List<Button> tableButtons = new List<Button>();
            foreach(var table in Tables)
            {
                if (Tables.IndexOf(table) == 0) continue;

                Button button = new Button();
                button.Size = new Size(100, 100);
                button.BackColor = table.Status ? Color.Red : Color.Green;
                button.Text = table.Name;
                button.Tag = Tables.IndexOf(table);
                button.Click += button_Click;

                tableButtons.Add(button);
            }

            return tableButtons;
        }

        private void LoadData()
        {
            tablesFlowLayoutPanel.Controls.AddRange(PrepareTables().ToArray());

            Foods = foodDAO.Instance.getListFood();
            foreach (var food in Foods)
            {
                FoodIdList.Add(food.ID);
                FoodNameList.Add(food.Food_name);
            }
            foodsComboBox.DataSource = FoodNameList;
        }

        private void button_Click(object sender, EventArgs e)
        {
            var tableIndex = int.Parse((sender as Button).Tag.ToString());
            nameValueLabel.Text = (sender as Button).Text;
            nameValueLabel.Tag = (sender as Button).Tag;
            totalPriceValueLabel.Text = Tables[tableIndex].TotalPrice.ToString();
            billDetailsDataGridView.DataSource = Tables[tableIndex].Bill.GetBillDetailsList();
            totalPriceValueLabel.Text = Tables[tableIndex].TotalPrice.ToString();
            SetupDataGridView();
        }

        private void nameValueLabel_TextChanged(object sender, EventArgs e)
        {
            if (nameValueLabel.Text == "unknown") return;

            billDetailsDataGridView.Enabled = true;
            foodsComboBox.Enabled = true;
            quantityNumericUpDown.Enabled = true;
            addBtn.Enabled = true;
            deleteBillBtn.Enabled = true;
            printBillBtn.Enabled = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var tableIndex = int.Parse(nameValueLabel.Tag.ToString());
            var index = Tables[tableIndex].Bill.FoodList
                .FindIndex(food => food.ID == FoodIdList[foodsComboBox.SelectedIndex]);

            if (index != -1)
            {
                Tables[tableIndex].Bill.AmountList[index] += int.Parse(quantityNumericUpDown.Value.ToString());
            } 
            else
            {
                var food = Foods.Find(f => f.ID == FoodIdList[foodsComboBox.SelectedIndex]);
                Tables[tableIndex].Bill.FoodList.Add
                (
                    new FoodModel(food.ID, food.Food_name, food.Price, "unknown", food.Create_date)
                );
                Tables[tableIndex].Bill.AmountList.Add(int.Parse(quantityNumericUpDown.Value.ToString()));
            }
            Tables[tableIndex].SetTotalPrice();

            billDetailsDataGridView.DataSource = Tables[tableIndex].Bill.GetBillDetailsList();
            totalPriceValueLabel.Text = Tables[tableIndex].TotalPrice.ToString();

            //change tables status
            if (Tables[tableIndex].Status == true) return;
            Tables[tableIndex].Status = true;
            tablesFlowLayoutPanel.Controls.Clear();
            tablesFlowLayoutPanel.Controls.AddRange(PrepareTables().ToArray());
        }
        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex == 0)
            {
                tablesFlowLayoutPanel.Enabled = true;
                billDetailsDataGridView.Enabled = false;
                foodsComboBox.Enabled = false;
                quantityNumericUpDown.Enabled = false;
                addBtn.Enabled = false;
                deleteBillBtn.Enabled = false;
                printBillBtn.Enabled = false;

                nameValueLabel.Text = "unknown";
                totalPriceValueLabel.Text = "0";
            } 
            else
            {
                tablesFlowLayoutPanel.Enabled = false;
                nameValueLabel.Text = Tables[0].Name;
                nameValueLabel.Tag = 0;
                billDetailsDataGridView.DataSource = Tables[0].Bill.GetBillDetailsList();
                totalPriceValueLabel.Text = Tables[0].TotalPrice.ToString();
                SetupDataGridView();
            }
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
                    tong_tien += float.Parse(billDetailsDataGridView.Rows[i].Cells[2].Value.ToString());
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

            //change tables status
            var tableIndex = int.Parse(nameValueLabel.Tag.ToString());
            if (Tables[tableIndex].Status == false) return;
            Tables[tableIndex].Status = false;
            tablesFlowLayoutPanel.Controls.Clear();
            tablesFlowLayoutPanel.Controls.AddRange(PrepareTables().ToArray());
        }

        private void deleteBillBtn_Click(object sender, EventArgs e)
        {
            var tableIndex = int.Parse(nameValueLabel.Tag.ToString());
            Tables[tableIndex].Bill = new BillModel(Tables[tableIndex].Bill.ID);
            Tables[tableIndex].SetTotalPrice();
            totalPriceValueLabel.Text = Tables[tableIndex].TotalPrice.ToString();
            billDetailsDataGridView.DataSource = Tables[tableIndex].Bill.GetBillDetailsList();
            totalPriceValueLabel.Text = Tables[tableIndex].TotalPrice.ToString();

            //change tables status
            if (Tables[tableIndex].Status == false) return;
            Tables[tableIndex].Status = false;
            tablesFlowLayoutPanel.Controls.Clear();
            tablesFlowLayoutPanel.Controls.AddRange(PrepareTables().ToArray());
        }
    }
}