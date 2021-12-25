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
    
    public partial class Personal_Info : Form
    {
        DTO.User current_user = userDAO.Instance.GetUserByID(UserInfo.Instance.ID);
        public Personal_Info()
        {
            InitializeComponent();
        }

        private void Personal_Info_Load(object sender, EventArgs e)
        {
            user_txtbox.Text = current_user.User_name;
            pass_txtbox.Text = "";
            firstname_txtbox.Text = current_user.First_name;
            lastname_txtbox.Text = current_user.Last_name;
            phone_txtbox.Text = current_user.Phone;
            birthday.Value = current_user.Birthday;
            cbo_gender.SelectedIndex = current_user.Gender;
            role_txtbox.Text = current_user.UserRole;
        }

        private void pass_change_btn_Click(object sender, EventArgs e)
        {
            if (pass_txtbox.Enabled == false)
            {
                pass_txtbox.Enabled = true;
            }
            else pass_txtbox.Enabled = false;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            DateTime birthday0 = Convert.ToDateTime(birthday.Value);
            if ((pass_txtbox.Enabled == true) && (String.IsNullOrEmpty(pass_txtbox.Text)) )
            {
                MessageBox.Show("Password không được để trống");
            }
            else if (isValid(phone_txtbox.Text))
            {

                bool s = userDAO.Instance.updateUser(current_user.ID, firstname_txtbox.Text, lastname_txtbox.Text, phone_txtbox.Text, birthday0,user_txtbox.Text, pass_txtbox.Text, cbo_gender.SelectedIndex,role_txtbox.Text);
                if (s == true) {
                    MessageBox.Show("Cập nhật thành công!");
                }
            }
            else
            {
                MessageBox.Show("SĐT không hợp lệ");
            }
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
    }
}
