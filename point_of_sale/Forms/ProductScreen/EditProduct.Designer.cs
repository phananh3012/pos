namespace point_of_sale.ProductScreen
{
    partial class EditProduct
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
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.Unit = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unitTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.qtyTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.brandTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryCB
            // 
            this.categoryCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Items.AddRange(new object[] {
            "Manager",
            "Barista",
            "Cashier",
            "Server"});
            this.categoryCB.Location = new System.Drawing.Point(335, 154);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(200, 28);
            this.categoryCB.TabIndex = 32;
            // 
            // Unit
            // 
            this.Unit.AutoSize = true;
            this.Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Unit.Location = new System.Drawing.Point(331, 207);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(39, 20);
            this.Unit.TabIndex = 31;
            this.Unit.Text = "Unit";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(432, 376);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(126, 47);
            this.closeButton.TabIndex = 30;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(274, 376);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(126, 47);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // priceTB
            // 
            this.priceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priceTB.Location = new System.Drawing.Point(49, 240);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(200, 26);
            this.priceTB.TabIndex = 28;
            this.priceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(47, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Price";
            // 
            // unitTB
            // 
            this.unitTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.unitTB.Location = new System.Drawing.Point(335, 240);
            this.unitTB.Name = "unitTB";
            this.unitTB.Size = new System.Drawing.Size(200, 26);
            this.unitTB.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(331, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Category";
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameTB.Location = new System.Drawing.Point(49, 154);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(200, 26);
            this.nameTB.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(45, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 87);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Product Info";
            // 
            // qtyTB
            // 
            this.qtyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.qtyTB.Location = new System.Drawing.Point(49, 328);
            this.qtyTB.Name = "qtyTB";
            this.qtyTB.Size = new System.Drawing.Size(200, 26);
            this.qtyTB.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(47, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Quantity";
            // 
            // brandTB
            // 
            this.brandTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.brandTB.Location = new System.Drawing.Point(335, 328);
            this.brandTB.Name = "brandTB";
            this.brandTB.Size = new System.Drawing.Size(200, 26);
            this.brandTB.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(331, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Brand";
            // 
            // EditProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(590, 458);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.brandTB);
            this.Controls.Add(this.qtyTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.unitTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.Label Unit;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox unitTB;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox qtyTB;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox brandTB;
        private System.Windows.Forms.Label label6;
    }
}