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
    public partial class user_managementF : Form
    {
        void LoadListUser()
        {
            dgv_user.DataSource = userDAO.Instance.getUserList();
        }
        public user_managementF()
        {
            InitializeComponent();
            LoadListUser();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
