namespace point_of_sale.PurchaseScreen
{
    partial class Purchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase));
            this.purchaseGV = new System.Windows.Forms.DataGridView();
            this.purchaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.paidButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.doneButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.allButton = new System.Windows.Forms.Button();
            this.paidBtn = new System.Windows.Forms.Button();
            this.requestBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.startDP = new System.Windows.Forms.DateTimePicker();
            this.endDP = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseGV
            // 
            this.purchaseGV.AllowUserToAddRows = false;
            this.purchaseGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchaseGV.BackgroundColor = System.Drawing.Color.White;
            this.purchaseGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseID,
            this.purchaseDate,
            this.purchaseTime,
            this.vendorID,
            this.vendorName,
            this.purchaseEmployee,
            this.purchaseStatus,
            this.purchaseTotal,
            this.detailButton,
            this.paidButton,
            this.doneButton});
            this.purchaseGV.GridColor = System.Drawing.SystemColors.ControlLight;
            this.purchaseGV.Location = new System.Drawing.Point(60, 195);
            this.purchaseGV.Name = "purchaseGV";
            this.purchaseGV.RowHeadersVisible = false;
            this.purchaseGV.RowHeadersWidth = 55;
            this.purchaseGV.RowTemplate.Height = 24;
            this.purchaseGV.Size = new System.Drawing.Size(728, 344);
            this.purchaseGV.TabIndex = 14;
            this.purchaseGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseGV_CellClick);
            // 
            // purchaseID
            // 
            this.purchaseID.FillWeight = 20F;
            this.purchaseID.HeaderText = "ID";
            this.purchaseID.MinimumWidth = 25;
            this.purchaseID.Name = "purchaseID";
            // 
            // purchaseDate
            // 
            this.purchaseDate.FillWeight = 60F;
            this.purchaseDate.HeaderText = "Date";
            this.purchaseDate.MinimumWidth = 70;
            this.purchaseDate.Name = "purchaseDate";
            // 
            // purchaseTime
            // 
            this.purchaseTime.FillWeight = 80F;
            this.purchaseTime.HeaderText = "Time";
            this.purchaseTime.MinimumWidth = 6;
            this.purchaseTime.Name = "purchaseTime";
            // 
            // vendorID
            // 
            this.vendorID.HeaderText = "Vendor ID";
            this.vendorID.MinimumWidth = 6;
            this.vendorID.Name = "vendorID";
            this.vendorID.Visible = false;
            // 
            // vendorName
            // 
            this.vendorName.HeaderText = "Vendor";
            this.vendorName.MinimumWidth = 6;
            this.vendorName.Name = "vendorName";
            // 
            // purchaseEmployee
            // 
            this.purchaseEmployee.FillWeight = 80F;
            this.purchaseEmployee.HeaderText = "Employee";
            this.purchaseEmployee.MinimumWidth = 6;
            this.purchaseEmployee.Name = "purchaseEmployee";
            // 
            // purchaseStatus
            // 
            this.purchaseStatus.FillWeight = 80F;
            this.purchaseStatus.HeaderText = "Status";
            this.purchaseStatus.MinimumWidth = 6;
            this.purchaseStatus.Name = "purchaseStatus";
            // 
            // purchaseTotal
            // 
            this.purchaseTotal.HeaderText = "Total";
            this.purchaseTotal.MinimumWidth = 6;
            this.purchaseTotal.Name = "purchaseTotal";
            // 
            // detailButton
            // 
            this.detailButton.FillWeight = 35F;
            this.detailButton.HeaderText = "Detail";
            this.detailButton.MinimumWidth = 6;
            this.detailButton.Name = "detailButton";
            this.detailButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.detailButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // paidButton
            // 
            this.paidButton.FillWeight = 35F;
            this.paidButton.HeaderText = "Paid";
            this.paidButton.MinimumWidth = 6;
            this.paidButton.Name = "paidButton";
            // 
            // doneButton
            // 
            this.doneButton.FillWeight = 35F;
            this.doneButton.HeaderText = "Done";
            this.doneButton.MinimumWidth = 6;
            this.doneButton.Name = "doneButton";
            this.doneButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.doneButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.newButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 128);
            this.panel1.TabIndex = 13;
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.newButton.Location = new System.Drawing.Point(34, 68);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(128, 40);
            this.newButton.TabIndex = 15;
            this.newButton.Text = "Make Purchase";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Purchases";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.allButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.paidBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.requestBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.doneBtn, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(60, 162);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(357, 31);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(3, 3);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(82, 25);
            this.allButton.TabIndex = 2;
            this.allButton.Text = "All";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // paidBtn
            // 
            this.paidBtn.Location = new System.Drawing.Point(181, 3);
            this.paidBtn.Name = "paidBtn";
            this.paidBtn.Size = new System.Drawing.Size(83, 25);
            this.paidBtn.TabIndex = 1;
            this.paidBtn.Text = "Paid";
            this.paidBtn.UseVisualStyleBackColor = true;
            this.paidBtn.Click += new System.EventHandler(this.paidBtn_Click);
            // 
            // requestBtn
            // 
            this.requestBtn.Location = new System.Drawing.Point(92, 3);
            this.requestBtn.Name = "requestBtn";
            this.requestBtn.Size = new System.Drawing.Size(82, 25);
            this.requestBtn.TabIndex = 0;
            this.requestBtn.Text = "Requested";
            this.requestBtn.UseVisualStyleBackColor = true;
            this.requestBtn.Click += new System.EventHandler(this.requestBtn_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(270, 3);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(83, 25);
            this.doneBtn.TabIndex = 3;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Location = new System.Drawing.Point(463, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Filtered By:";
            // 
            // startDP
            // 
            this.startDP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDP.Location = new System.Drawing.Point(549, 155);
            this.startDP.Name = "startDP";
            this.startDP.Size = new System.Drawing.Size(92, 20);
            this.startDP.TabIndex = 17;
            this.startDP.ValueChanged += new System.EventHandler(this.startDP_ValueChanged);
            // 
            // endDP
            // 
            this.endDP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDP.Location = new System.Drawing.Point(655, 155);
            this.endDP.Name = "endDP";
            this.endDP.Size = new System.Drawing.Size(92, 20);
            this.endDP.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(763, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Purchase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 605);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.endDP);
            this.Controls.Add(this.startDP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.purchaseGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView purchaseGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Button paidBtn;
        private System.Windows.Forms.Button requestBtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseTotal;
        private System.Windows.Forms.DataGridViewButtonColumn detailButton;
        private System.Windows.Forms.DataGridViewButtonColumn paidButton;
        private System.Windows.Forms.DataGridViewButtonColumn doneButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startDP;
        private System.Windows.Forms.DateTimePicker endDP;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}