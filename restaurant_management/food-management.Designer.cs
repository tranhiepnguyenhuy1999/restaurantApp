
namespace restaurant_management
{
    partial class foodManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foodManagementForm));
            this.foodsDataGridView = new System.Windows.Forms.DataGridView();
            this.foodPictureBox = new System.Windows.Forms.PictureBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.cashOutBtn = new System.Windows.Forms.Button();
            this.foodInformationPanel = new System.Windows.Forms.Panel();
            this.cashOutTableComboBox = new System.Windows.Forms.ComboBox();
            this.foodDetailsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.foodsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodPictureBox)).BeginInit();
            this.foodInformationPanel.SuspendLayout();
            this.foodDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodsDataGridView
            // 
            this.foodsDataGridView.AllowUserToAddRows = false;
            this.foodsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.foodsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
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
            this.foodsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foodsDataGridView.MultiSelect = false;
            this.foodsDataGridView.Name = "foodsDataGridView";
            this.foodsDataGridView.RowHeadersVisible = false;
            this.foodsDataGridView.RowHeadersWidth = 62;
            this.foodsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodsDataGridView.Size = new System.Drawing.Size(789, 758);
            this.foodsDataGridView.TabIndex = 0;
            this.foodsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodsDataGridView_CellContentClick);
            this.foodsDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodsDataGridView_RowEnter);
            // 
            // foodPictureBox
            // 
            this.foodPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.foodPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("foodPictureBox.Image")));
            this.foodPictureBox.Location = new System.Drawing.Point(0, 0);
            this.foodPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foodPictureBox.Name = "foodPictureBox";
            this.foodPictureBox.Size = new System.Drawing.Size(450, 308);
            this.foodPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foodPictureBox.TabIndex = 0;
            this.foodPictureBox.TabStop = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(20, 32);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(33, 25);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(20, 89);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 25);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(20, 154);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(61, 25);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price";
            // 
            // idTextBox
            // 
            this.idTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(102, 31);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(292, 26);
            this.idTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(102, 88);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(292, 26);
            this.nameTextBox.TabIndex = 5;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(102, 152);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(292, 26);
            this.priceTextBox.TabIndex = 6;
            // 
            // cashOutBtn
            // 
            this.cashOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashOutBtn.Location = new System.Drawing.Point(284, 266);
            this.cashOutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashOutBtn.Name = "cashOutBtn";
            this.cashOutBtn.Size = new System.Drawing.Size(112, 32);
            this.cashOutBtn.TabIndex = 8;
            this.cashOutBtn.Text = "Cash Out";
            this.cashOutBtn.UseVisualStyleBackColor = true;
            this.cashOutBtn.Click += new System.EventHandler(this.cashOutBtn_Click);
            // 
            // foodInformationPanel
            // 
            this.foodInformationPanel.Controls.Add(this.cashOutTableComboBox);
            this.foodInformationPanel.Controls.Add(this.idLabel);
            this.foodInformationPanel.Controls.Add(this.cashOutBtn);
            this.foodInformationPanel.Controls.Add(this.nameLabel);
            this.foodInformationPanel.Controls.Add(this.priceLabel);
            this.foodInformationPanel.Controls.Add(this.priceTextBox);
            this.foodInformationPanel.Controls.Add(this.idTextBox);
            this.foodInformationPanel.Controls.Add(this.nameTextBox);
            this.foodInformationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.foodInformationPanel.Location = new System.Drawing.Point(0, 326);
            this.foodInformationPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foodInformationPanel.Name = "foodInformationPanel";
            this.foodInformationPanel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.foodInformationPanel.Size = new System.Drawing.Size(450, 432);
            this.foodInformationPanel.TabIndex = 2;
            // 
            // cashOutTableComboBox
            // 
            this.cashOutTableComboBox.FormattingEnabled = true;
            this.cashOutTableComboBox.Items.AddRange(new object[] {
            "Table 1",
            "Table 2"});
            this.cashOutTableComboBox.Location = new System.Drawing.Point(24, 266);
            this.cashOutTableComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashOutTableComboBox.Name = "cashOutTableComboBox";
            this.cashOutTableComboBox.Size = new System.Drawing.Size(248, 28);
            this.cashOutTableComboBox.TabIndex = 10;
            // 
            // foodDetailsPanel
            // 
            this.foodDetailsPanel.Controls.Add(this.foodPictureBox);
            this.foodDetailsPanel.Controls.Add(this.foodInformationPanel);
            this.foodDetailsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.foodDetailsPanel.Location = new System.Drawing.Point(532, 0);
            this.foodDetailsPanel.Name = "foodDetailsPanel";
            this.foodDetailsPanel.Size = new System.Drawing.Size(300, 493);
            this.foodDetailsPanel.TabIndex = 3;
            // 
            // foodManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1248, 758);
            this.Controls.Add(this.foodDetailsPanel);
            this.Controls.Add(this.foodsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "foodManagementForm";
            this.Text = "Food Management";
            this.Load += new System.EventHandler(this.foodManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodPictureBox)).EndInit();
            this.foodInformationPanel.ResumeLayout(false);
            this.foodInformationPanel.PerformLayout();
            this.foodDetailsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView foodsDataGridView;
        private System.Windows.Forms.Button cashOutBtn;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.PictureBox foodPictureBox;
        private System.Windows.Forms.Panel foodInformationPanel;
        private System.Windows.Forms.Panel foodDetailsPanel;
        private System.Windows.Forms.ComboBox cashOutTableComboBox;
    }
}