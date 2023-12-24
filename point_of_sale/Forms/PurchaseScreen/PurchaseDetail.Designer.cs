namespace point_of_sale.PurchaseScreen
{
    partial class PurchaseDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailGV = new System.Windows.Forms.DataGridView();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detail";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(761, 11);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(27, 25);
            this.closeButton.TabIndex = 30;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 87);
            this.panel1.TabIndex = 37;
            // 
            // productSum
            // 
            this.productSum.HeaderText = "Sum";
            this.productSum.MinimumWidth = 6;
            this.productSum.Name = "productSum";
            // 
            // productUnit
            // 
            this.productUnit.FillWeight = 50F;
            this.productUnit.HeaderText = "Unit";
            this.productUnit.MinimumWidth = 6;
            this.productUnit.Name = "productUnit";
            // 
            // productCost
            // 
            this.productCost.HeaderText = "Cost";
            this.productCost.MinimumWidth = 6;
            this.productCost.Name = "productCost";
            // 
            // productQty
            // 
            this.productQty.FillWeight = 50F;
            this.productQty.HeaderText = "Quantity";
            this.productQty.MinimumWidth = 6;
            this.productQty.Name = "productQty";
            // 
            // vendorProduct
            // 
            this.vendorProduct.HeaderText = "Product";
            this.vendorProduct.MinimumWidth = 6;
            this.vendorProduct.Name = "vendorProduct";
            this.vendorProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vendorProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // purchaseNo
            // 
            this.purchaseNo.FillWeight = 35F;
            this.purchaseNo.HeaderText = "No";
            this.purchaseNo.MinimumWidth = 6;
            this.purchaseNo.Name = "purchaseNo";
            // 
            // detailGV
            // 
            this.detailGV.AllowUserToAddRows = false;
            this.detailGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.detailGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseNo,
            this.vendorProduct,
            this.productQty,
            this.productCost,
            this.productUnit,
            this.productSum});
            this.detailGV.GridColor = System.Drawing.SystemColors.ControlLight;
            this.detailGV.Location = new System.Drawing.Point(40, 135);
            this.detailGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detailGV.Name = "detailGV";
            this.detailGV.RowHeadersVisible = false;
            this.detailGV.RowHeadersWidth = 55;
            this.detailGV.RowTemplate.Height = 24;
            this.detailGV.Size = new System.Drawing.Size(728, 257);
            this.detailGV.TabIndex = 38;
            this.detailGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.detailGV_CellFormatting);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.totalLabel.Location = new System.Drawing.Point(464, 448);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(45, 24);
            this.totalLabel.TabIndex = 40;
            this.totalLabel.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Total:";
            // 
            // PurchaseDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.detailGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseDetail";
            this.Load += new System.EventHandler(this.PurchaseDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseNo;
        private System.Windows.Forms.DataGridView detailGV;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label2;
    }
}