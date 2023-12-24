using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace point_of_sale.POSScreen
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }
        int discount_id = 1;
        private void POS_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = MainClass.USER;
            GetData();
            AddCategory();
            customerLb.Text = "";
            discountBtn.Enabled = false;
        }
        public void GetData()
        {
            string qry = @"select product_id, m.product_name, product_brand, category_name, product_price, product_quantity, product_unit, product_barcode,
                         category_id, vendor_id from products m inner join categories on category_id = product_category inner join vendor_products n on product_id = vp_id
                         where m.product_name like '%" + searchBar.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(proID);
            lb.Items.Add(productName);
            lb.Items.Add(productBrand);
            lb.Items.Add(productCategory);
            lb.Items.Add(productPrice);
            lb.Items.Add(productQty);
            lb.Items.Add(productUnit);
            lb.Items.Add(productBarcode);
            lb.Items.Add(categoryID);
            lb.Items.Add(vendorID);
            MainClass.LoadData(qry, productGV, lb);
        }
        private void posGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in posGV.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void codeBar_TextChanged(object sender, EventArgs e)
        {
            if (codeBar.Text == String.Empty) { return; }
            else
            {
                string qry = $"select * from products where product_barcode like '{codeBar.Text}'";
                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataGridViewRow item in posGV.Rows)
                    {
                        //if had items -> update quantity and price
                        if (Convert.ToInt32(item.Cells["productID"].Value) == Convert.ToInt32(row["product_id"]))
                        {
                            item.Cells["posQty"].Value = int.Parse(item.Cells["posQty"].Value.ToString()) + 1;
                            codeBar.Clear();
                            codeBar.Focus();
                            return;
                        }
                    }
                    posGV.Rows.Add(new object[] { 0, row["product_id"], row["product_name"], 1, row["product_price"], row["product_price"] });
                    codeBar.Clear();
                    codeBar.Focus();
                }

            }
        }
        private void GetTotal()
        {
            double total = 0;
            foreach (DataGridViewRow item in posGV.Rows)
            {
                total += double.Parse((item.Cells["posSum"].Value)?.ToString() ?? "0");
                subTotal.Text = total.ToString("N2");
            }
        }

        private void posGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            GetTotal();
            GetGrandTotal();
            foreach (DataGridViewRow item in posGV.Rows)
            {
                 item.Cells["posSum"].Value = int.Parse(item.Cells["posQty"].Value.ToString()) *
                                                double.Parse(item.Cells["posPrice"].Value.ToString());

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (posGV.CurrentRow == null)
            {
                return;
            }
            else
            {
                posGV.CurrentRow.Cells["posQty"].Value = int.Parse(posGV.CurrentRow.Cells["posQty"].Value.ToString()) + 1;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (posGV.CurrentRow == null)
            {
                return;
            }
            else
            {
                posGV.CurrentRow.Cells["posQty"].Value = int.Parse(posGV.CurrentRow.Cells["posQty"].Value.ToString()) - 1;
                if (posGV.CurrentRow.Cells["posQty"].Value.ToString() == "0")
                {
                    posGV.Rows.Remove(posGV.CurrentRow);
                }
            }
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
        private void AddCategory()
        {
            string qry = "select * from categories";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            categoryPanel.Controls.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["category_name"].ToString() != "null")
                    {
                        Button b = new Button
                        {
                            Size = new Size(97, 62),
                            Text = row["category_name"].ToString()
                        };
                        categoryPanel.Controls.Add(b);

                        //event for click
                        b.Click += new EventHandler(b_Click);
                    }
                }

            }
        }
        private void b_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            foreach (DataGridViewRow row in productGV.Rows)
            {
                if (row.Cells["productCategory"].Value.ToString() != b.Text)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[productGV.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding(); ;
                }
                else row.Visible = true;
            }

        }

        private void productGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in posGV.Rows)
            {
                //if had items -> update quantity and price
                if (Convert.ToInt32(item.Cells["productID"].Value) == Convert.ToInt32(productGV.CurrentRow.Cells["proID"].Value))
                {
                    item.Cells["posQty"].Value = int.Parse(item.Cells["posQty"].Value.ToString()) + 1;
                    return;
                }
            }
            posGV.Rows.Add(new object[] { 0, productGV.CurrentRow.Cells["proID"].Value, productGV.CurrentRow.Cells["productName"].Value, 1, productGV.CurrentRow.Cells["productPrice"].Value, productGV.CurrentRow.Cells["productPrice"].Value });
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            if(posGV.Rows.Count == 0)
            {
                MessageBox.Show("Add items to cart");
            }
            else
            {
                string qry = @"insert into orders values(@Date, @Time, @Employee, @Customer, 
                        null, @Status, @Sub, @Dis, @Total, @Received, @Change);
                        select SCOPE_IDENTITY()"; //order

                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(DateTime.Now.Date));
                cmd.Parameters.AddWithValue("@Time", DateTime.Now.ToShortTimeString());
                cmd.Parameters.AddWithValue("@Employee", MainClass.USER_ID);
                cmd.Parameters.AddWithValue("@Customer", MainClass.CUSTOMER_ID ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Status", "Done");
                cmd.Parameters.AddWithValue("@Sub", Convert.ToDouble(subTotal.Text));
                cmd.Parameters.AddWithValue("@Dis", Convert.ToDouble(discountText.Text));
                cmd.Parameters.AddWithValue("@Total", Convert.ToDouble(totalLabel.Text)); //save data from order value
                cmd.Parameters.AddWithValue("@Received", Convert.ToDouble(0));
                cmd.Parameters.AddWithValue("@Change", Convert.ToDouble(0));

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                int MainID = Convert.ToInt32(cmd.ExecuteScalar());
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

                foreach (DataGridViewRow row in posGV.Rows)
                {
                    string qry1 = @"insert into order_detail values(@ID, @PID, @Qty, @Price, @Sum);
                         insert into log_product values(@PID, @Date, @Time, @Name, (select product_quantity from products where product_id = @PID), 
                         @Qty, 0, (select product_quantity from products where product_id = @PID) - @Qty, @Actor);
                         update products set product_quantity -= @Qty where product_id = @PID";
                    SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con);
                    cmd1.Parameters.AddWithValue("@ID", MainID);
                    cmd1.Parameters.AddWithValue("@PID", Convert.ToInt32(row.Cells["productID"].Value));
                    cmd1.Parameters.AddWithValue("@Qty", Convert.ToInt32(row.Cells["posQty"].Value));
                    cmd1.Parameters.AddWithValue("@Price", Convert.ToDouble(row.Cells["posPrice"].Value));
                    cmd1.Parameters.AddWithValue("@Sum", Convert.ToDouble(row.Cells["posSum"].Value));
                    cmd1.Parameters.AddWithValue("@Date", Convert.ToDateTime(DateTime.Now.Date));
                    cmd1.Parameters.AddWithValue("@Time", DateTime.Now.ToShortTimeString());
                    cmd1.Parameters.AddWithValue("@Name", row.Cells["posName"].Value.ToString());
                    cmd1.Parameters.AddWithValue("@Actor", MainClass.USER_ID);

                    if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                    cmd1.ExecuteNonQuery();
                    if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

                }
                if (MainClass.CUSTOMER_ID != null)
                {
                    if (discount_id % 2 == 0)
                    {
                        string qry2 = $"update customers set customer_point = 0 where customer_id ={MainClass.CUSTOMER_ID}";
                        Hashtable ht = new Hashtable();
                        MainClass.SQL(qry2, ht);
                    }
                    AddPoint();
                }
                Payment frm = new Payment
                {
                    MainID = MainID,
                    Total = Convert.ToDouble(totalLabel.Text)
                };
                MainClass.BlurBackground(frm);
                ClearOrder();
                GetData();
            }
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new CustomerOrder());
        }
        private void AddPoint()
        {
            string qry = @"if exists (select customer_id from customers where customer_id = @ID)
                            begin update customers set customer_point += @Point where customer_id = @ID end";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainClass.CUSTOMER_ID);
            cmd.Parameters.AddWithValue("@Point", double.Parse(totalLabel.Text) / 1000);
            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            cmd.ExecuteNonQuery();
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }
        }

        private void discountBtn_Click(object sender, EventArgs e)
        {
            discount_id++;
            double discount;
            if(discount_id % 2 == 0)
            {
                discount = double.Parse(MainClass.CUSTOMER_POINTS) * 100;
                discountText.Text = discount.ToString();
                GetGrandTotal();
            }
            else
            {
                discountText.Text = "0.00";
                GetGrandTotal();
            }    
           
        }

        private void POS_MouseMove(object sender, MouseEventArgs e)
        {
            customerLb.Text = MainClass.CUSTOMER_ID;       
            if(MainClass.CUSTOMER_ID != null)
            {
                discountBtn.Enabled = true;
            }
            else { discountBtn.Enabled = false; }
        }
        private void GetGrandTotal()
        {
            if (double.TryParse(subTotal.Text, out _) && double.TryParse(discountText.Text, out _))
            {
                totalLabel.Text = (double.Parse(subTotal.Text) - double.Parse(discountText.Text)).ToString("N2");
            }
        }
        private void ClearOrder()
        {
            posGV.Rows.Clear();
            MainClass.CUSTOMER_ID = null;
            customerLb.Text = MainClass.CUSTOMER_ID;
            MainClass.CUSTOMER_POINTS = null;
            subTotal.Text = "0.00";
            discountText.Text = "0.00";
            totalLabel.Text = "0.00";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            var confirmClear = MessageBox.Show("Are you sure to clear this order", "Confirm Clear!!", MessageBoxButtons.YesNo);
            if (confirmClear == DialogResult.Yes)
            {
                ClearOrder();
            }
        }
    }
}
