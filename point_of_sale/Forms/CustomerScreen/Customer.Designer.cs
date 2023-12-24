namespace point_of_sale.CustomerScreen
{
    partial class Customer
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
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newCustomerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerGridView
            // 
            this.customerGridView.AllowUserToAddRows = false;
            this.customerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerGridView.BackgroundColor = System.Drawing.Color.White;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.customerName,
            this.customerPhone,
            this.customerPoint,
            this.userID,
            this.editButton,
            this.deleteButton});
            this.customerGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.customerGridView.Location = new System.Drawing.Point(60, 182);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.RowHeadersVisible = false;
            this.customerGridView.RowHeadersWidth = 55;
            this.customerGridView.RowTemplate.Height = 24;
            this.customerGridView.Size = new System.Drawing.Size(728, 344);
            this.customerGridView.TabIndex = 8;
            this.customerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.newCustomerButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 128);
            this.panel1.TabIndex = 7;
            // 
            // newCustomerButton
            // 
            this.newCustomerButton.Location = new System.Drawing.Point(34, 69);
            this.newCustomerButton.Name = "newCustomerButton";
            this.newCustomerButton.Size = new System.Drawing.Size(93, 40);
            this.newCustomerButton.TabIndex = 5;
            this.newCustomerButton.Text = "New";
            this.newCustomerButton.UseVisualStyleBackColor = true;
            this.newCustomerButton.Click += new System.EventHandler(this.newCustomerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(523, 78);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(265, 22);
            this.searchBar.TabIndex = 2;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
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
            this.customerName.FillWeight = 140F;
            this.customerName.HeaderText = "Name";
            this.customerName.MinimumWidth = 80;
            this.customerName.Name = "customerName";
            // 
            // customerPhone
            // 
            this.customerPhone.HeaderText = "Phone number";
            this.customerPhone.MinimumWidth = 60;
            this.customerPhone.Name = "customerPhone";
            // 
            // customerPoint
            // 
            this.customerPoint.FillWeight = 70F;
            this.customerPoint.HeaderText = "Point";
            this.customerPoint.MinimumWidth = 6;
            this.customerPoint.Name = "customerPoint";
            // 
            // userID
            // 
            this.userID.HeaderText = "User ID";
            this.userID.MinimumWidth = 6;
            this.userID.Name = "userID";
            this.userID.Visible = false;
            // 
            // editButton
            // 
            this.editButton.FillWeight = 50F;
            this.editButton.HeaderText = "Edit";
            this.editButton.MinimumWidth = 7;
            this.editButton.Name = "editButton";
            // 
            // deleteButton
            // 
            this.deleteButton.FillWeight = 50F;
            this.deleteButton.HeaderText = "Delete";
            this.deleteButton.MinimumWidth = 7;
            this.deleteButton.Name = "deleteButton";
            // 
            // Customer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 605);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newCustomerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
    }
}