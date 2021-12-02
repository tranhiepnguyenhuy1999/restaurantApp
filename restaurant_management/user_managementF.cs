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

        private void dgv_user_SelectionChanged(object sender, EventArgs e)
        {
            int num = dgv_user.CurrentCell.RowIndex;
            id_txtbox.Text = dgv_user.Rows[num].Cells[0].Value.ToString();
            firstname_txtbox.Text = dgv_user.Rows[num].Cells[1].Value.ToString();
            lastname_txtbox.Text = dgv_user.Rows[num].Cells[2].Value.ToString();
            birthday_txtbox.Text = dgv_user.Rows[num].Cells[3].Value.ToString();
            gender_txtbox.Text = dgv_user.Rows[num].Cells[4].Value.ToString();
            createday_txtbox.Text = dgv_user.Rows[num].Cells[5].Value.ToString();
            
        }

        private void update_btn_Click_1(object sender, EventArgs e)
        {
            int num = dgv_user.CurrentCell.RowIndex;
            DateTime birthday = Convert.ToDateTime(birthday_txtbox.Text);
            userDAO.Instance.updateUser(int.Parse(id_txtbox.Text), firstname_txtbox.Text, lastname_txtbox.Text, birthday, int.Parse(gender_txtbox.Text));
            dgv_user.Rows[num].Cells[0].Value = id_txtbox.Text;
            dgv_user.Rows[num].Cells[1].Value = firstname_txtbox.Text;
            dgv_user.Rows[num].Cells[2].Value = lastname_txtbox.Text;
            dgv_user.Rows[num].Cells[3].Value = birthday_txtbox.Text;
            dgv_user.Rows[num].Cells[4].Value = gender_txtbox.Text;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            add_user frm = new add_user();
            frm.ShowDialog();
        }
    }
}
