﻿namespace point_of_sale.POSScreen
{
    partial class QR
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
            this.qrPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrPic)).BeginInit();
            this.SuspendLayout();
            // 
            // qrPic
            // 
            this.qrPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qrPic.Location = new System.Drawing.Point(0, 0);
            this.qrPic.Name = "qrPic";
            this.qrPic.Size = new System.Drawing.Size(300, 300);
            this.qrPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrPic.TabIndex = 0;
            this.qrPic.TabStop = false;
            this.qrPic.Click += new System.EventHandler(this.qrPic_Click);
            // 
            // QR
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.qrPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR";
            this.Load += new System.EventHandler(this.QR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox qrPic;
    }
}