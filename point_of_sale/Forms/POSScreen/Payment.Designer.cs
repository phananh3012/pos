namespace point_of_sale.POSScreen
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.receivedTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.changeTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.methodCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customerTB = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.newQR = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newQR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 87);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment";
            // 
            // totalTB
            // 
            this.totalTB.Enabled = false;
            this.totalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.totalTB.Location = new System.Drawing.Point(76, 161);
            this.totalTB.Name = "totalTB";
            this.totalTB.Size = new System.Drawing.Size(200, 26);
            this.totalTB.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(72, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bill Total";
            // 
            // receivedTB
            // 
            this.receivedTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.receivedTB.Location = new System.Drawing.Point(76, 260);
            this.receivedTB.Name = "receivedTB";
            this.receivedTB.Size = new System.Drawing.Size(200, 26);
            this.receivedTB.TabIndex = 17;
            this.receivedTB.TextChanged += new System.EventHandler(this.receivedTB_TextChanged);
            this.receivedTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.receivedTB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(72, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Received";
            // 
            // changeTB
            // 
            this.changeTB.Enabled = false;
            this.changeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.changeTB.Location = new System.Drawing.Point(76, 355);
            this.changeTB.Name = "changeTB";
            this.changeTB.Size = new System.Drawing.Size(200, 26);
            this.changeTB.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(72, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Change";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(361, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Customer";
            // 
            // methodCB
            // 
            this.methodCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.methodCB.FormattingEnabled = true;
            this.methodCB.Items.AddRange(new object[] {
            "Manager",
            "Barista",
            "Cashier",
            "Server"});
            this.methodCB.Location = new System.Drawing.Point(365, 260);
            this.methodCB.Name = "methodCB";
            this.methodCB.Size = new System.Drawing.Size(200, 28);
            this.methodCB.TabIndex = 25;
            this.methodCB.DropDownClosed += new System.EventHandler(this.methodCB_DropDownClosed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(361, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Payment Method";
            // 
            // customerTB
            // 
            this.customerTB.Enabled = false;
            this.customerTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerTB.Location = new System.Drawing.Point(365, 161);
            this.customerTB.Name = "customerTB";
            this.customerTB.Size = new System.Drawing.Size(200, 26);
            this.customerTB.TabIndex = 26;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(439, 334);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(126, 47);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newQR
            // 
            this.newQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newQR.Image = ((System.Drawing.Image)(resources.GetObject("newQR.Image")));
            this.newQR.Location = new System.Drawing.Point(494, 224);
            this.newQR.Name = "newQR";
            this.newQR.Size = new System.Drawing.Size(30, 30);
            this.newQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newQR.TabIndex = 1;
            this.newQR.TabStop = false;
            this.newQR.Click += new System.EventHandler(this.newQR_Click);
            // 
            // Payment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(654, 425);
            this.Controls.Add(this.newQR);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.customerTB);
            this.Controls.Add(this.methodCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.changeTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.receivedTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Payment_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox totalTB;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox receivedTB;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox changeTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox methodCB;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox customerTB;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox newQR;
    }
}