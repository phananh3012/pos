namespace point_of_sale
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.viewMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.vendorButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.saleBtn = new System.Windows.Forms.Button();
            this.topHeader = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.viewMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewMenu
            // 
            this.viewMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.viewMenu.Controls.Add(this.pictureBox1);
            this.viewMenu.Controls.Add(this.purchaseButton);
            this.viewMenu.Controls.Add(this.vendorButton);
            this.viewMenu.Controls.Add(this.orderButton);
            this.viewMenu.Controls.Add(this.usersButton);
            this.viewMenu.Controls.Add(this.categoryButton);
            this.viewMenu.Controls.Add(this.productsButton);
            this.viewMenu.Controls.Add(this.reportsButton);
            this.viewMenu.Controls.Add(this.employeeButton);
            this.viewMenu.Controls.Add(this.customerButton);
            this.viewMenu.Controls.Add(this.saleBtn);
            this.viewMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.viewMenu.Location = new System.Drawing.Point(0, 43);
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(336, 626);
            this.viewMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, -43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // purchaseButton
            // 
            this.purchaseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.purchaseButton.Location = new System.Drawing.Point(29, 223);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(130, 49);
            this.purchaseButton.TabIndex = 14;
            this.purchaseButton.Text = "Purchases";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // vendorButton
            // 
            this.vendorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vendorButton.Location = new System.Drawing.Point(29, 392);
            this.vendorButton.Name = "vendorButton";
            this.vendorButton.Size = new System.Drawing.Size(130, 49);
            this.vendorButton.TabIndex = 13;
            this.vendorButton.Text = "Vendor";
            this.vendorButton.UseVisualStyleBackColor = true;
            this.vendorButton.Click += new System.EventHandler(this.vendorButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.orderButton.Location = new System.Drawing.Point(184, 223);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(130, 49);
            this.orderButton.TabIndex = 11;
            this.orderButton.Text = "Orders";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usersButton.Location = new System.Drawing.Point(29, 474);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(130, 49);
            this.usersButton.TabIndex = 10;
            this.usersButton.Text = "Users";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryButton.Location = new System.Drawing.Point(184, 474);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(130, 49);
            this.categoryButton.TabIndex = 8;
            this.categoryButton.Text = "Categories";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // productsButton
            // 
            this.productsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productsButton.Location = new System.Drawing.Point(184, 137);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(130, 49);
            this.productsButton.TabIndex = 7;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reportsButton.Location = new System.Drawing.Point(184, 392);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(130, 49);
            this.reportsButton.TabIndex = 5;
            this.reportsButton.Text = "Records";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employeeButton.Location = new System.Drawing.Point(184, 308);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(130, 49);
            this.employeeButton.TabIndex = 4;
            this.employeeButton.Text = "Employees";
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerButton.Location = new System.Drawing.Point(29, 308);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(130, 49);
            this.customerButton.TabIndex = 3;
            this.customerButton.Text = "Customers";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // saleBtn
            // 
            this.saleBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saleBtn.Location = new System.Drawing.Point(29, 137);
            this.saleBtn.Name = "saleBtn";
            this.saleBtn.Size = new System.Drawing.Size(130, 49);
            this.saleBtn.TabIndex = 1;
            this.saleBtn.Text = "Sales";
            this.saleBtn.UseVisualStyleBackColor = true;
            this.saleBtn.Click += new System.EventHandler(this.saleBtn_Click);
            // 
            // topHeader
            // 
            this.topHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.topHeader.Controls.Add(this.logOutButton);
            this.topHeader.Controls.Add(this.usernameLabel);
            this.topHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.topHeader.Location = new System.Drawing.Point(0, 0);
            this.topHeader.Name = "topHeader";
            this.topHeader.Size = new System.Drawing.Size(1186, 43);
            this.topHeader.TabIndex = 1;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(1090, 4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 36);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(974, 12);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(83, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "username";
            // 
            // controlPanel
            // 
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(336, 43);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(850, 626);
            this.controlPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1186, 669);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.viewMenu);
            this.Controls.Add(this.topHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.viewMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topHeader.ResumeLayout(false);
            this.topHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewMenu;
        private System.Windows.Forms.Button saleBtn;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Panel topHeader;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button vendorButton;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}