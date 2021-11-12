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
    public partial class foodAddingForm : Form
    {
        public foodAddingForm(List<DTO.Kind> foodTypes)
        {
            InitializeComponent();
            typeComboBox.DataSource = foodTypes;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTextBox.Text) ||
                String.IsNullOrEmpty(priceTextBox.Text) ||
                String.IsNullOrEmpty(typeComboBox.SelectedItem.ToString()) ||
                !IsFloatOrInt(priceTextBox.Text))
            {
                MessageBox.Show("Please fill all data.");
                return;
            }

            foodDAO.Instance.insertNewFood(nameTextBox.Text, float.Parse(priceTextBox.Text), int.Parse(typeComboBox.SelectedItem.ToString()));
            Close();
        }

        public bool IsFloatOrInt(string value)
        {
            int intValue;
            float floatValue;
            return Int32.TryParse(value, out intValue) || float.TryParse(value, out floatValue);
        }

        private void foodAddingForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
