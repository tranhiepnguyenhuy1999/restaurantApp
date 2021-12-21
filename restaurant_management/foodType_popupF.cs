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
    public partial class foodType_popupF : Form
    {
        private int selectedRow = -1;
        public foodType_popupF(List<DTO.Kind> TypeList)
        {
            InitializeComponent();
            typesDataGridView.DataSource = TypeList;
        }

        private void foodType_popupF_Load(object sender, EventArgs e)
        {
            typesDataGridView.Columns[0].HeaderText = Constants.TypeDataGridViewHeaders.iD;
            typesDataGridView.Columns[1].HeaderText = Constants.TypeDataGridViewHeaders.kind_name;
            typesDataGridView.Columns[2].HeaderText = Constants.TypeDataGridViewHeaders.from_age;
            typesDataGridView.Columns[3].HeaderText = Constants.TypeDataGridViewHeaders.to_age;
            typesDataGridView.Columns[4].HeaderText = Constants.TypeDataGridViewHeaders.create_date;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTextBox.Text) || !FoodValidationHelper.isAgeRangeValid(fromAgeNumericUpDown.Value, toAgeNumericUpDown.Value))
            {
                MessageBox.Show("Please fill all with valid data.");
                return;
            }

            int idCount = typesDataGridView.Rows.Count;
            DAO.kindDAO.Instance.insertKind(
                idCount + 1, 
                nameTextBox.Text, 
                int.Parse(fromAgeNumericUpDown.Value.ToString()), 
                int.Parse(toAgeNumericUpDown.Value.ToString()),
                DateTime.Now
            );
            typesDataGridView.DataSource = DAO.kindDAO.Instance.getListKind();
        }

        private void foodType_popupF_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTextBox.Text) || !FoodValidationHelper.isAgeRangeValid(fromAgeNumericUpDown.Value, toAgeNumericUpDown.Value))
            {
                MessageBox.Show("Please fill all with valid data.");
                return;
            }

            //kindDAO.Instance.updateProps(
            //    int.Parse(typesDataGridView.Rows[selectedRow].Cells[0].Value.ToString()),
            //    nameTextBox.Text,
            //    fromAgeNumericUpDown.Value,
            //    toAgeNumericUpDown.Value
            //);

            typesDataGridView.Rows[selectedRow].Cells[1].Value = nameTextBox.Text;
            typesDataGridView.Rows[selectedRow].Cells[2].Value = fromAgeNumericUpDown.Value;
            typesDataGridView.Rows[selectedRow].Cells[3].Value = toAgeNumericUpDown.Value;
        }

        private void typesDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            nameTextBox.Text = typesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            fromAgeNumericUpDown.Value = int.Parse(typesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            toAgeNumericUpDown.Value = int.Parse(typesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //kindDAO.Instance.deleteKind(int.Parse(typesDataGridView.Rows[selectedRow].Cells[0].Value.ToString());

            typesDataGridView.DataSource = kindDAO.Instance.getListKind();
        }
    }
}
