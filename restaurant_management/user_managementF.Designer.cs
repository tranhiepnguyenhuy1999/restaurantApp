
namespace restaurant_management
{
    partial class user_managementF
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
            this.add_btn = new System.Windows.Forms.Button();
            this.id_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.firstname_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastname_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.birthday_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.createday_txtbox = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_gender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.user_txtbox = new System.Windows.Forms.TextBox();
            this.pass_change_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.phone_txtbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pass_txtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(12, 12);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(102, 38);
            this.add_btn.TabIndex = 17;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // id_txtbox
            // 
            this.id_txtbox.BackColor = System.Drawing.SystemColors.Control;
            this.id_txtbox.Enabled = false;
            this.id_txtbox.Location = new System.Drawing.Point(632, 135);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(112, 20);
            this.id_txtbox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // dgv_user
            // 
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(12, 77);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.Size = new System.Drawing.Size(555, 367);
            this.dgv_user.TabIndex = 8;
            this.dgv_user.SelectionChanged += new System.EventHandler(this.dgv_user_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "First name";
            // 
            // firstname_txtbox
            // 
            this.firstname_txtbox.Location = new System.Drawing.Point(632, 174);
            this.firstname_txtbox.Name = "firstname_txtbox";
            this.firstname_txtbox.Size = new System.Drawing.Size(112, 20);
            this.firstname_txtbox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last name";
            // 
            // lastname_txtbox
            // 
            this.lastname_txtbox.Location = new System.Drawing.Point(632, 212);
            this.lastname_txtbox.Name = "lastname_txtbox";
            this.lastname_txtbox.Size = new System.Drawing.Size(112, 20);
            this.lastname_txtbox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birthday";
            // 
            // birthday_txtbox
            // 
            this.birthday_txtbox.Location = new System.Drawing.Point(632, 282);
            this.birthday_txtbox.Name = "birthday_txtbox";
            this.birthday_txtbox.Size = new System.Drawing.Size(112, 20);
            this.birthday_txtbox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Create date";
            // 
            // createday_txtbox
            // 
            this.createday_txtbox.BackColor = System.Drawing.SystemColors.Control;
            this.createday_txtbox.Enabled = false;
            this.createday_txtbox.Location = new System.Drawing.Point(632, 362);
            this.createday_txtbox.Name = "createday_txtbox";
            this.createday_txtbox.ReadOnly = true;
            this.createday_txtbox.Size = new System.Drawing.Size(112, 20);
            this.createday_txtbox.TabIndex = 12;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(120, 12);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(102, 38);
            this.delete_btn.TabIndex = 17;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(632, 405);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(102, 38);
            this.update_btn.TabIndex = 17;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gender";
            // 
            // cbo_gender
            // 
            this.cbo_gender.FormattingEnabled = true;
            this.cbo_gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_gender.Location = new System.Drawing.Point(632, 323);
            this.cbo_gender.Name = "cbo_gender";
            this.cbo_gender.Size = new System.Drawing.Size(112, 21);
            this.cbo_gender.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Username";
            // 
            // user_txtbox
            // 
            this.user_txtbox.BackColor = System.Drawing.SystemColors.Control;
            this.user_txtbox.Enabled = false;
            this.user_txtbox.Location = new System.Drawing.Point(632, 64);
            this.user_txtbox.Name = "user_txtbox";
            this.user_txtbox.Size = new System.Drawing.Size(112, 20);
            this.user_txtbox.TabIndex = 12;
            // 
            // pass_change_btn
            // 
            this.pass_change_btn.Location = new System.Drawing.Point(749, 98);
            this.pass_change_btn.Name = "pass_change_btn";
            this.pass_change_btn.Size = new System.Drawing.Size(63, 22);
            this.pass_change_btn.TabIndex = 17;
            this.pass_change_btn.Text = "Change";
            this.pass_change_btn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(573, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Phone";
            // 
            // phone_txtbox
            // 
            this.phone_txtbox.Location = new System.Drawing.Point(632, 247);
            this.phone_txtbox.Name = "phone_txtbox";
            this.phone_txtbox.Size = new System.Drawing.Size(112, 20);
            this.phone_txtbox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(573, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Password";
            // 
            // pass_txtbox
            // 
            this.pass_txtbox.BackColor = System.Drawing.SystemColors.Control;
            this.pass_txtbox.Enabled = false;
            this.pass_txtbox.Location = new System.Drawing.Point(632, 99);
            this.pass_txtbox.Name = "pass_txtbox";
            this.pass_txtbox.Size = new System.Drawing.Size(112, 20);
            this.pass_txtbox.TabIndex = 12;
            this.pass_txtbox.UseSystemPasswordChar = true;
            // 
            // user_managementF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 506);
            this.Controls.Add(this.cbo_gender);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.pass_change_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.createday_txtbox);
            this.Controls.Add(this.birthday_txtbox);
            this.Controls.Add(this.phone_txtbox);
            this.Controls.Add(this.lastname_txtbox);
            this.Controls.Add(this.firstname_txtbox);
            this.Controls.Add(this.pass_txtbox);
            this.Controls.Add(this.user_txtbox);
            this.Controls.Add(this.id_txtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_user);
            this.Name = "user_managementF";
            this.Text = "user_managementForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox id_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstname_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastname_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox birthday_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox createday_txtbox;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_gender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox user_txtbox;
        private System.Windows.Forms.Button pass_change_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phone_txtbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pass_txtbox;
    }
}