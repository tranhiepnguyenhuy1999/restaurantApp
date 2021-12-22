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

    public partial class bill_detailForm : Form
    {
        public string temp;
        public string total_amount;
        public string total_money;
        public DateTime create_date;
        //public delegate void SendMessage(string Message);
        //public SendMessage Sender;
        public bill_detailForm()
        {
            InitializeComponent();
            //Sender = new SendMessage(GetMessage);
        }

        private void bill_detailForm_Load(object sender, EventArgs e)
        {
            ID.Text = temp;
            int id_check = int.Parse(temp);
            dgvdetail.DataSource = detailBillDAO.Instance.getListBillById(id_check);
            dgvdetail.Columns[0].Visible = false;
            dgvdetail.Columns[2].Visible = false;
            amount_txtbox.Text = total_amount;
            sum_txtbox.Text = total_money;
            date_txtbox.Text = create_date.ToString("dd/MM/yyyy");
        }
        /*private void GetMessage(string message)
{
   ID.Text = message;
}*/
    }
}
