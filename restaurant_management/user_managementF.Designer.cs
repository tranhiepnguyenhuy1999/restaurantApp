
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
            this.gender_txtbox = new System.Windows.Forms.TextBox();
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
            // 
            // id_txtbox
            // 
            this.id_txtbox.Location = new System.Drawing.Point(619, 73);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(112, 20);
            this.id_txtbox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 77);
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
            this.dgv_user.Size = new System.Drawing.Size(542, 338);
            this.dgv_user.TabIndex = 8;
            this.dgv_user.SelectionChanged += new System.EventHandler(this.dgv_user_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "First name";
            // 
            // firstname_txtbox
            // 
            this.firstname_txtbox.Location = new System.Drawing.Point(619, 125);
            this.firstname_txtbox.Name = "firstname_txtbox";
            this.firstname_txtbox.Size = new System.Drawing.Size(112, 20);
            this.firstname_txtbox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last name";
            // 
            // lastname_txtbox
            // 
            this.lastname_txtbox.Location = new System.Drawing.Point(619, 172);
            this.lastname_txtbox.Name = "lastname_txtbox";
            this.lastname_txtbox.Size = new System.Drawing.Size(112, 20);
            this.lastname_txtbox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birthday";
            // 
            // birthday_txtbox
            // 
            this.birthday_txtbox.Location = new System.Drawing.Point(619, 220);
            this.birthday_txtbox.Name = "birthday_txtbox";
            this.birthday_txtbox.Size = new System.Drawing.Size(112, 20);
            this.birthday_txtbox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Create date";
            // 
            // createday_txtbox
            // 
            this.createday_txtbox.Location = new System.Drawing.Point(619, 319);
            this.createday_txtbox.Name = "createday_txtbox";
            this.createday_txtbox.Size = new System.Drawing.Size(112, 20);
            this.createday_txtbox.TabIndex = 12;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(162, 12);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(102, 38);
            this.delete_btn.TabIndex = 17;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(619, 373);
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
            this.label6.Location = new System.Drawing.Point(560, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gender";
            // 
            // gender_txtbox
            // 
            this.gender_txtbox.Location = new System.Drawing.Point(619, 268);
            this.gender_txtbox.Name = "gender_txtbox";
            this.gender_txtbox.Size = new System.Drawing.Size(112, 20);
            this.gender_txtbox.TabIndex = 12;
            // 
            // user_managementF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.gender_txtbox);
            this.Controls.Add(this.createday_txtbox);
            this.Controls.Add(this.birthday_txtbox);
            this.Controls.Add(this.lastname_txtbox);
            this.Controls.Add(this.firstname_txtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.id_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.TextBox gender_txtbox;
    }
}