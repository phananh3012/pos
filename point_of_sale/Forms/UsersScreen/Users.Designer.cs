namespace point_of_sale.UsersScreen
{
    partial class Users
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
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newUserButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersGridView
            // 
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersGridView.BackgroundColor = System.Drawing.Color.White;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userID,
            this.userName,
            this.userPassword,
            this.userType,
            this.editButton,
            this.deleteButton});
            this.usersGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.usersGridView.Location = new System.Drawing.Point(60, 186);
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.RowHeadersVisible = false;
            this.usersGridView.RowHeadersWidth = 55;
            this.usersGridView.RowTemplate.Height = 24;
            this.usersGridView.Size = new System.Drawing.Size(728, 344);
            this.usersGridView.TabIndex = 12;
            this.usersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.newUserButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 128);
            this.panel1.TabIndex = 11;
            // 
            // newUserButton
            // 
            this.newUserButton.Location = new System.Drawing.Point(34, 69);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(93, 40);
            this.newUserButton.TabIndex = 5;
            this.newUserButton.Text = "New";
            this.newUserButton.UseVisualStyleBackColor = true;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Users";
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
            // userID
            // 
            this.userID.FillWeight = 20F;
            this.userID.HeaderText = "ID";
            this.userID.MinimumWidth = 25;
            this.userID.Name = "userID";
            // 
            // userName
            // 
            this.userName.FillWeight = 90F;
            this.userName.HeaderText = "Name";
            this.userName.MinimumWidth = 70;
            this.userName.Name = "userName";
            // 
            // userPassword
            // 
            this.userPassword.HeaderText = "Password";
            this.userPassword.MinimumWidth = 6;
            this.userPassword.Name = "userPassword";
            // 
            // userType
            // 
            this.userType.HeaderText = "Type";
            this.userType.MinimumWidth = 6;
            this.userType.Name = "userType";
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
            // Users
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 605);
            this.Controls.Add(this.usersGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn userType;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
    }
}