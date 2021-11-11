﻿using System;
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
    public partial class dashboardBar : Form
    {
        
        private Button currentNavButton;
        private Form currentChildForm;
        public dashboardBar()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                if (currentChildForm.Name == childForm.Name) return;
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            workspace.Controls.Add(childForm);
            workspace.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            title.Text = childForm.Text;
        }

        private void ActivateNavButton(Button button)
        {
            if (currentNavButton != null)
            {
                currentNavButton.BackColor = Color.FromArgb(0, 114, 181);
            }
            currentNavButton = button;
            currentNavButton.BackColor = Color.FromArgb(0, 162, 255);
        }

        private void dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            ActivateNavButton((Button)sender);
            OpenChildForm(new foodManagementF());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            ActivateNavButton((Button)sender);
            OpenChildForm(new bill_managementForm());
        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            ActivateNavButton((Button)sender);
            OpenChildForm(new cashOutF());
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            ActivateNavButton((Button)sender);
            OpenChildForm(new user_managementF());
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }
    }
}
