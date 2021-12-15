
namespace restaurant_management
{
    partial class foodType_popupF
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
            this.typesDataGridView = new System.Windows.Forms.DataGridView();
            this.foodInformationPanel = new System.Windows.Forms.Panel();
            this.toAgeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fromAgeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toAgeLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.fromAgeLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.typesDataGridView)).BeginInit();
            this.foodInformationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toAgeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromAgeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // typesDataGridView
            // 
            this.typesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.typesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.typesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typesDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.typesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.typesDataGridView.MultiSelect = false;
            this.typesDataGridView.Name = "typesDataGridView";
            this.typesDataGridView.ReadOnly = true;
            this.typesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.typesDataGridView.Size = new System.Drawing.Size(473, 175);
            this.typesDataGridView.TabIndex = 0;
            // 
            // foodInformationPanel
            // 
            this.foodInformationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.foodInformationPanel.Controls.Add(this.toAgeNumericUpDown);
            this.foodInformationPanel.Controls.Add(this.fromAgeNumericUpDown);
            this.foodInformationPanel.Controls.Add(this.toAgeLabel);
            this.foodInformationPanel.Controls.Add(this.addBtn);
            this.foodInformationPanel.Controls.Add(this.cancelBtn);
            this.foodInformationPanel.Controls.Add(this.nameLabel);
            this.foodInformationPanel.Controls.Add(this.fromAgeLabel);
            this.foodInformationPanel.Controls.Add(this.nameTextBox);
            this.foodInformationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.foodInformationPanel.Location = new System.Drawing.Point(0, 172);
            this.foodInformationPanel.Name = "foodInformationPanel";
            this.foodInformationPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.foodInformationPanel.Size = new System.Drawing.Size(473, 182);
            this.foodInformationPanel.TabIndex = 4;
            // 
            // toAgeNumericUpDown
            // 
            this.toAgeNumericUpDown.Location = new System.Drawing.Point(153, 130);
            this.toAgeNumericUpDown.Name = "toAgeNumericUpDown";
            this.toAgeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.toAgeNumericUpDown.TabIndex = 14;
            // 
            // fromAgeNumericUpDown
            // 
            this.fromAgeNumericUpDown.Location = new System.Drawing.Point(153, 78);
            this.fromAgeNumericUpDown.Name = "fromAgeNumericUpDown";
            this.fromAgeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.fromAgeNumericUpDown.TabIndex = 13;
            // 
            // toAgeLabel
            // 
            this.toAgeLabel.AutoSize = true;
            this.toAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAgeLabel.ForeColor = System.Drawing.Color.White;
            this.toAgeLabel.Location = new System.Drawing.Point(48, 130);
            this.toAgeLabel.Name = "toAgeLabel";
            this.toAgeLabel.Size = new System.Drawing.Size(59, 16);
            this.toAgeLabel.TabIndex = 12;
            this.toAgeLabel.Text = "To Age";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(340, 28);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 50);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(340, 100);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 50);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(48, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 16);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // fromAgeLabel
            // 
            this.fromAgeLabel.AutoSize = true;
            this.fromAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromAgeLabel.ForeColor = System.Drawing.Color.White;
            this.fromAgeLabel.Location = new System.Drawing.Point(48, 78);
            this.fromAgeLabel.Name = "fromAgeLabel";
            this.fromAgeLabel.Size = new System.Drawing.Size(75, 16);
            this.fromAgeLabel.TabIndex = 3;
            this.fromAgeLabel.Text = "From Age";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.Location = new System.Drawing.Point(153, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(120, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // foodType_popupF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(473, 354);
            this.ControlBox = false;
            this.Controls.Add(this.foodInformationPanel);
            this.Controls.Add(this.typesDataGridView);
            this.MaximumSize = new System.Drawing.Size(489, 393);
            this.MinimumSize = new System.Drawing.Size(489, 393);
            this.Name = "foodType_popupF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Type";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.foodType_popupF_FormClosed);
            this.Load += new System.EventHandler(this.foodType_popupF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typesDataGridView)).EndInit();
            this.foodInformationPanel.ResumeLayout(false);
            this.foodInformationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toAgeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromAgeNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView typesDataGridView;
        private System.Windows.Forms.Panel foodInformationPanel;
        private System.Windows.Forms.NumericUpDown toAgeNumericUpDown;
        private System.Windows.Forms.NumericUpDown fromAgeNumericUpDown;
        private System.Windows.Forms.Label toAgeLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label fromAgeLabel;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}