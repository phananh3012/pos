namespace point_of_sale.VendorScreen
{
    partial class VendorList
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
            this.newButton = new System.Windows.Forms.Button();
            this.vpGridView = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vpGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(36, 106);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(82, 25);
            this.newButton.TabIndex = 2;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // vpGridView
            // 
            this.vpGridView.AllowUserToAddRows = false;
            this.vpGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vpGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.vpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vpGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.vendorID,
            this.productName,
            this.productCost,
            this.productUnit,
            this.editButton,
            this.deleteButton});
            this.vpGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.vpGridView.Location = new System.Drawing.Point(36, 146);
            this.vpGridView.Name = "vpGridView";
            this.vpGridView.RowHeadersVisible = false;
            this.vpGridView.RowHeadersWidth = 55;
            this.vpGridView.RowTemplate.Height = 24;
            this.vpGridView.Size = new System.Drawing.Size(665, 285);
            this.vpGridView.TabIndex = 16;
            this.vpGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vpGridView_CellClick);
            // 
            // productID
            // 
            this.productID.FillWeight = 20F;
            this.productID.HeaderText = "ID";
            this.productID.MinimumWidth = 25;
            this.productID.Name = "productID";
            // 
            // vendorID
            // 
            this.vendorID.HeaderText = "Vendor";
            this.vendorID.MinimumWidth = 6;
            this.vendorID.Name = "vendorID";
            this.vendorID.Visible = false;
            // 
            // productName
            // 
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            // 
            // productCost
            // 
            this.productCost.FillWeight = 80F;
            this.productCost.HeaderText = "Cost";
            this.productCost.MinimumWidth = 6;
            this.productCost.Name = "productCost";
            // 
            // productUnit
            // 
            this.productUnit.FillWeight = 50F;
            this.productUnit.HeaderText = "Unit";
            this.productUnit.MinimumWidth = 6;
            this.productUnit.Name = "productUnit";
            // 
            // editButton
            // 
            this.editButton.FillWeight = 35F;
            this.editButton.HeaderText = "Edit";
            this.editButton.MinimumWidth = 6;
            this.editButton.Name = "editButton";
            this.editButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // deleteButton
            // 
            this.deleteButton.FillWeight = 35F;
            this.deleteButton.HeaderText = "Delete";
            this.deleteButton.MinimumWidth = 6;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 87);
            this.panel1.TabIndex = 15;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(681, 29);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search";
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(435, 117);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(265, 22);
            this.searchBar.TabIndex = 10;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(124, 106);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(82, 25);
            this.uploadBtn.TabIndex = 17;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // VendorList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(741, 459);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.vpGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VendorList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendorList";
            this.Load += new System.EventHandler(this.VendorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vpGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.DataGridView vpGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUnit;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
        private System.Windows.Forms.Button uploadBtn;
    }
}