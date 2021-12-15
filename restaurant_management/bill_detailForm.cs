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

    public partial class bill_detailForm : Form
    {
        public string temp;
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
            int rc = dgvdetail.Rows.Count;
            totalBill_txtbox.Text = rc.ToString();
        }
        /*private void GetMessage(string message)
{
   ID.Text = message;
}*/
    }
}
