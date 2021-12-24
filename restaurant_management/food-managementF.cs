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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace restaurant_management
{
    public partial class foodManagementF : Form
    {
        public List<DTO.Food> Foods = new List<DTO.Food>();
        public List<DTO.Kind> TypeList = new List<DTO.Kind>();
        public List<int> TypeIdList = new List<int>();
        public List<string> TypeNameList = new List<string>();
        private int selectedRow = -1;
        private string searchName = "";

        public foodManagementF()
        {
            InitializeComponent();
        }

        private void foodManagementF_Load(object sender, EventArgs e)
        {
            LoadData();
            SetupDataGridView();
        }

        private void LoadData(string name = "")
        {
            Foods = foodDAO.Instance.getListFood(name);
            TypeList = kindDAO.Instance.getListKind();
            TypeIdList = new List<int>();
            TypeNameList = new List<string>();
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
                MessageBox.Show("Please fill all with valid data.");
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

        void foodType_popupF_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void manageTypeBtn_Click(object sender, EventArgs e)
        {
            foodType_popupF form = new foodType_popupF(TypeList);
            form.FormClosed += new FormClosedEventHandler(foodType_popupF_FormClosed);
            form.Show();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchName = searchTextBox.Text.ToLower().Trim();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadData(searchName);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            ListtoDataTableConverter converter = new ListtoDataTableConverter();

            DataTable data = converter.ToDataTable(Foods);

            try
            {
                if (data == null || data.Columns.Count == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                var excelApp = new Excel.Application();
                excelApp.Workbooks.Add();

                // single worksheet
                Excel._Worksheet workSheet = excelApp.ActiveSheet;

                // column headings
                for (var i = 0; i < data.Columns.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = data.Columns[i].ColumnName;
                }

                // rows
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (var j = 0; j < data.Columns.Count; j++)
                    {
                        if ((data.Rows[i][j] is DateTime?))
                        {

                            workSheet.Cells[i + 2, j + 1] = (data.Rows[i][j]).ToString();
                        }
                        else
                        {
                            workSheet.Cells[i + 2, j + 1] = data.Rows[i][j];
                        }
                    }
                }

                // check file path
                if (!string.IsNullOrEmpty(""))
                {
                    try
                    {
                        workSheet.SaveAs("excelFilePath");
                        excelApp.Quit();
                        MessageBox.Show("Excel file saved!");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                            + ex.Message);
                    }
                }
                else
                { // no file path is given
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
