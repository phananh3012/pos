namespace point_of_sale.Reports
{
    partial class TopCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopCustomer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.endDP = new System.Windows.Forms.DateTimePicker();
            this.startDP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.topCustomerGV = new System.Windows.Forms.DataGridView();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCustomerGV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(764, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // endDP
            // 
            this.endDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDP.Location = new System.Drawing.Point(656, 42);
            this.endDP.Name = "endDP";
            this.endDP.Size = new System.Drawing.Size(92, 22);
            this.endDP.TabIndex = 31;
            // 
            // startDP
            // 
            this.startDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDP.Location = new System.Drawing.Point(550, 42);
            this.startDP.Name = "startDP";
            this.startDP.Size = new System.Drawing.Size(92, 22);
            this.startDP.TabIndex = 30;
            this.startDP.ValueChanged += new System.EventHandler(this.startDP_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Filtered By:";
            // 
            // topCustomerGV
            // 
            this.topCustomerGV.AllowUserToAddRows = false;
            this.topCustomerGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.topCustomerGV.BackgroundColor = System.Drawing.Color.White;
            this.topCustomerGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topCustomerGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.customerName,
            this.customerPhone,
            this.customerOrders,
            this.customerTotal});
            this.topCustomerGV.GridColor = System.Drawing.SystemColors.ControlLight;
            this.topCustomerGV.Location = new System.Drawing.Point(61, 92);
            this.topCustomerGV.Name = "topCustomerGV";
            this.topCustomerGV.RowHeadersVisible = false;
            this.topCustomerGV.RowHeadersWidth = 55;
            this.topCustomerGV.RowTemplate.Height = 24;
            this.topCustomerGV.Size = new System.Drawing.Size(728, 344);
            this.topCustomerGV.TabIndex = 28;
            // 
            // customerID
            // 
            this.customerID.FillWeight = 30F;
            this.customerID.HeaderText = "ID";
            this.customerID.MinimumWidth = 6;
            this.customerID.Name = "customerID";
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Name";
            this.customerName.MinimumWidth = 70;
            this.customerName.Name = "customerName";
            // 
            // customerPhone
            // 
            this.customerPhone.HeaderText = "Phone";
            this.customerPhone.MinimumWidth = 25;
            this.customerPhone.Name = "customerPhone";
            // 
            // customerOrders
            // 
            this.customerOrders.HeaderText = "Orders";
            this.customerOrders.MinimumWidth = 6;
            this.customerOrders.Name = "customerOrders";
            // 
            // customerTotal
            // 
            this.customerTotal.FillWeight = 80F;
            this.customerTotal.HeaderText = "Total";
            this.customerTotal.MinimumWidth = 6;
            this.customerTotal.Name = "customerTotal";
            // 
            // TopCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(850, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.endDP);
            this.Controls.Add(this.startDP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.topCustomerGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopCustomer";
            this.Text = "TopCustomer";
            this.Load += new System.EventHandler(this.TopCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCustomerGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker endDP;
        private System.Windows.Forms.DateTimePicker startDP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView topCustomerGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTotal;
    }
}