using System;
using restaurant_management.DAO;
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
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        public bool isValid(string s)
        {
            if (s[0] == '0' && s.Length == 10 && IsDigit(s))
                return true;
            return false;
        }
        public bool IsDigit(string s)
        {
            foreach (char c in s)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (pass_txtbox.Text != repass_txtbox.Text || isValid(phone_txtbox.Text.ToString())==false)
            {
               MessageBox.Show("Invalid");
            }
            else
            {
                DateTime date = dateTimePicker1.Value.Date;
                string gender = comboBox1.SelectedItem.ToString();
                int g;
                if (gender == "Nữ")
                    g = 1;
                else
                    g = 0;
                DateTime now = DateTime.Now;
                //userDAO.Instance.insertNewUser("n", "Trần Thị", "0915330370", now, "admin12", "1234567", now,2);
                userDAO.Instance.insertNewUser(firstname_txtbox.Text, lastname_txtbox.Text, phone_txtbox.Text, date, user_txtbox.Text, pass_txtbox.Text,now,g );
                MessageBox.Show("Thêm mới thành công !");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user_txtbox.Text = "";
            pass_txtbox.Text = "";
            repass_txtbox.Text = "";
            firstname_txtbox.Text = "";
            lastname_txtbox.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            comboBox1.SelectedIndex = 0;
        }
    }
}
