namespace point_of_sale
{
    partial class Category
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
            this.newCategoryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryGridView = new System.Windows.Forms.DataGridView();
            this.categoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // newCategoryButton
            // 
            this.newCategoryButton.BackColor = System.Drawing.SystemColors.Control;
            this.newCategoryButton.Location = new System.Drawing.Point(34, 69);
            this.newCategoryButton.Name = "newCategoryButton";
            this.newCategoryButton.Size = new System.Drawing.Size(93, 40);
            this.newCategoryButton.TabIndex = 0;
            this.newCategoryButton.Text = "New";
            this.newCategoryButton.UseVisualStyleBackColor = false;
            this.newCategoryButton.Click += new System.EventHandler(this.newCategoryButton_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 128);
            this.panel1.TabIndex = 4;
            // 
            // categoryGridView
            // 
            this.categoryGridView.AllowUserToAddRows = false;
            this.categoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryGridView.BackgroundColor = System.Drawing.Color.White;
            this.categoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryID,
            this.categoryName,
            this.editButton,
            this.deleteButton});
            this.categoryGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.categoryGridView.Location = new System.Drawing.Point(60, 182);
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.RowHeadersVisible = false;
            this.categoryGridView.RowHeadersWidth = 55;
            this.categoryGridView.RowTemplate.Height = 24;
            this.categoryGridView.Size = new System.Drawing.Size(728, 344);
            this.categoryGridView.TabIndex = 5;
            this.categoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryGridView_CellClick);
            // 
            // categoryID
            // 
            this.categoryID.FillWeight = 20F;
            this.categoryID.HeaderText = "ID";
            this.categoryID.MinimumWidth = 40;
            this.categoryID.Name = "categoryID";
            // 
            // categoryName
            // 
            this.categoryName.FillWeight = 300F;
            this.categoryName.HeaderText = "Name";
            this.categoryName.MinimumWidth = 200;
            this.categoryName.Name = "categoryName";
            // 
            // editButton
            // 
            this.editButton.FillWeight = 30F;
            this.editButton.HeaderText = "Edit";
            this.editButton.MinimumWidth = 6;
            this.editButton.Name = "editButton";
            // 
            // deleteButton
            // 
            this.deleteButton.FillWeight = 30F;
            this.deleteButton.HeaderText = "Delete";
            this.deleteButton.MinimumWidth = 7;
            this.deleteButton.Name = "deleteButton";
            // 
            // Category
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 605);
            this.Controls.Add(this.categoryGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newCategoryButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newCategoryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView categoryGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
    }
}