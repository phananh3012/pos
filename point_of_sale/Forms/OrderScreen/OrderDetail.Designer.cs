namespace point_of_sale.OrderScreen
{
    partial class OrderDetail
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
            this.detailGV = new System.Windows.Forms.DataGridView();
            this.ordNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detailGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailGV
            // 
            this.detailGV.AllowUserToAddRows = false;
            this.detailGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.detailGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordNo,
            this.ordProduct,
            this.productQty,
            this.productPrice,
            this.productSum});
            this.detailGV.GridColor = System.Drawing.SystemColors.ControlLight;
            this.detailGV.Location = new System.Drawing.Point(40, 135);
            this.detailGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detailGV.Name = "detailGV";
            this.detailGV.RowHeadersVisible = false;
            this.detailGV.RowHeadersWidth = 55;
            this.detailGV.RowTemplate.Height = 24;
            this.detailGV.Size = new System.Drawing.Size(728, 257);
            this.detailGV.TabIndex = 40;
            this.detailGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.detailGV_CellFormatting);
            // 
            // ordNo
            // 
            this.ordNo.FillWeight = 35F;
            this.ordNo.HeaderText = "No";
            this.ordNo.MinimumWidth = 6;
            this.ordNo.Name = "ordNo";
            // 
            // ordProduct
            // 
            this.ordProduct.HeaderText = "Product";
            this.ordProduct.MinimumWidth = 6;
            this.ordProduct.Name = "ordProduct";
            this.ordProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ordProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // productQty
            // 
            this.productQty.FillWeight = 50F;
            this.productQty.HeaderText = "Quantity";
            this.productQty.MinimumWidth = 6;
            this.productQty.Name = "productQty";
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Price";
            this.productPrice.MinimumWidth = 6;
            this.productPrice.Name = "productPrice";
            // 
            // productSum
            // 
            this.productSum.HeaderText = "Sum";
            this.productSum.MinimumWidth = 6;
            this.productSum.Name = "productSum";
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
            this.panel1.TabIndex = 39;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(752, 22);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(27, 25);
            this.closeButton.TabIndex = 30;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            // OrderDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.detailGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderDetail";
            this.Load += new System.EventHandler(this.OrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView detailGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSum;
    }
}