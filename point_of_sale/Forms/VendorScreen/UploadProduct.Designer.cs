namespace point_of_sale.VendorScreen
{
    partial class UploadProduct
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
            this.browseBtn = new System.Windows.Forms.Button();
            this.productsGV = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(41, 24);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(82, 25);
            this.browseBtn.TabIndex = 18;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // productsGV
            // 
            this.productsGV.AllowUserToAddRows = false;
            this.productsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGV.Location = new System.Drawing.Point(41, 114);
            this.productsGV.Name = "productsGV";
            this.productsGV.RowHeadersVisible = false;
            this.productsGV.RowHeadersWidth = 51;
            this.productsGV.RowTemplate.Height = 24;
            this.productsGV.Size = new System.Drawing.Size(544, 313);
            this.productsGV.TabIndex = 19;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(580, 24);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 20;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(463, 460);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(122, 36);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(140, 27);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(256, 22);
            this.txtPath.TabIndex = 22;
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(41, 70);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(82, 25);
            this.uploadBtn.TabIndex = 23;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 22);
            this.txtName.TabIndex = 24;
            // 
            // UploadProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(631, 523);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.productsGV);
            this.Controls.Add(this.browseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UploadProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UploadProduct";
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.DataGridView productsGV;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.TextBox txtName;
    }
}