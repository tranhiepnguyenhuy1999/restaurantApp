
namespace restaurant_management
{
    partial class Personal_Info
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
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.cbo_gender = new System.Windows.Forms.ComboBox();
            this.phone_txtbox = new System.Windows.Forms.TextBox();
            this.lastname_txtbox = new System.Windows.Forms.TextBox();
            this.firstname_txtbox = new System.Windows.Forms.TextBox();
            this.pass_txtbox = new System.Windows.Forms.TextBox();
            this.user_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.role_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // birthday
            // 
            this.birthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday.CustomFormat = "dd/MM/yyyy";
            this.birthday.Enabled = false;
            this.birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthday.Location = new System.Drawing.Point(94, 187);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(164, 20);
            this.birthday.TabIndex = 33;
            // 
            // cbo_gender
            // 
            this.cbo_gender.Enabled = false;
            this.cbo_gender.FormattingEnabled = true;
            this.cbo_gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_gender.Location = new System.Drawing.Point(94, 222);
            this.cbo_gender.Name = "cbo_gender";
            this.cbo_gender.Size = new System.Drawing.Size(164, 21);
            this.cbo_gender.TabIndex = 32;
            // 
            // phone_txtbox
            // 
            this.phone_txtbox.Location = new System.Drawing.Point(94, 155);
            this.phone_txtbox.Name = "phone_txtbox";
            this.phone_txtbox.ReadOnly = true;
            this.phone_txtbox.Size = new System.Drawing.Size(164, 20);
            this.phone_txtbox.TabIndex = 27;
            // 
            // lastname_txtbox
            // 
            this.lastname_txtbox.Location = new System.Drawing.Point(94, 124);
            this.lastname_txtbox.Name = "lastname_txtbox";
            this.lastname_txtbox.ReadOnly = true;
            this.lastname_txtbox.Size = new System.Drawing.Size(164, 20);
            this.lastname_txtbox.TabIndex = 28;
            // 
            // firstname_txtbox
            // 
            this.firstname_txtbox.Location = new System.Drawing.Point(94, 88);
            this.firstname_txtbox.Name = "firstname_txtbox";
            this.firstname_txtbox.ReadOnly = true;
            this.firstname_txtbox.Size = new System.Drawing.Size(164, 20);
            this.firstname_txtbox.TabIndex = 29;
            // 
            // pass_txtbox
            // 
            this.pass_txtbox.BackColor = System.Drawing.SystemColors.Control;
            this.pass_txtbox.Enabled = false;
            this.pass_txtbox.Location = new System.Drawing.Point(94, 52);
            this.pass_txtbox.Name = "pass_txtbox";
            this.pass_txtbox.ReadOnly = true;
            this.pass_txtbox.Size = new System.Drawing.Size(164, 20);
            this.pass_txtbox.TabIndex = 30;
            this.pass_txtbox.UseSystemPasswordChar = true;
            // 
            // user_txtbox
            // 
            this.user_txtbox.BackColor = System.Drawing.SystemColors.Control;
            this.user_txtbox.Enabled = false;
            this.user_txtbox.Location = new System.Drawing.Point(94, 15);
            this.user_txtbox.Name = "user_txtbox";
            this.user_txtbox.ReadOnly = true;
            this.user_txtbox.Size = new System.Drawing.Size(164, 20);
            this.user_txtbox.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(16, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(16, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(16, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Birthday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(16, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Last name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(16, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Role";
            // 
            // role_txtbox
            // 
            this.role_txtbox.Location = new System.Drawing.Point(94, 260);
            this.role_txtbox.Name = "role_txtbox";
            this.role_txtbox.ReadOnly = true;
            this.role_txtbox.Size = new System.Drawing.Size(164, 20);
            this.role_txtbox.TabIndex = 27;
            // 
            // Personal_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(312, 316);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.cbo_gender);
            this.Controls.Add(this.role_txtbox);
            this.Controls.Add(this.phone_txtbox);
            this.Controls.Add(this.lastname_txtbox);
            this.Controls.Add(this.firstname_txtbox);
            this.Controls.Add(this.pass_txtbox);
            this.Controls.Add(this.user_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Name = "Personal_Info";
            this.Text = "Personal Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.ComboBox cbo_gender;
        private System.Windows.Forms.TextBox phone_txtbox;
        private System.Windows.Forms.TextBox lastname_txtbox;
        private System.Windows.Forms.TextBox firstname_txtbox;
        private System.Windows.Forms.TextBox pass_txtbox;
        private System.Windows.Forms.TextBox user_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox role_txtbox;
    }
}