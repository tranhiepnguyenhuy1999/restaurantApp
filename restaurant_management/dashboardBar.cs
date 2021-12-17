using restaurant_management.Constants;
using restaurant_management.Models;
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
    public partial class dashboardBar : Form
    {
        public List<TableModel> Tables = new List<TableModel>();
        private string role = UserInfo.Instance.Role;
        private Button currentNavButton;
        private Form currentChildForm;
        public dashboardBar()
        {
            InitializeComponent();
            EnableFeaturesByRole();

            Tables.Add(new TableModel(0, "Mang về"));
            for (int i = 1; i < 10; i++)
            {
                Tables.Add(new TableModel(i, "Bàn " + i));
            }
        }

        private void EnableFeaturesByRole()
        {
            switch (role)
            {
                case UserRoles.Admin:
                case UserRoles.Manager:
                    btnFood.Enabled = true;
                    btnFood.Cursor = Cursors.Hand;
                    btnCashOut.Enabled = true;
                    btnCashOut.Cursor = Cursors.Hand;
                    btnBill.Enabled = true;
                    btnBill.Cursor = Cursors.Hand;
                    btnEmployees.Enabled = true;
                    btnEmployees.Cursor = Cursors.Hand;
                    break;
                case UserRoles.Employee:
                    btnCashOut.Enabled = true;
                    btnCashOut.Cursor = Cursors.Hand;
                    btnBill.Enabled = true;
                    btnBill.Cursor = Cursors.Hand;
                    break;
            }
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
            currentNavButton.BackColor = Color.FromArgb(51, 51, 51);
            }
            currentNavButton = button;
            currentNavButton.BackColor = Color.FromArgb(153, 153, 153);
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
            OpenChildForm(new cashOutF(Tables));
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            ActivateNavButton((Button)sender);
            OpenChildForm(new user_managementF());
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void workspace_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Personal_Info info = new Personal_Info();
            info.ShowDialog();
        }
    }
}
