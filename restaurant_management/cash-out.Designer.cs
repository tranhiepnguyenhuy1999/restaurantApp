
namespace restaurant_management
{
    partial class cashOutForm
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
            this.tablesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableBillDetailsPanel = new System.Windows.Forms.Panel();
            this.totalPriceValueLabel = new System.Windows.Forms.Label();
            this.deleteBillBtn = new System.Windows.Forms.Button();
            this.printBillBtn = new System.Windows.Forms.Button();
            this.nameValueLabel = new System.Windows.Forms.Label();
            this.billDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.tableBillLabel = new System.Windows.Forms.Label();
            this.tablesFlowLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableBillDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billDetailsDataGridView)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablesFlowLayoutPanel
            // 
            this.tablesFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.tablesFlowLayoutPanel.Controls.Add(this.button1);
            this.tablesFlowLayoutPanel.Controls.Add(this.button2);
            this.tablesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablesFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tablesFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablesFlowLayoutPanel.Name = "tablesFlowLayoutPanel";
            this.tablesFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.tablesFlowLayoutPanel.Size = new System.Drawing.Size(669, 732);
            this.tablesFlowLayoutPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 208);
            this.button1.TabIndex = 0;
            this.button1.Text = "Table 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 208);
            this.button2.TabIndex = 1;
            this.button2.Text = "Table 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.tableBillDetailsPanel);
            this.panel1.Controls.Add(this.titlePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(659, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 732);
            this.panel1.TabIndex = 1;
            // 
            // tableBillDetailsPanel
            // 
            this.tableBillDetailsPanel.Controls.Add(this.totalPriceValueLabel);
            this.tableBillDetailsPanel.Controls.Add(this.deleteBillBtn);
            this.tableBillDetailsPanel.Controls.Add(this.printBillBtn);
            this.tableBillDetailsPanel.Controls.Add(this.nameValueLabel);
            this.tableBillDetailsPanel.Controls.Add(this.billDetailsDataGridView);
            this.tableBillDetailsPanel.Controls.Add(this.totalPriceLabel);
            this.tableBillDetailsPanel.Controls.Add(this.detailsLabel);
            this.tableBillDetailsPanel.Controls.Add(this.nameLabel);
            this.tableBillDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBillDetailsPanel.Location = new System.Drawing.Point(0, 85);
            this.tableBillDetailsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableBillDetailsPanel.Name = "tableBillDetailsPanel";
            this.tableBillDetailsPanel.Size = new System.Drawing.Size(580, 647);
            this.tableBillDetailsPanel.TabIndex = 1;
            // 
            // totalPriceValueLabel
            // 
            this.totalPriceValueLabel.AutoSize = true;
            this.totalPriceValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceValueLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.totalPriceValueLabel.Location = new System.Drawing.Point(66, 517);
            this.totalPriceValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalPriceValueLabel.Name = "totalPriceValueLabel";
            this.totalPriceValueLabel.Size = new System.Drawing.Size(91, 25);
            this.totalPriceValueLabel.TabIndex = 7;
            this.totalPriceValueLabel.Text = "unknown";
            // 
            // deleteBillBtn
            // 
            this.deleteBillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBillBtn.Location = new System.Drawing.Point(354, 578);
            this.deleteBillBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteBillBtn.Name = "deleteBillBtn";
            this.deleteBillBtn.Size = new System.Drawing.Size(172, 77);
            this.deleteBillBtn.TabIndex = 6;
            this.deleteBillBtn.Text = "Delete";
            this.deleteBillBtn.UseVisualStyleBackColor = true;
            // 
            // printBillBtn
            // 
            this.printBillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBillBtn.Location = new System.Drawing.Point(54, 578);
            this.printBillBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.printBillBtn.Name = "printBillBtn";
            this.printBillBtn.Size = new System.Drawing.Size(172, 77);
            this.printBillBtn.TabIndex = 5;
            this.printBillBtn.Text = "Print";
            this.printBillBtn.UseVisualStyleBackColor = true;
            // 
            // nameValueLabel
            // 
            this.nameValueLabel.AutoSize = true;
            this.nameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameValueLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nameValueLabel.Location = new System.Drawing.Point(66, 38);
            this.nameValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameValueLabel.Name = "nameValueLabel";
            this.nameValueLabel.Size = new System.Drawing.Size(98, 25);
            this.nameValueLabel.TabIndex = 4;
            this.nameValueLabel.Text = "unknown";
            // 
            // billDetailsDataGridView
            // 
            this.billDetailsDataGridView.AllowUserToAddRows = false;
            this.billDetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billDetailsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.billDetailsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.billDetailsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.billDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDetailsDataGridView.GridColor = System.Drawing.Color.Black;
            this.billDetailsDataGridView.Location = new System.Drawing.Point(54, 103);
            this.billDetailsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.billDetailsDataGridView.MultiSelect = false;
            this.billDetailsDataGridView.Name = "billDetailsDataGridView";
            this.billDetailsDataGridView.RowHeadersVisible = false;
            this.billDetailsDataGridView.RowHeadersWidth = 62;
            this.billDetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billDetailsDataGridView.Size = new System.Drawing.Size(472, 389);
            this.billDetailsDataGridView.TabIndex = 3;
            this.billDetailsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billDetailsDataGridView_CellContentClick);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.totalPriceLabel.Location = new System.Drawing.Point(50, 497);
            this.totalPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(82, 20);
            this.totalPriceLabel.TabIndex = 2;
            this.totalPriceLabel.Text = "Total price";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.detailsLabel.Location = new System.Drawing.Point(50, 78);
            this.detailsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(58, 20);
            this.detailsLabel.TabIndex = 1;
            this.detailsLabel.Text = "Details";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nameLabel.Location = new System.Drawing.Point(50, 18);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.tableBillLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(580, 85);
            this.titlePanel.TabIndex = 0;
            // 
            // tableBillLabel
            // 
            this.tableBillLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableBillLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableBillLabel.Location = new System.Drawing.Point(0, 0);
            this.tableBillLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableBillLabel.Name = "tableBillLabel";
            this.tableBillLabel.Size = new System.Drawing.Size(580, 85);
            this.tableBillLabel.TabIndex = 0;
            this.tableBillLabel.Text = "Table Bill";
            this.tableBillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cashOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1239, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tablesFlowLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1261, 788);
            this.Name = "cashOutForm";
            this.Text = "Cash Out";
            this.Load += new System.EventHandler(this.cashOutForm_Load);
            this.tablesFlowLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableBillDetailsPanel.ResumeLayout(false);
            this.tableBillDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billDetailsDataGridView)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel tablesFlowLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label tableBillLabel;
        private System.Windows.Forms.Panel tableBillDetailsPanel;
        private System.Windows.Forms.Label nameValueLabel;
        private System.Windows.Forms.DataGridView billDetailsDataGridView;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button deleteBillBtn;
        private System.Windows.Forms.Button printBillBtn;
        private System.Windows.Forms.Label totalPriceValueLabel;
    }
}