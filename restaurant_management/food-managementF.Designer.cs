﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.foodsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.foodInformationPanel = new System.Windows.Forms.Panel();
            this.typeLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.manageTypeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.foodDetailsPanel = new System.Windows.Forms.Panel();
            this.functionPanel = new System.Windows.Forms.Panel();
            this.exportBtn = new System.Windows.Forms.Button();
            this.foodDetailsLabel = new System.Windows.Forms.Label();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.searchBarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foodsDataGridView)).BeginInit();
            this.foodInformationPanel.SuspendLayout();
            this.foodDetailsPanel.SuspendLayout();
            this.functionPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.searchBarPanel.SuspendLayout();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.foodsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.foodsDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.foodsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.foodsDataGridView.GridColor = System.Drawing.Color.Black;
            this.foodsDataGridView.Location = new System.Drawing.Point(0, 33);
            this.foodsDataGridView.MultiSelect = false;
            this.foodsDataGridView.Name = "foodsDataGridView";
            this.foodsDataGridView.ReadOnly = true;
            this.foodsDataGridView.RowHeadersVisible = false;
            this.foodsDataGridView.RowHeadersWidth = 62;
            this.foodsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodsDataGridView.Size = new System.Drawing.Size(479, 360);
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
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(121, 142);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 27);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // foodInformationPanel
            // 
            this.foodInformationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.foodInformationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.foodInformationPanel.Controls.Add(this.typeLabel);
            this.foodInformationPanel.Controls.Add(this.updateBtn);
            this.foodInformationPanel.Controls.Add(this.typeComboBox);
            this.foodInformationPanel.Controls.Add(this.deleteBtn);
            this.foodInformationPanel.Controls.Add(this.nameLabel);
            this.foodInformationPanel.Controls.Add(this.priceLabel);
            this.foodInformationPanel.Controls.Add(this.priceTextBox);
            this.foodInformationPanel.Controls.Add(this.nameTextBox);
            this.foodInformationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.foodInformationPanel.ForeColor = System.Drawing.Color.White;
            this.foodInformationPanel.Location = new System.Drawing.Point(0, 50);
            this.foodInformationPanel.Name = "foodInformationPanel";
            this.foodInformationPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.foodInformationPanel.Size = new System.Drawing.Size(213, 180);
            this.foodInformationPanel.TabIndex = 2;
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
            this.updateBtn.Size = new System.Drawing.Size(75, 27);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Table 1",
            "Table 2"});
            this.typeComboBox.Location = new System.Drawing.Point(76, 115);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(120, 21);
            this.typeComboBox.TabIndex = 10;
            // 
            // manageTypeBtn
            // 
            this.manageTypeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageTypeBtn.ForeColor = System.Drawing.Color.Black;
            this.manageTypeBtn.Location = new System.Drawing.Point(16, 59);
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
            this.addBtn.Location = new System.Drawing.Point(16, 13);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(182, 40);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add Food";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // foodDetailsPanel
            // 
            this.foodDetailsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.foodDetailsPanel.Controls.Add(this.functionPanel);
            this.foodDetailsPanel.Controls.Add(this.foodInformationPanel);
            this.foodDetailsPanel.Controls.Add(this.foodDetailsLabel);
            this.foodDetailsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.foodDetailsPanel.Location = new System.Drawing.Point(484, 0);
            this.foodDetailsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.foodDetailsPanel.Name = "foodDetailsPanel";
            this.foodDetailsPanel.Size = new System.Drawing.Size(213, 393);
            this.foodDetailsPanel.TabIndex = 3;
            // 
            // functionPanel
            // 
            this.functionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.functionPanel.Controls.Add(this.exportBtn);
            this.functionPanel.Controls.Add(this.addBtn);
            this.functionPanel.Controls.Add(this.manageTypeBtn);
            this.functionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.functionPanel.Location = new System.Drawing.Point(0, 227);
            this.functionPanel.Name = "functionPanel";
            this.functionPanel.Size = new System.Drawing.Size(213, 166);
            this.functionPanel.TabIndex = 2;
            // 
            // exportBtn
            // 
            this.exportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.Black;
            this.exportBtn.Location = new System.Drawing.Point(16, 105);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(182, 40);
            this.exportBtn.TabIndex = 15;
            this.exportBtn.Text = "Export Excel";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
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
            this.foodDetailsLabel.Size = new System.Drawing.Size(213, 50);
            this.foodDetailsLabel.TabIndex = 3;
            this.foodDetailsLabel.Text = "Food Details";
            this.foodDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.searchBarPanel);
            this.dataPanel.Controls.Add(this.foodsDataGridView);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataPanel.Location = new System.Drawing.Point(0, 0);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(479, 393);
            this.dataPanel.TabIndex = 4;
            // 
            // searchBarPanel
            // 
            this.searchBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.searchBarPanel.Controls.Add(this.label1);
            this.searchBarPanel.Controls.Add(this.searchBtn);
            this.searchBarPanel.Controls.Add(this.searchTextBox);
            this.searchBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBarPanel.Location = new System.Drawing.Point(0, 0);
            this.searchBarPanel.Name = "searchBarPanel";
            this.searchBarPanel.Size = new System.Drawing.Size(479, 35);
            this.searchBarPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(333, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "*Type food name to search";
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(252, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(3, 7);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(243, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // foodManagementF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(697, 393);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.foodDetailsPanel);
            this.Name = "foodManagementF";
            this.Text = "Food Management";
            this.Load += new System.EventHandler(this.foodManagementF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodsDataGridView)).EndInit();
            this.foodInformationPanel.ResumeLayout(false);
            this.foodInformationPanel.PerformLayout();
            this.foodDetailsPanel.ResumeLayout(false);
            this.functionPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.searchBarPanel.ResumeLayout(false);
            this.searchBarPanel.PerformLayout();
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
        private Panel dataPanel;
        private Panel searchBarPanel;
        private Button searchBtn;
        private TextBox searchTextBox;
        private Label label1;
        private Button exportBtn;
        private Panel functionPanel;
    }
}