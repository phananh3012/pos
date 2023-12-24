namespace point_of_sale.Reports
{
    partial class Record
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.topSelling = new System.Windows.Forms.Button();
            this.topCus = new System.Windows.Forms.Button();
            this.purchaseReport = new System.Windows.Forms.Button();
            this.byCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.productLog = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 128);
            this.panel1.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66708F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66708F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66708F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66542F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.byCategory, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.purchaseReport, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.topCus, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.topSelling, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.productLog, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 37);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // topSelling
            // 
            this.topSelling.Location = new System.Drawing.Point(131, 3);
            this.topSelling.Name = "topSelling";
            this.topSelling.Size = new System.Drawing.Size(122, 31);
            this.topSelling.TabIndex = 5;
            this.topSelling.Text = "Top Selling";
            this.topSelling.UseVisualStyleBackColor = true;
            this.topSelling.Click += new System.EventHandler(this.topSelling_Click);
            // 
            // topCus
            // 
            this.topCus.Location = new System.Drawing.Point(259, 3);
            this.topCus.Name = "topCus";
            this.topCus.Size = new System.Drawing.Size(122, 31);
            this.topCus.TabIndex = 6;
            this.topCus.Text = "Top Customer";
            this.topCus.UseVisualStyleBackColor = true;
            this.topCus.Click += new System.EventHandler(this.topCus_Click);
            // 
            // purchaseReport
            // 
            this.purchaseReport.Location = new System.Drawing.Point(515, 3);
            this.purchaseReport.Name = "purchaseReport";
            this.purchaseReport.Size = new System.Drawing.Size(122, 31);
            this.purchaseReport.TabIndex = 8;
            this.purchaseReport.Text = "Vendor Purchase";
            this.purchaseReport.UseVisualStyleBackColor = true;
            this.purchaseReport.Click += new System.EventHandler(this.purchaseReport_Click);
            // 
            // byCategory
            // 
            this.byCategory.Location = new System.Drawing.Point(643, 3);
            this.byCategory.Name = "byCategory";
            this.byCategory.Size = new System.Drawing.Size(127, 31);
            this.byCategory.TabIndex = 7;
            this.byCategory.Text = "Category Sale";
            this.byCategory.UseVisualStyleBackColor = true;
            this.byCategory.Click += new System.EventHandler(this.byCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Records";
            // 
            // controlPanel
            // 
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(0, 128);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(850, 477);
            this.controlPanel.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // productLog
            // 
            this.productLog.Location = new System.Drawing.Point(3, 3);
            this.productLog.Name = "productLog";
            this.productLog.Size = new System.Drawing.Size(122, 31);
            this.productLog.TabIndex = 8;
            this.productLog.Text = "Products Log";
            this.productLog.UseVisualStyleBackColor = true;
            this.productLog.Click += new System.EventHandler(this.productLog_Click);
            // 
            // Record
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(850, 605);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Record";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Record_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button topSelling;
        private System.Windows.Forms.Button topCus;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button byCategory;
        private System.Windows.Forms.Button purchaseReport;
        private System.Windows.Forms.Button productLog;
        private System.Windows.Forms.Button button1;
    }
}