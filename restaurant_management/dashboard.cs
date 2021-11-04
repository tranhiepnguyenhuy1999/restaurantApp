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
    public partial class dashboard : Form
    {
        private Form currentChildForm;
        public dashboard()
        {
            InitializeComponent();
        }

        private void OpenChildForm (Form childForm)
        {
            if (currentChildForm != null)
            {
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

        private void dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
