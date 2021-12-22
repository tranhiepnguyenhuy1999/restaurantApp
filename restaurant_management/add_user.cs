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
            if (String.IsNullOrEmpty(pass_txtbox.Text) || String.IsNullOrEmpty(user_txtbox.Text) || String.IsNullOrEmpty(firstname_txtbox.Text) || String.IsNullOrEmpty(lastname_txtbox.Text) || String.IsNullOrEmpty(phone_txtbox.Text) || String.IsNullOrEmpty(repass_txtbox.Text))
            {
                MessageBox.Show("Thông tin không được để trống");
            }
            else if (pass_txtbox.Text != repass_txtbox.Text)
            {
               MessageBox.Show("Re-pass phải trùng với pass");
            }
            else if (isValid(phone_txtbox.Text.ToString()) == false)
            {
               MessageBox.Show("SĐT không hợp lệ");
            }
            else  if (rolecbo.SelectedItem.ToString() == UserInfo.Instance.Role || !(UserInfo.Instance.Role == "admin"))
            {
               MessageBox.Show("Role được chọn không hợp lệ");
            }
            else if (dateTimePicker1.Value > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
            }
            else if (check_user_valid(user_txtbox.Text) == false)
            {
                MessageBox.Show("Tài khoản đã tồn tại");
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
            rolecbo.SelectedIndex = 1;
        }

        private void add_user_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            rolecbo.SelectedIndex = 1;
            if (UserInfo.Instance.Role == "admin")
            {
                rolecbo.Items.Add("admin");
            }
        }
        public bool check_user_valid(string s)
        {
            int check = userDAO.Instance.getidbyname(s);
            if (check != 0)
                return false;
            else return true;
        }
    }
}
