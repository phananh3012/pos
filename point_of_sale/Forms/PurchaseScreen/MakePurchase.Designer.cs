namespace point_of_sale.PurchaseScreen
{
    partial class MakePurchase
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.vendorCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.purchaseGV1 = new System.Windows.Forms.DataGridView();
            this.purchaseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.productCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qtyTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.vendorCB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 71);
            this.panel1.TabIndex = 23;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(573, 22);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 30;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // vendorCB
            // 
            this.vendorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vendorCB.FormattingEnabled = true;
            this.vendorCB.Location = new System.Drawing.Point(114, 22);
            this.vendorCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vendorCB.Name = "vendorCB";
            this.vendorCB.Size = new System.Drawing.Size(132, 28);
            this.vendorCB.TabIndex = 1;
            this.vendorCB.DropDownClosed += new System.EventHandler(this.vendorCB_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendor";
            // 
            // purchaseGV1
            // 
            this.purchaseGV1.AllowUserToAddRows = false;
            this.purchaseGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchaseGV1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.purchaseGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseNo,
            this.vendorProduct,
            this.productQty,
            this.productCost,
            this.productUnit,
            this.productSum});
            this.purchaseGV1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.purchaseGV1.Location = new System.Drawing.Point(38, 159);
            this.purchaseGV1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.purchaseGV1.Name = "purchaseGV1";
            this.purchaseGV1.RowHeadersVisible = false;
            this.purchaseGV1.RowHeadersWidth = 55;
            this.purchaseGV1.RowTemplate.Height = 24;
            this.purchaseGV1.Size = new System.Drawing.Size(546, 209);
            this.purchaseGV1.TabIndex = 24;
            this.purchaseGV1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.purchaseGV1_CellFormatting);
            this.purchaseGV1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseGV1_CellValueChanged);
            // 
            // purchaseNo
            // 
            this.purchaseNo.FillWeight = 35F;
            this.purchaseNo.HeaderText = "No";
            this.purchaseNo.MinimumWidth = 6;
            this.purchaseNo.Name = "purchaseNo";
            // 
            // vendorProduct
            // 
            this.vendorProduct.HeaderText = "Product";
            this.vendorProduct.MinimumWidth = 6;
            this.vendorProduct.Name = "vendorProduct";
            this.vendorProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vendorProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // productQty
            // 
            this.productQty.FillWeight = 50F;
            this.productQty.HeaderText = "Quantity";
            this.productQty.MinimumWidth = 6;
            this.productQty.Name = "productQty";
            // 
            // productCost
            // 
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
            // productSum
            // 
            this.productSum.HeaderText = "Sum";
            this.productSum.MinimumWidth = 6;
            this.productSum.Name = "productSum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.totalLabel.Location = new System.Drawing.Point(348, 393);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(45, 24);
            this.totalLabel.TabIndex = 26;
            this.totalLabel.Text = "0.00";
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.printButton.Location = new System.Drawing.Point(471, 386);
            this.printButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(113, 38);
            this.printButton.TabIndex = 30;
            this.printButton.Text = "Print Request";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // productCB
            // 
            this.productCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.productCB.FormattingEnabled = true;
            this.productCB.Location = new System.Drawing.Point(38, 110);
            this.productCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productCB.Name = "productCB";
            this.productCB.Size = new System.Drawing.Size(151, 24);
            this.productCB.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(35, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Product";
            // 
            // qtyTB
            // 
            this.qtyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.qtyTB.Location = new System.Drawing.Point(226, 110);
            this.qtyTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qtyTB.Name = "qtyTB";
            this.qtyTB.Size = new System.Drawing.Size(69, 23);
            this.qtyTB.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(224, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Quanity";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addBtn.Location = new System.Drawing.Point(379, 102);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 38);
            this.addBtn.TabIndex = 35;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.removeBtn.Location = new System.Drawing.Point(490, 102);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(94, 38);
            this.removeBtn.TabIndex = 36;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // MakePurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 445);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.qtyTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.productCB);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.purchaseGV1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MakePurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakePurchase";
            this.Load += new System.EventHandler(this.MakePurchase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox vendorCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView purchaseGV1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSum;
        public System.Windows.Forms.ComboBox productCB;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox qtyTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button closeButton;
    }
}