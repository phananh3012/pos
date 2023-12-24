namespace point_of_sale.Records
{
    partial class ProductLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductLog));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.endDP = new System.Windows.Forms.DateTimePicker();
            this.startDP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.logGV = new System.Windows.Forms.DataGridView();
            this.logID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveredQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logGV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(764, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // endDP
            // 
            this.endDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDP.Location = new System.Drawing.Point(656, 31);
            this.endDP.Name = "endDP";
            this.endDP.Size = new System.Drawing.Size(92, 22);
            this.endDP.TabIndex = 36;
            // 
            // startDP
            // 
            this.startDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDP.Location = new System.Drawing.Point(550, 31);
            this.startDP.Name = "startDP";
            this.startDP.Size = new System.Drawing.Size(92, 22);
            this.startDP.TabIndex = 35;
            this.startDP.ValueChanged += new System.EventHandler(this.startDP_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Filtered By:";
            // 
            // logGV
            // 
            this.logGV.AllowUserToAddRows = false;
            this.logGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.logGV.BackgroundColor = System.Drawing.Color.White;
            this.logGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logID,
            this.productID,
            this.logDate,
            this.logTime,
            this.productName,
            this.startQty,
            this.deliveredQty,
            this.receivedQty,
            this.endQty,
            this.actorID});
            this.logGV.GridColor = System.Drawing.SystemColors.ControlLight;
            this.logGV.Location = new System.Drawing.Point(61, 81);
            this.logGV.Name = "logGV";
            this.logGV.RowHeadersVisible = false;
            this.logGV.RowHeadersWidth = 55;
            this.logGV.RowTemplate.Height = 24;
            this.logGV.Size = new System.Drawing.Size(728, 344);
            this.logGV.TabIndex = 33;
            // 
            // logID
            // 
            this.logID.FillWeight = 30F;
            this.logID.HeaderText = "ID";
            this.logID.MinimumWidth = 6;
            this.logID.Name = "logID";
            // 
            // productID
            // 
            this.productID.HeaderText = "Product ID";
            this.productID.MinimumWidth = 6;
            this.productID.Name = "productID";
            this.productID.Visible = false;
            // 
            // logDate
            // 
            this.logDate.FillWeight = 60F;
            this.logDate.HeaderText = "Date";
            this.logDate.MinimumWidth = 6;
            this.logDate.Name = "logDate";
            // 
            // logTime
            // 
            this.logTime.FillWeight = 60F;
            this.logTime.HeaderText = "Time";
            this.logTime.MinimumWidth = 6;
            this.logTime.Name = "logTime";
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            // 
            // startQty
            // 
            this.startQty.FillWeight = 60F;
            this.startQty.HeaderText = "Start Qty";
            this.startQty.MinimumWidth = 6;
            this.startQty.Name = "startQty";
            // 
            // deliveredQty
            // 
            this.deliveredQty.FillWeight = 60F;
            this.deliveredQty.HeaderText = "Delivered";
            this.deliveredQty.MinimumWidth = 6;
            this.deliveredQty.Name = "deliveredQty";
            // 
            // receivedQty
            // 
            this.receivedQty.FillWeight = 60F;
            this.receivedQty.HeaderText = "Received";
            this.receivedQty.MinimumWidth = 6;
            this.receivedQty.Name = "receivedQty";
            // 
            // endQty
            // 
            this.endQty.FillWeight = 60F;
            this.endQty.HeaderText = "End Qty";
            this.endQty.MinimumWidth = 6;
            this.endQty.Name = "endQty";
            // 
            // actorID
            // 
            this.actorID.FillWeight = 30F;
            this.actorID.HeaderText = "Actor";
            this.actorID.MinimumWidth = 6;
            this.actorID.Name = "actorID";
            // 
            // ProductLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(850, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.endDP);
            this.Controls.Add(this.startDP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductLog";
            this.Text = "ProductLog";
            this.Load += new System.EventHandler(this.ProductLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker endDP;
        private System.Windows.Forms.DateTimePicker startDP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView logGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn logID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveredQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn endQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorID;
    }
}