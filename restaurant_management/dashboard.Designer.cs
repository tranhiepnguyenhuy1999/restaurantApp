namespace restaurant_management
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.sideNav = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnCashOut = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.workspace = new System.Windows.Forms.Panel();
            this.sideNav.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // sideNav
            // 
            this.sideNav.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sideNav.Controls.Add(this.btnExit);
            this.sideNav.Controls.Add(this.btnEmployees);
            this.sideNav.Controls.Add(this.btnBill);
            this.sideNav.Controls.Add(this.btnCashOut);
            this.sideNav.Controls.Add(this.btnFood);
            this.sideNav.Controls.Add(this.panel3);
            this.sideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideNav.Location = new System.Drawing.Point(0, 0);
            this.sideNav.Name = "sideNav";
            this.sideNav.Size = new System.Drawing.Size(200, 681);
            this.sideNav.TabIndex = 0;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.titleBar.Controls.Add(this.title);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(200, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1064, 55);
            this.titleBar.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.logo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // btnFood
            // 
            this.btnFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFood.Location = new System.Drawing.Point(0, 100);
            this.btnFood.Name = "btnFood";
            this.btnFood.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFood.Size = new System.Drawing.Size(200, 60);
            this.btnFood.TabIndex = 1;
            this.btnFood.Text = "Quản lý món ăn";
            this.btnFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.UseVisualStyleBackColor = true;
            // 
            // btnCashOut
            // 
            this.btnCashOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCashOut.FlatAppearance.BorderSize = 0;
            this.btnCashOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCashOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCashOut.Location = new System.Drawing.Point(0, 160);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCashOut.Size = new System.Drawing.Size(200, 60);
            this.btnCashOut.TabIndex = 2;
            this.btnCashOut.Text = "Thanh toán";
            this.btnCashOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashOut.UseVisualStyleBackColor = true;
            // 
            // btnBill
            // 
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBill.Location = new System.Drawing.Point(0, 220);
            this.btnBill.Name = "btnBill";
            this.btnBill.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBill.Size = new System.Drawing.Size(200, 60);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "Quản lý bill";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmployees.Location = new System.Drawing.Point(0, 280);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEmployees.Size = new System.Drawing.Size(200, 60);
            this.btnEmployees.TabIndex = 4;
            this.btnEmployees.Text = "Quản lý nhân viên";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(0, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExit.Size = new System.Drawing.Size(200, 60);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(50, 23);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(103, 59);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.Location = new System.Drawing.Point(483, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 37);
            this.title.TabIndex = 0;
            this.title.Text = "label1";
            // 
            // workspace
            // 
            this.workspace.BackColor = System.Drawing.SystemColors.ControlDark;
            this.workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workspace.Location = new System.Drawing.Point(200, 55);
            this.workspace.Name = "workspace";
            this.workspace.Size = new System.Drawing.Size(1064, 626);
            this.workspace.TabIndex = 2;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.workspace);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.sideNav);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.dashboard_FormClosed);
            this.sideNav.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideNav;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnCashOut;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel workspace;
    }
}