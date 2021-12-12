﻿using System;
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

        private void dgv_user_SelectionChanged(object sender, EventArgs e)
        {
            int num = dgv_user.CurrentCell.RowIndex;
            DateTime date = Convert.ToDateTime(dgv_user.Rows[num].Cells[5].Value.ToString());
            firstname_txtbox.Text = dgv_user.Rows[num].Cells[1].Value.ToString();
            lastname_txtbox.Text = dgv_user.Rows[num].Cells[2].Value.ToString();
            phone_txtbox.Text = dgv_user.Rows[num].Cells[3].Value.ToString();
            dateTimePicker1.Value = date.Date;
            if (int.Parse(dgv_user.Rows[num].Cells[6].Value.ToString()) == 0) cbo_gender.SelectedIndex = 0;
            else cbo_gender.SelectedIndex = 1;
            user_txtbox.Text = dgv_user.Rows[num].Cells[7].Value.ToString();
            pass_txtbox.Text = dgv_user.Rows[num].Cells[8].Value.ToString();
        }

        private void update_btn_Click_1(object sender, EventArgs e)
        {
            int num = dgv_user.CurrentCell.RowIndex;
            if (isValid(phone_txtbox.Text))
            {
                DateTime birthday = Convert.ToDateTime(dateTimePicker1.Value);
                userDAO.Instance.updateUser(int.Parse(dgv_user.Rows[num].Cells[0].Value.ToString()), firstname_txtbox.Text, lastname_txtbox.Text, phone_txtbox.Text, birthday, user_txtbox.Text, pass_txtbox.Text);
                dgv_user.Rows[num].Cells[1].Value = firstname_txtbox.Text;
                dgv_user.Rows[num].Cells[2].Value = lastname_txtbox.Text;
                dgv_user.Rows[num].Cells[3].Value = phone_txtbox.Text;
                dgv_user.Rows[num].Cells[5].Value = birthday.Date.ToString();
                dgv_user.Rows[num].Cells[7].Value = user_txtbox.Text;
                dgv_user.Rows[num].Cells[8].Value = pass_txtbox.Text;
                LoadListUser();
            }
            else MessageBox.Show("Invalid");
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            add_user frm = new add_user();
            frm.ShowDialog();
            LoadListUser();
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

        private void user_managementF_Load(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
