namespace point_of_sale.Reports
{
    partial class TopSelling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopSelling));
            this.topSellingGV = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.endDP = new System.Windows.Forms.DateTimePicker();
            this.startDP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.topSellingGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topSellingGV
            // 
            this.topSellingGV.AllowUserToAddRows = false;
            this.topSellingGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.topSellingGV.BackgroundColor = System.Drawing.Color.White;
            this.topSellingGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topSellingGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productBrand,
            this.productQty});
            this.topSellingGV.GridColor = System.Drawing.SystemColors.ControlLight;
            this.topSellingGV.Location = new System.Drawing.Point(63, 78);
            this.topSellingGV.Name = "topSellingGV";
            this.topSellingGV.RowHeadersVisible = false;
            this.topSellingGV.RowHeadersWidth = 55;
            this.topSellingGV.RowTemplate.Height = 24;
            this.topSellingGV.Size = new System.Drawing.Size(728, 344);
            this.topSellingGV.TabIndex = 13;
            // 
            // productID
            // 
            this.productID.FillWeight = 20F;
            this.productID.HeaderText = "ID";
            this.productID.MinimumWidth = 25;
            this.productID.Name = "productID";
            // 
            // productName
            // 
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 70;
            this.productName.Name = "productName";
            // 
            // productBrand
            // 
            this.productBrand.HeaderText = "Brand";
            this.productBrand.MinimumWidth = 6;
            this.productBrand.Name = "productBrand";
            // 
            // productQty
            // 
            this.productQty.FillWeight = 80F;
            this.productQty.HeaderText = "Quantity";
            this.productQty.MinimumWidth = 6;
            this.productQty.Name = "productQty";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(766, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // endDP
            // 
            this.endDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDP.Location = new System.Drawing.Point(658, 28);
            this.endDP.Name = "endDP";
            this.endDP.Size = new System.Drawing.Size(92, 22);
            this.endDP.TabIndex = 26;
            // 
            // startDP
            // 
            this.startDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDP.Location = new System.Drawing.Point(552, 28);
            this.startDP.Name = "startDP";
            this.startDP.Size = new System.Drawing.Size(92, 22);
            this.startDP.TabIndex = 25;
            this.startDP.ValueChanged += new System.EventHandler(this.startDP_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Filtered By:";
            // 
            // TopSelling
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(850, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.endDP);
            this.Controls.Add(this.startDP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.topSellingGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopSelling";
            this.Text = "TopSelling";
            this.Load += new System.EventHandler(this.TopSelling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topSellingGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView topSellingGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQty;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker endDP;
        private System.Windows.Forms.DateTimePicker startDP;
        private System.Windows.Forms.Label label3;
    }
}