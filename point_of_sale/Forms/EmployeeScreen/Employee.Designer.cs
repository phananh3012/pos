namespace point_of_sale.EmployeeScreen
{
    partial class Employee
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
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newEmployeeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeGridView
            // 
            this.employeeGridView.AllowUserToAddRows = false;
            this.employeeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeGridView.BackgroundColor = System.Drawing.Color.White;
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeID,
            this.employeeName,
            this.employeePosition,
            this.employeePhone,
            this.employeeEmail,
            this.userID,
            this.editButton,
            this.deleteButton});
            this.employeeGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.employeeGridView.Location = new System.Drawing.Point(60, 195);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.RowHeadersVisible = false;
            this.employeeGridView.RowHeadersWidth = 55;
            this.employeeGridView.RowTemplate.Height = 24;
            this.employeeGridView.Size = new System.Drawing.Size(728, 344);
            this.employeeGridView.TabIndex = 10;
            this.employeeGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.newEmployeeButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 128);
            this.panel1.TabIndex = 9;
            // 
            // newEmployeeButton
            // 
            this.newEmployeeButton.Location = new System.Drawing.Point(34, 69);
            this.newEmployeeButton.Name = "newEmployeeButton";
            this.newEmployeeButton.Size = new System.Drawing.Size(93, 40);
            this.newEmployeeButton.TabIndex = 5;
            this.newEmployeeButton.Text = "New";
            this.newEmployeeButton.UseVisualStyleBackColor = true;
            this.newEmployeeButton.Click += new System.EventHandler(this.newEmployeeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employees";
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
            // employeeID
            // 
            this.employeeID.FillWeight = 20F;
            this.employeeID.HeaderText = "ID";
            this.employeeID.MinimumWidth = 25;
            this.employeeID.Name = "employeeID";
            // 
            // employeeName
            // 
            this.employeeName.FillWeight = 90F;
            this.employeeName.HeaderText = "Name";
            this.employeeName.MinimumWidth = 70;
            this.employeeName.Name = "employeeName";
            // 
            // employeePosition
            // 
            this.employeePosition.FillWeight = 80F;
            this.employeePosition.HeaderText = "Position";
            this.employeePosition.MinimumWidth = 6;
            this.employeePosition.Name = "employeePosition";
            // 
            // employeePhone
            // 
            this.employeePhone.FillWeight = 80F;
            this.employeePhone.HeaderText = "Phone number";
            this.employeePhone.MinimumWidth = 6;
            this.employeePhone.Name = "employeePhone";
            // 
            // employeeEmail
            // 
            this.employeeEmail.FillWeight = 80F;
            this.employeeEmail.HeaderText = "Email";
            this.employeeEmail.MinimumWidth = 6;
            this.employeeEmail.Name = "employeeEmail";
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
            // Employee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 605);
            this.Controls.Add(this.employeeGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newEmployeeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
    }
}