namespace point_of_sale.OrderScreen
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.orderGV = new System.Windows.Forms.DataGridView();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordDis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.printButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.endDP = new System.Windows.Forms.DateTimePicker();
            this.startDP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderGV
            // 
            this.orderGV.AllowUserToAddRows = false;
            this.orderGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGV.BackgroundColor = System.Drawing.Color.White;
            this.orderGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.orderDate,
            this.orderTime,
            this.orderEmployee,
            this.orderCustomer,
            this.orderMethod,
            this.ordStatus,
            this.ordSubTotal,
            this.ordDis,
            this.orderTotal,
            this.ordReceived,
            this.ordChange,
            this.detailButton,
            this.printButton});
            this.orderGV.GridColor = System.Drawing.SystemColors.ControlLight;
            this.orderGV.Location = new System.Drawing.Point(60, 195);
            this.orderGV.Name = "orderGV";
            this.orderGV.RowHeadersVisible = false;
            this.orderGV.RowHeadersWidth = 55;
            this.orderGV.RowTemplate.Height = 24;
            this.orderGV.Size = new System.Drawing.Size(728, 344);
            this.orderGV.TabIndex = 12;
            this.orderGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGV_CellClick);
            // 
            // orderID
            // 
            this.orderID.FillWeight = 20F;
            this.orderID.HeaderText = "ID";
            this.orderID.MinimumWidth = 25;
            this.orderID.Name = "orderID";
            // 
            // orderDate
            // 
            this.orderDate.FillWeight = 60F;
            this.orderDate.HeaderText = "Date";
            this.orderDate.MinimumWidth = 70;
            this.orderDate.Name = "orderDate";
            // 
            // orderTime
            // 
            this.orderTime.FillWeight = 50F;
            this.orderTime.HeaderText = "Time";
            this.orderTime.MinimumWidth = 6;
            this.orderTime.Name = "orderTime";
            // 
            // orderEmployee
            // 
            this.orderEmployee.FillWeight = 60F;
            this.orderEmployee.HeaderText = "Employee";
            this.orderEmployee.MinimumWidth = 6;
            this.orderEmployee.Name = "orderEmployee";
            // 
            // orderCustomer
            // 
            this.orderCustomer.FillWeight = 60F;
            this.orderCustomer.HeaderText = "Customer";
            this.orderCustomer.MinimumWidth = 6;
            this.orderCustomer.Name = "orderCustomer";
            // 
            // orderMethod
            // 
            this.orderMethod.FillWeight = 50F;
            this.orderMethod.HeaderText = "Method";
            this.orderMethod.MinimumWidth = 6;
            this.orderMethod.Name = "orderMethod";
            // 
            // ordStatus
            // 
            this.ordStatus.FillWeight = 60F;
            this.ordStatus.HeaderText = "Status";
            this.ordStatus.MinimumWidth = 6;
            this.ordStatus.Name = "ordStatus";
            this.ordStatus.Visible = false;
            // 
            // ordSubTotal
            // 
            this.ordSubTotal.FillWeight = 70F;
            this.ordSubTotal.HeaderText = "Sub Total";
            this.ordSubTotal.MinimumWidth = 6;
            this.ordSubTotal.Name = "ordSubTotal";
            // 
            // ordDis
            // 
            this.ordDis.FillWeight = 60F;
            this.ordDis.HeaderText = "Discount";
            this.ordDis.MinimumWidth = 6;
            this.ordDis.Name = "ordDis";
            // 
            // orderTotal
            // 
            this.orderTotal.FillWeight = 60F;
            this.orderTotal.HeaderText = "Total";
            this.orderTotal.MinimumWidth = 6;
            this.orderTotal.Name = "orderTotal";
            // 
            // ordReceived
            // 
            this.ordReceived.HeaderText = "Received";
            this.ordReceived.MinimumWidth = 6;
            this.ordReceived.Name = "ordReceived";
            this.ordReceived.Visible = false;
            // 
            // ordChange
            // 
            this.ordChange.HeaderText = "Change";
            this.ordChange.MinimumWidth = 6;
            this.ordChange.Name = "ordChange";
            this.ordChange.Visible = false;
            // 
            // detailButton
            // 
            this.detailButton.FillWeight = 40F;
            this.detailButton.HeaderText = "Detail";
            this.detailButton.MinimumWidth = 6;
            this.detailButton.Name = "detailButton";
            // 
            // printButton
            // 
            this.printButton.FillWeight = 40F;
            this.printButton.HeaderText = "Print";
            this.printButton.MinimumWidth = 6;
            this.printButton.Name = "printButton";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 128);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(35, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(523, 78);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(265, 20);
            this.searchBar.TabIndex = 2;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(763, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // endDP
            // 
            this.endDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDP.Location = new System.Drawing.Point(655, 153);
            this.endDP.Name = "endDP";
            this.endDP.Size = new System.Drawing.Size(92, 20);
            this.endDP.TabIndex = 22;
            // 
            // startDP
            // 
            this.startDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDP.Location = new System.Drawing.Point(549, 153);
            this.startDP.Name = "startDP";
            this.startDP.Size = new System.Drawing.Size(92, 20);
            this.startDP.TabIndex = 21;
            this.startDP.ValueChanged += new System.EventHandler(this.startDP_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Filtered By:";
            // 
            // Order
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 605);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.endDP);
            this.Controls.Add(this.startDP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordDis;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordChange;
        private System.Windows.Forms.DataGridViewButtonColumn detailButton;
        private System.Windows.Forms.DataGridViewButtonColumn printButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker endDP;
        private System.Windows.Forms.DateTimePicker startDP;
        private System.Windows.Forms.Label label3;
    }
}