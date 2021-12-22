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
    public partial class foodAddingForm : Form
    {
        public List<int> _TypeIdList = new List<int>();
        public foodAddingForm(List<int> TypeIdList, List<string> TypeNameList)
        {
            InitializeComponent();
            _TypeIdList = TypeIdList;
            typeComboBox.DataSource = TypeNameList;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!FoodValidationHelper.isFoodValid(
                nameTextBox.Text,
                priceTextBox.Text,
                typeComboBox.SelectedItem.ToString()
            ))
            {
                MessageBox.Show("Please fill all with valid data.");
                return;
            }

            foodDAO.Instance.insertNewFood(nameTextBox.Text, float.Parse(priceTextBox.Text), _TypeIdList[typeComboBox.SelectedIndex]);
            Close();
        }

        private void foodAddingForm_FormClosed(object sender, FormClosedEventArgs e)
        {

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
