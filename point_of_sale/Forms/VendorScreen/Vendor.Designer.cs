namespace point_of_sale.VendorScreen
{
    partial class Vendor
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
            this.vendorGridView = new System.Windows.Forms.DataGridView();
            this.vendorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newVendorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vendorGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vendorGridView
            // 
            this.vendorGridView.AllowUserToAddRows = false;
            this.vendorGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vendorGridView.BackgroundColor = System.Drawing.Color.White;
            this.vendorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorID,
            this.vendorName,
            this.vendorPhone,
            this.vendorEmail,
            this.vendorAddress,
            this.listButton,
            this.editButton,
            this.deleteButton});
            this.vendorGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.vendorGridView.Location = new System.Drawing.Point(60, 185);
            this.vendorGridView.Name = "vendorGridView";
            this.vendorGridView.RowHeadersVisible = false;
            this.vendorGridView.RowHeadersWidth = 55;
            this.vendorGridView.RowTemplate.Height = 24;
            this.vendorGridView.Size = new System.Drawing.Size(728, 344);
            this.vendorGridView.TabIndex = 14;
            this.vendorGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendorGridView_CellClick);
            // 
            // vendorID
            // 
            this.vendorID.FillWeight = 20F;
            this.vendorID.HeaderText = "ID";
            this.vendorID.MinimumWidth = 25;
            this.vendorID.Name = "vendorID";
            // 
            // vendorName
            // 
            this.vendorName.FillWeight = 90F;
            this.vendorName.HeaderText = "Name";
            this.vendorName.MinimumWidth = 70;
            this.vendorName.Name = "vendorName";
            // 
            // vendorPhone
            // 
            this.vendorPhone.FillWeight = 80F;
            this.vendorPhone.HeaderText = "Phone";
            this.vendorPhone.MinimumWidth = 6;
            this.vendorPhone.Name = "vendorPhone";
            // 
            // vendorEmail
            // 
            this.vendorEmail.FillWeight = 80F;
            this.vendorEmail.HeaderText = "Email";
            this.vendorEmail.MinimumWidth = 6;
            this.vendorEmail.Name = "vendorEmail";
            // 
            // vendorAddress
            // 
            this.vendorAddress.FillWeight = 80F;
            this.vendorAddress.HeaderText = "Address";
            this.vendorAddress.MinimumWidth = 6;
            this.vendorAddress.Name = "vendorAddress";
            // 
            // listButton
            // 
            this.listButton.FillWeight = 60F;
            this.listButton.HeaderText = "Product List";
            this.listButton.MinimumWidth = 6;
            this.listButton.Name = "listButton";
            // 
            // editButton
            // 
            this.editButton.FillWeight = 35F;
            this.editButton.HeaderText = "Edit";
            this.editButton.MinimumWidth = 6;
            this.editButton.Name = "editButton";
            // 
            // deleteButton
            // 
            this.deleteButton.FillWeight = 35F;
            this.deleteButton.HeaderText = "Delete";
            this.deleteButton.MinimumWidth = 6;
            this.deleteButton.Name = "deleteButton";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.newVendorButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 128);
            this.panel1.TabIndex = 13;
            // 
            // newVendorButton
            // 
            this.newVendorButton.Location = new System.Drawing.Point(34, 69);
            this.newVendorButton.Name = "newVendorButton";
            this.newVendorButton.Size = new System.Drawing.Size(93, 40);
            this.newVendorButton.TabIndex = 5;
            this.newVendorButton.Text = "New";
            this.newVendorButton.UseVisualStyleBackColor = true;
            this.newVendorButton.Click += new System.EventHandler(this.newVendorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vendors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
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
            // Vendor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 605);
            this.Controls.Add(this.vendorGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vendor";
            this.Text = "Vendor";
            this.Load += new System.EventHandler(this.Vendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vendorGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newVendorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorAddress;
        private System.Windows.Forms.DataGridViewButtonColumn listButton;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
    }
}