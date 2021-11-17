using restaurant_management.Constants;
using restaurant_management.DAO;
using restaurant_management.Helpers;
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
        public List<DTO.Food> Foods = new List<DTO.Food>();
        public List<DTO.Kind> TypeList = new List<DTO.Kind>();
        public List<int> TypeIdList = new List<int>();
        public List<string> TypeNameList = new List<string>();
        private int selectedRow = -1;

        public foodManagementF()
        {
            InitializeComponent();
        }

        private void foodManagementF_Load(object sender, EventArgs e)
        {
            LoadData();
            SetupDataGridView();
        }

        private void LoadData()
        {
            Foods = foodDAO.Instance.getListFood();
            TypeList = kindDAO.Instance.getListKind();
            foreach (var type in TypeList)
            {
                TypeIdList.Add(type.ID);
                TypeNameList.Add(type.Kind_name);
            }
            typeComboBox.DataSource = TypeNameList;
            List<Models.FoodModel> foods = new List<Models.FoodModel>();
            foreach (DTO.Food food in Foods)
            {
                var idIndex = TypeIdList.FindIndex(id => id == food.Id_kind);
                foods.Add(new Models.FoodModel(food.ID, food.Food_name, food.Price, TypeNameList[idIndex], food.Create_date));
            }
            foodsDataGridView.DataSource = foods;
        }

        private void SetupDataGridView()
        {
            foodsDataGridView.Columns[0].HeaderText = FoodDataGridViewHeaders.iD;
            foodsDataGridView.Columns[1].HeaderText = FoodDataGridViewHeaders.food_name;
            foodsDataGridView.Columns[2].HeaderText = FoodDataGridViewHeaders.price;
            foodsDataGridView.Columns[3].HeaderText = FoodDataGridViewHeaders.id_kind;
            foodsDataGridView.Columns[4].HeaderText = FoodDataGridViewHeaders.create_date;
        }

        private void foodsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            nameTextBox.Text = foodsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceTextBox.Text = foodsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            typeComboBox.Text = foodsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foodAddingForm form = new foodAddingForm(TypeIdList, TypeNameList);
            form.FormClosed += new FormClosedEventHandler(addingForm_FormClosed);
            form.Show();
        }

        void addingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!FoodValidationHelper.isFoodValid(
                nameTextBox.Text,
                priceTextBox.Text,
                typeComboBox.SelectedIndex.ToString()
            ))
            {
                MessageBox.Show("Please fill all data.");
                return;
            }

            foodDAO.Instance.updateProps(
                int.Parse(foodsDataGridView.Rows[selectedRow].Cells[0].Value.ToString()),
                nameTextBox.Text,
                float.Parse(priceTextBox.Text),
                TypeIdList[typeComboBox.SelectedIndex]
            );

            foodsDataGridView.Rows[selectedRow].Cells[1].Value = nameTextBox.Text;
            foodsDataGridView.Rows[selectedRow].Cells[2].Value = float.Parse(priceTextBox.Text);
            foodsDataGridView.Rows[selectedRow].Cells[3].Value = typeComboBox.Text;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foodDAO.Instance.deleteFood(int.Parse(foodsDataGridView.Rows[selectedRow].Cells[0].Value.ToString()));

            LoadData();
        }

        private void typePopupLabel_Click(object sender, EventArgs e)
        {
            foodType_popupF form = new foodType_popupF(TypeList);
            form.FormClosed += new FormClosedEventHandler(foodType_popupF_FormClosed);
            form.Show();
        }

        void foodType_popupF_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }
    }
}
