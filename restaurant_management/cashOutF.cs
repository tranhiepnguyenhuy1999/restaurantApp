﻿using restaurant_management.Constants;
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

        private void LoadData()
        {
            button1.Text = Tables[0].Name;
            button1.Tag = 0;
            button2.Text = Tables[1].Name;
            button2.Tag = 1;

            Foods = foodDAO.Instance.getListFood();
            foreach (var food in Foods)
            {
                FoodIdList.Add(food.ID);
                FoodNameList.Add(food.Food_name);
            }
            foodsComboBox.DataSource = FoodNameList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameValueLabel.Text = button1.Text;
            nameValueLabel.Tag = button1.Tag;
            totalPriceValueLabel.Text = Tables[0].TotalPrice.ToString();
            billDetailsDataGridView.DataSource = Tables[0].Bill.GetBillDetailsList();
            totalPriceValueLabel.Text = Tables[0].TotalPrice.ToString();
            SetupDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameValueLabel.Text = button2.Text;
            nameValueLabel.Tag = button2.Tag;
            totalPriceValueLabel.Text = Tables[1].TotalPrice.ToString();
            billDetailsDataGridView.DataSource = Tables[1].Bill.GetBillDetailsList();
            totalPriceValueLabel.Text = Tables[1].TotalPrice.ToString();
            SetupDataGridView();
        }

        private void nameValueLabel_TextChanged(object sender, EventArgs e)
        {
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
        }
    }
}
