namespace point_of_sale.POSScreen
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.discountBtn = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.categoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.categoryButton = new System.Windows.Forms.Button();
            this.topHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.endButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.posGV = new System.Windows.Forms.DataGridView();
            this.posNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.codeBar = new System.Windows.Forms.TextBox();
            this.productGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.customerLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.discountText = new System.Windows.Forms.Label();
            this.proID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.categoryPanel.SuspendLayout();
            this.topHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.discountBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.removeButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 500);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(372, 54);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // discountBtn
            // 
            this.discountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.discountBtn.Location = new System.Drawing.Point(189, 3);
            this.discountBtn.Name = "discountBtn";
            this.discountBtn.Size = new System.Drawing.Size(180, 48);
            this.discountBtn.TabIndex = 1;
            this.discountBtn.Text = "Discount";
            this.discountBtn.UseVisualStyleBackColor = true;
            this.discountBtn.Click += new System.EventHandler(this.discountBtn_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(87, 48);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.removeButton.Location = new System.Drawing.Point(96, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(87, 48);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "-";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.clearBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.customerBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 557);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(183, 109);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clearBtn.Location = new System.Drawing.Point(3, 57);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(177, 48);
            this.clearBtn.TabIndex = 24;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // billButton
            // 
            this.billButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.billButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.billButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.billButton.Location = new System.Drawing.Point(189, 557);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(186, 109);
            this.billButton.TabIndex = 3;
            this.billButton.Text = "Bill";
            this.billButton.UseVisualStyleBackColor = false;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerBtn.Location = new System.Drawing.Point(3, 3);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(177, 48);
            this.customerBtn.TabIndex = 23;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // categoryPanel
            // 
            this.categoryPanel.Controls.Add(this.categoryButton);
            this.categoryPanel.Location = new System.Drawing.Point(3, 64);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(1183, 68);
            this.categoryPanel.TabIndex = 24;
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(3, 3);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(97, 62);
            this.categoryButton.TabIndex = 0;
            this.categoryButton.Text = "category";
            this.categoryButton.UseVisualStyleBackColor = true;
            // 
            // topHeader
            // 
            this.topHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.topHeader.Controls.Add(this.label1);
            this.topHeader.Controls.Add(this.searchBar);
            this.topHeader.Controls.Add(this.endButton);
            this.topHeader.Controls.Add(this.usernameLabel);
            this.topHeader.Controls.Add(this.pictureBox1);
            this.topHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.topHeader.Location = new System.Drawing.Point(0, 0);
            this.topHeader.Name = "topHeader";
            this.topHeader.Size = new System.Drawing.Size(1186, 64);
            this.topHeader.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(570, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Items";
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(661, 20);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(265, 23);
            this.searchBar.TabIndex = 4;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // endButton
            // 
            this.endButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.endButton.Location = new System.Drawing.Point(1062, 20);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(112, 32);
            this.endButton.TabIndex = 1;
            this.endButton.Text = "End Session";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(959, 25);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(71, 17);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "username";
            // 
            // posGV
            // 
            this.posGV.AllowUserToAddRows = false;
            this.posGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.posGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.posGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posNo,
            this.productID,
            this.posName,
            this.posQty,
            this.posPrice,
            this.posSum});
            this.posGV.GridColor = System.Drawing.SystemColors.ControlLight;
            this.posGV.Location = new System.Drawing.Point(3, 132);
            this.posGV.Name = "posGV";
            this.posGV.RowHeadersVisible = false;
            this.posGV.RowHeadersWidth = 55;
            this.posGV.RowTemplate.Height = 24;
            this.posGV.Size = new System.Drawing.Size(658, 310);
            this.posGV.TabIndex = 23;
            this.posGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.posGV_CellFormatting);
            this.posGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.posGV_CellValueChanged);
            // 
            // posNo
            // 
            this.posNo.FillWeight = 30F;
            this.posNo.HeaderText = "No";
            this.posNo.MinimumWidth = 6;
            this.posNo.Name = "posNo";
            // 
            // productID
            // 
            this.productID.HeaderText = "productID";
            this.productID.MinimumWidth = 6;
            this.productID.Name = "productID";
            this.productID.Visible = false;
            // 
            // posName
            // 
            this.posName.HeaderText = "Name";
            this.posName.MinimumWidth = 70;
            this.posName.Name = "posName";
            // 
            // posQty
            // 
            this.posQty.FillWeight = 35F;
            this.posQty.HeaderText = "Qty";
            this.posQty.MinimumWidth = 6;
            this.posQty.Name = "posQty";
            // 
            // posPrice
            // 
            this.posPrice.FillWeight = 70F;
            this.posPrice.HeaderText = "Price";
            this.posPrice.MinimumWidth = 6;
            this.posPrice.Name = "posPrice";
            // 
            // posSum
            // 
            this.posSum.FillWeight = 70F;
            this.posSum.HeaderText = "Sum";
            this.posSum.MinimumWidth = 6;
            this.posSum.Name = "posSum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(117, 126);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(49, 24);
            this.totalLabel.TabIndex = 29;
            this.totalLabel.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Barcode";
            // 
            // codeBar
            // 
            this.codeBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBar.Location = new System.Drawing.Point(104, 14);
            this.codeBar.Name = "codeBar";
            this.codeBar.Size = new System.Drawing.Size(265, 23);
            this.codeBar.TabIndex = 8;
            this.codeBar.TextChanged += new System.EventHandler(this.codeBar_TextChanged);
            // 
            // productGV
            // 
            this.productGV.AllowUserToAddRows = false;
            this.productGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proID,
            this.productName,
            this.productBrand,
            this.productCategory,
            this.productPrice,
            this.productQty,
            this.productUnit,
            this.productBarcode,
            this.categoryID,
            this.vendorID});
            this.productGV.GridColor = System.Drawing.SystemColors.ControlLight;
            this.productGV.Location = new System.Drawing.Point(661, 132);
            this.productGV.Name = "productGV";
            this.productGV.RowHeadersVisible = false;
            this.productGV.RowHeadersWidth = 55;
            this.productGV.RowTemplate.Height = 24;
            this.productGV.Size = new System.Drawing.Size(525, 534);
            this.productGV.TabIndex = 30;
            this.productGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGV_CellContentDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.codeBar);
            this.panel1.Location = new System.Drawing.Point(3, 443);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 55);
            this.panel1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Customer:";
            // 
            // customerLb
            // 
            this.customerLb.AutoSize = true;
            this.customerLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.customerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLb.Location = new System.Drawing.Point(117, 17);
            this.customerLb.Name = "customerLb";
            this.customerLb.Size = new System.Drawing.Size(111, 20);
            this.customerLb.TabIndex = 33;
            this.customerLb.Text = "customer here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Sub-total:";
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal.Location = new System.Drawing.Point(117, 45);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(40, 20);
            this.subTotal.TabIndex = 35;
            this.subTotal.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Discount:";
            // 
            // discountText
            // 
            this.discountText.AutoSize = true;
            this.discountText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.discountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountText.Location = new System.Drawing.Point(117, 74);
            this.discountText.Name = "discountText";
            this.discountText.Size = new System.Drawing.Size(40, 20);
            this.discountText.TabIndex = 37;
            this.discountText.Text = "0.00";
            // 
            // proID
            // 
            this.proID.FillWeight = 20F;
            this.proID.HeaderText = "ID";
            this.proID.MinimumWidth = 25;
            this.proID.Name = "proID";
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
            this.productBrand.Visible = false;
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
            this.productPrice.Visible = false;
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
            this.productUnit.Visible = false;
            // 
            // productBarcode
            // 
            this.productBarcode.FillWeight = 50F;
            this.productBarcode.HeaderText = "Barcode";
            this.productBarcode.MinimumWidth = 6;
            this.productBarcode.Name = "productBarcode";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.discountText);
            this.panel2.Controls.Add(this.totalLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.customerLb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.subTotal);
            this.panel2.Location = new System.Drawing.Point(378, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 165);
            this.panel2.TabIndex = 38;
            // 
            // POS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1186, 669);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.productGV);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.categoryPanel);
            this.Controls.Add(this.topHeader);
            this.Controls.Add(this.posGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.Load += new System.EventHandler(this.POS_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.POS_MouseMove);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.categoryPanel.ResumeLayout(false);
            this.topHeader.ResumeLayout(false);
            this.topHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.FlowLayoutPanel categoryPanel;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Panel topHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.DataGridView posGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox codeBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn posNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn posName;
        private System.Windows.Forms.DataGridViewTextBoxColumn posQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn posPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn posSum;
        private System.Windows.Forms.DataGridView productGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label customerLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label discountText;
        private System.Windows.Forms.Button discountBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorID;
        private System.Windows.Forms.Panel panel2;
    }
}