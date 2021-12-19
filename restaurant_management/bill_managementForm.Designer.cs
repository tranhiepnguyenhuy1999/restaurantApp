
namespace restaurant_management
{
    partial class bill_managementForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_Find = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bill_count_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sum_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.typecb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.selected_id_txtbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timecb = new System.Windows.Forms.ComboBox();
            this.sortcb = new System.Windows.Forms.ComboBox();
            this.find_btn = new System.Windows.Forms.Button();
            this.printTable_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(2, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(514, 337);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(522, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find ID:";
            // 
            // ID_Find
            // 
            this.ID_Find.Location = new System.Drawing.Point(579, 56);
            this.ID_Find.Name = "ID_Find";
            this.ID_Find.Size = new System.Drawing.Size(114, 20);
            this.ID_Find.TabIndex = 2;
            this.ID_Find.TextChanged += new System.EventHandler(this.ID_Find_TextChanged);
            this.ID_Find.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ID_Find_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(523, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sort by:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(522, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(522, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total bills:";
            // 
            // bill_count_txtbox
            // 
            this.bill_count_txtbox.Location = new System.Drawing.Point(579, 223);
            this.bill_count_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bill_count_txtbox.Name = "bill_count_txtbox";
            this.bill_count_txtbox.Size = new System.Drawing.Size(114, 20);
            this.bill_count_txtbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(523, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sum:";
            // 
            // sum_txtbox
            // 
            this.sum_txtbox.Location = new System.Drawing.Point(579, 253);
            this.sum_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sum_txtbox.Name = "sum_txtbox";
            this.sum_txtbox.Size = new System.Drawing.Size(114, 20);
            this.sum_txtbox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(523, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(579, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // typecb
            // 
            this.typecb.FormattingEnabled = true;
            this.typecb.Items.AddRange(new object[] {
            "All",
            "Year",
            "Month",
            "Date"});
            this.typecb.Location = new System.Drawing.Point(579, 108);
            this.typecb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typecb.Name = "typecb";
            this.typecb.Size = new System.Drawing.Size(114, 21);
            this.typecb.TabIndex = 11;
            this.typecb.SelectedIndexChanged += new System.EventHandler(this.typecb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(522, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(522, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Selected Bill ID:";
            // 
            // selected_id_txtbox
            // 
            this.selected_id_txtbox.Location = new System.Drawing.Point(619, 284);
            this.selected_id_txtbox.Name = "selected_id_txtbox";
            this.selected_id_txtbox.Size = new System.Drawing.Size(74, 20);
            this.selected_id_txtbox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(516, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 53);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bill Infomation";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(523, 164);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Time:";
            // 
            // timecb
            // 
            this.timecb.FormattingEnabled = true;
            this.timecb.Items.AddRange(new object[] {
            "Lastest",
            "Oldest"});
            this.timecb.Location = new System.Drawing.Point(579, 161);
            this.timecb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timecb.Name = "timecb";
            this.timecb.Size = new System.Drawing.Size(114, 21);
            this.timecb.TabIndex = 14;
            // 
            // sortcb
            // 
            this.sortcb.FormattingEnabled = true;
            this.sortcb.Items.AddRange(new object[] {
            "Lowsest Amount ",
            "Highest Amount ",
            "Lowsest Money  ",
            "Highest Money "});
            this.sortcb.Location = new System.Drawing.Point(579, 135);
            this.sortcb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortcb.Name = "sortcb";
            this.sortcb.Size = new System.Drawing.Size(114, 21);
            this.sortcb.TabIndex = 15;
            // 
            // find_btn
            // 
            this.find_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_btn.Location = new System.Drawing.Point(525, 190);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(168, 25);
            this.find_btn.TabIndex = 17;
            this.find_btn.Text = "Find";
            this.find_btn.UseVisualStyleBackColor = true;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // printTable_btn
            // 
            this.printTable_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printTable_btn.Location = new System.Drawing.Point(397, 343);
            this.printTable_btn.Name = "printTable_btn";
            this.printTable_btn.Size = new System.Drawing.Size(119, 38);
            this.printTable_btn.TabIndex = 18;
            this.printTable_btn.Text = "Export Excel";
            this.printTable_btn.UseVisualStyleBackColor = true;
            this.printTable_btn.Click += new System.EventHandler(this.printTable_btn_Click);
            // 
            // bill_managementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(697, 393);
            this.Controls.Add(this.printTable_btn);
            this.Controls.Add(this.find_btn);
            this.Controls.Add(this.sortcb);
            this.Controls.Add(this.timecb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.typecb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sum_txtbox);
            this.Controls.Add(this.selected_id_txtbox);
            this.Controls.Add(this.bill_count_txtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ID_Find);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Name = "bill_managementForm";
            this.Text = "Bill Management";
            this.Load += new System.EventHandler(this.bill_managementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID_Find;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bill_count_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sum_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox typecb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox selected_id_txtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.ComboBox timecb;
        private System.Windows.Forms.ComboBox sortcb;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Button printTable_btn;
    }
}