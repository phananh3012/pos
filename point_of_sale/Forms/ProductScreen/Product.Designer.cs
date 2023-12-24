namespace point_of_sale.ProductScreen
{
    partial class Product
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
            this.productGV = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.categoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productGV
            // 
            this.productGV.AllowUserToAddRows = false;
            this.productGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productGV.BackgroundColor = System.Drawing.Color.White;
            this.productGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productBrand,
            this.productCategory,
            this.productPrice,
            this.productQty,
            this.productUnit,
            this.productBarcode,
            this.barcodeButton,
            this.editButton,
            this.deleteButton,
            this.categoryID,
            this.vendorID});
            this.productGV.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.productGV.Location = new System.Drawing.Point(60, 185);
            this.productGV.Name = "productGV";
            this.productGV.RowHeadersVisible = false;
            this.productGV.RowHeadersWidth = 55;
            this.productGV.RowTemplate.Height = 24;
            this.productGV.Size = new System.Drawing.Size(728, 344);
            this.productGV.TabIndex = 14;
            this.productGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGV_CellClick);
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
            this.productName.FillWeight = 80F;
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 70;
            this.productName.Name = "productName";
            // 
            // productBrand
            // 
            this.productBrand.FillWeight = 50F;
            this.productBrand.HeaderText = "Brand";
            this.productBrand.MinimumWidth = 6;
            this.productBrand.Name = "productBrand";
            // 
            // productCategory
            // 
            this.productCategory.FillWeight = 55F;
            this.productCategory.HeaderText = "Category";
            this.productCategory.MinimumWidth = 6;
            this.productCategory.Name = "productCategory";
            // 
            // productPrice
            // 
            this.productPrice.FillWeight = 55F;
            this.productPrice.HeaderText = "Price";
            this.productPrice.MinimumWidth = 6;
            this.productPrice.Name = "productPrice";
            // 
            // productQty
            // 
            this.productQty.FillWeight = 50F;
            this.productQty.HeaderText = "Quantity";
            this.productQty.MinimumWidth = 6;
            this.productQty.Name = "productQty";
            // 
            // productUnit
            // 
            this.productUnit.FillWeight = 30F;
            this.productUnit.HeaderText = "Unit";
            this.productUnit.MinimumWidth = 6;
            this.productUnit.Name = "productUnit";
            // 
            // productBarcode
            // 
            this.productBarcode.FillWeight = 50F;
            this.productBarcode.HeaderText = "Barcode";
            this.productBarcode.MinimumWidth = 6;
            this.productBarcode.Name = "productBarcode";
            // 
            // barcodeButton
            // 
            this.barcodeButton.FillWeight = 45F;
            this.barcodeButton.HeaderText = "Generate";
            this.barcodeButton.MinimumWidth = 6;
            this.barcodeButton.Name = "barcodeButton";
            this.barcodeButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.barcodeButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // categoryID
            // 
            this.categoryID.HeaderText = "category";
            this.categoryID.MinimumWidth = 6;
            this.categoryID.Name = "categoryID";
            this.categoryID.Visible = false;
            // 
            // vendorID
            // 
            this.vendorID.HeaderText = "vendor";
            this.vendorID.MinimumWidth = 6;
            this.vendorID.Name = "vendorID";
            this.vendorID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 128);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(30, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Products";
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
            // Product
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 605);
            this.Controls.Add(this.productGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBarcode;
        private System.Windows.Forms.DataGridViewButtonColumn barcodeButton;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorID;
    }
}