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
    public partial class loginF : Form
    {
        public loginF()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dashboardBar dash = new dashboardBar();
            dash.ShowDialog();
        }
    }
}
