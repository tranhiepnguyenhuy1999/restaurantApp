
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.totalBill_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvdetail = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalBill_txtbox
            // 
            this.totalBill_txtbox.Location = new System.Drawing.Point(253, 223);
            this.totalBill_txtbox.Name = "totalBill_txtbox";
            this.totalBill_txtbox.Size = new System.Drawing.Size(159, 20);
            this.totalBill_txtbox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(120, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Total bills:";
            // 
            // dgvdetail
            // 
            this.dgvdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdetail.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdetail.Location = new System.Drawing.Point(0, 0);
            this.dgvdetail.Name = "dgvdetail";
            this.dgvdetail.ReadOnly = true;
            this.dgvdetail.RowHeadersVisible = false;
            this.dgvdetail.RowHeadersWidth = 62;
            this.dgvdetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetail.Size = new System.Drawing.Size(378, 172);
            this.dgvdetail.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(77, 16);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(335, 20);
            this.ID.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Bill ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvdetail);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(34, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 175);
            this.panel1.TabIndex = 32;
            // 
            // bill_detailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(487, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalBill_txtbox);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "bill_detailForm";
            this.Text = "bill_detailForm";
            this.Load += new System.EventHandler(this.bill_detailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox totalBill_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvdetail;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}