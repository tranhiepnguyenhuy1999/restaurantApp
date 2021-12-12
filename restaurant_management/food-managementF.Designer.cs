
using System;
using System.Windows.Forms;

namespace restaurant_management
{
    partial class foodManagementF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.foodsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.foodInformationPanel = new System.Windows.Forms.Panel();
            this.manageTypeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.foodDetailsPanel = new System.Windows.Forms.Panel();
            this.foodDetailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foodsDataGridView)).BeginInit();
            this.foodInformationPanel.SuspendLayout();
            this.foodDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodsDataGridView
            // 
            this.foodsDataGridView.AllowUserToAddRows = false;
            this.foodsDataGridView.AllowUserToDeleteRows = false;
            this.foodsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.foodsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.foodsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.foodsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.foodsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.foodsDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.foodsDataGridView.GridColor = System.Drawing.Color.Black;
            this.foodsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.foodsDataGridView.MultiSelect = false;
            this.foodsDataGridView.Name = "foodsDataGridView";
            this.foodsDataGridView.ReadOnly = true;
            this.foodsDataGridView.RowHeadersVisible = false;
            this.foodsDataGridView.RowHeadersWidth = 62;
            this.foodsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodsDataGridView.Size = new System.Drawing.Size(484, 393);
            this.foodsDataGridView.TabIndex = 0;
            this.foodsDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodsDataGridView_RowEnter);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(11, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 16);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(11, 64);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 16);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.Location = new System.Drawing.Point(76, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(120, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTextBox.Location = new System.Drawing.Point(76, 63);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(120, 20);
            this.priceTextBox.TabIndex = 6;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(121, 142);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 42);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // foodInformationPanel
            // 
            this.foodInformationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.foodInformationPanel.Controls.Add(this.manageTypeBtn);
            this.foodInformationPanel.Controls.Add(this.addBtn);
            this.foodInformationPanel.Controls.Add(this.typeLabel);
            this.foodInformationPanel.Controls.Add(this.updateBtn);
            this.foodInformationPanel.Controls.Add(this.typeComboBox);
            this.foodInformationPanel.Controls.Add(this.deleteBtn);
            this.foodInformationPanel.Controls.Add(this.nameLabel);
            this.foodInformationPanel.Controls.Add(this.priceLabel);
            this.foodInformationPanel.Controls.Add(this.priceTextBox);
            this.foodInformationPanel.Controls.Add(this.nameTextBox);
            this.foodInformationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.foodInformationPanel.ForeColor = System.Drawing.Color.White;
            this.foodInformationPanel.Location = new System.Drawing.Point(0, 63);
            this.foodInformationPanel.Name = "foodInformationPanel";
            this.foodInformationPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.foodInformationPanel.Size = new System.Drawing.Size(213, 330);
            this.foodInformationPanel.TabIndex = 2;
            // 
            // manageTypeBtn
            // 
            this.manageTypeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageTypeBtn.ForeColor = System.Drawing.Color.Black;
            this.manageTypeBtn.Location = new System.Drawing.Point(14, 278);
            this.manageTypeBtn.Name = "manageTypeBtn";
            this.manageTypeBtn.Size = new System.Drawing.Size(182, 40);
            this.manageTypeBtn.TabIndex = 14;
            this.manageTypeBtn.Text = "Manage Type";
            this.manageTypeBtn.UseVisualStyleBackColor = true;
            this.manageTypeBtn.Click += new System.EventHandler(this.manageTypeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(14, 232);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(182, 40);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add Food";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(11, 116);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(44, 16);
            this.typeLabel.TabIndex = 12;
            this.typeLabel.Text = "Type";
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(14, 142);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 42);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Table 1",
            "Table 2"});
            this.typeComboBox.Location = new System.Drawing.Point(76, 115);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(120, 21);
            this.typeComboBox.TabIndex = 10;
            // 
            // foodDetailsPanel
            // 
            this.foodDetailsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.foodDetailsPanel.Controls.Add(this.foodInformationPanel);
            this.foodDetailsPanel.Controls.Add(this.foodDetailsLabel);
            this.foodDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodDetailsPanel.Location = new System.Drawing.Point(484, 0);
            this.foodDetailsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.foodDetailsPanel.Name = "foodDetailsPanel";
            this.foodDetailsPanel.Size = new System.Drawing.Size(213, 393);
            this.foodDetailsPanel.TabIndex = 3;
            // 
            // foodDetailsLabel
            // 
            this.foodDetailsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.foodDetailsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.foodDetailsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.foodDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodDetailsLabel.ForeColor = System.Drawing.Color.White;
            this.foodDetailsLabel.Location = new System.Drawing.Point(0, 0);
            this.foodDetailsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.foodDetailsLabel.Name = "foodDetailsLabel";
            this.foodDetailsLabel.Size = new System.Drawing.Size(213, 63);
            this.foodDetailsLabel.TabIndex = 3;
            this.foodDetailsLabel.Text = "Food Details";
            this.foodDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodManagementF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(697, 393);
            this.Controls.Add(this.foodDetailsPanel);
            this.Controls.Add(this.foodsDataGridView);
            this.Name = "foodManagementF";
            this.Text = "Food Management";
            this.Load += new System.EventHandler(this.foodManagementF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodsDataGridView)).EndInit();
            this.foodInformationPanel.ResumeLayout(false);
            this.foodInformationPanel.PerformLayout();
            this.foodDetailsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView foodsDataGridView;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel foodInformationPanel;
        private System.Windows.Forms.Panel foodDetailsPanel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private Label typeLabel;
        private Button updateBtn;
        private Button addBtn;
        private Button manageTypeBtn;
        private Label foodDetailsLabel;
    }
}