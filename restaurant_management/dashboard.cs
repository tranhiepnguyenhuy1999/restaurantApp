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
        public dashboard()
        {
            InitializeComponent();
            loadingdata();
    
        }
        public void loadingdata() {
            data_table.DataSource = userDAO.Instance.getUserList();
        }

    }
}
