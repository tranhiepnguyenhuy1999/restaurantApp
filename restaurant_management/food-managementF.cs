using restaurant_management.Constants;
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
        public List<DTO.Kind> TypeList = kindDAO.Instance.getListKind();
        public List<int> TypeIdList = new List<int>();

        public foodManagementF()
        {
            InitializeComponent();
        }

        private void foodManagementF_Load(object sender, EventArgs e)
        {
            SetupData();
            SetupDataGridView();
        }

        private void SetupData()
        {
            foodsDataGridView.DataSource = foodDAO.Instance.getListFood();

            var TypeNameList = new List<string>();
            foreach (var type in TypeList)
            {
                TypeIdList.Add(type.ID);
                TypeNameList.Add(type.Kind_name);
            }
            typeComboBox.DataSource = TypeNameList;
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
            nameTextBox.Text = foodsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceTextBox.Text = foodsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            typeComboBox.SelectedIndex = int.Parse(foodsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString()) - 1;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foodAddingForm form = new foodAddingForm(TypeList);
            form.FormClosed += new FormClosedEventHandler(addingForm_FormClosed);
            form.Show();
        }

        void addingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foodsDataGridView.DataSource = foodDAO.Instance.getListFood();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            foodDAO.Instance.insertNewFood("a", 100000, 1);
        }
    }
}
