﻿
namespace restaurant_management
{
    partial class bill_detailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.totalFood_txtbox = new System.Windows.Forms.TextBox();
            this.totalBill_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvdetail = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).BeginInit();
            this.SuspendLayout();
            // 
            // totalFood_txtbox
            // 
            this.totalFood_txtbox.Location = new System.Drawing.Point(479, 400);
            this.totalFood_txtbox.Name = "totalFood_txtbox";
            this.totalFood_txtbox.Size = new System.Drawing.Size(137, 20);
            this.totalFood_txtbox.TabIndex = 29;
            // 
            // totalBill_txtbox
            // 
            this.totalBill_txtbox.Location = new System.Drawing.Point(158, 402);
            this.totalBill_txtbox.Name = "totalBill_txtbox";
            this.totalBill_txtbox.Size = new System.Drawing.Size(53, 20);
            this.totalBill_txtbox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Total amount of food:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Quantity of bills:";
            // 
            // dgvdetail
            // 
            this.dgvdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetail.Location = new System.Drawing.Point(74, 46);
            this.dgvdetail.Name = "dgvdetail";
            this.dgvdetail.RowHeadersWidth = 62;
            this.dgvdetail.Size = new System.Drawing.Size(542, 338);
            this.dgvdetail.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(111, 12);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(505, 20);
            this.ID.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Bill ID";
            // 
            // bill_detailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalFood_txtbox);
            this.Controls.Add(this.totalBill_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvdetail);
            this.Name = "bill_detailForm";
            this.Text = "bill_detailForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox totalFood_txtbox;
        private System.Windows.Forms.TextBox totalBill_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvdetail;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
    }
}