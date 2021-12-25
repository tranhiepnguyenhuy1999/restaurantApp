using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using restaurant_management.DAO;

namespace restaurant_management
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn thoát", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DTO.User user = userDAO.Instance.GetIdByUsernamePwd(txt_UserName.Text, txt_pwd.Text);
            //try
            //{
                if (user != null)
                {
                    this.Hide();
                    UserInfo.Instance.IsLogin = true;
                    UserInfo.Instance.Role = user.UserRole;
                    UserInfo.Instance.ID = user.ID;
                    UserInfo.Instance.Username = user.User_name;


                    dashboardBar dash = new dashboardBar(txt_UserName.Text);
                    dash.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            //}
            //catch
            //{
            //    MessageBox.Show("Có vấn đề với cơ sở dữ liệu");
            //}
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
