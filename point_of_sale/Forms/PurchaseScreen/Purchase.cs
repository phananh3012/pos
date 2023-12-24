using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace point_of_sale.PurchaseScreen
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }
        public void GetData(string cond)
        {
            string qry = @"select purchase_id, purchase_date, purchase_time, m.vendor_id, vendor_name, purchase_employee, 
                        purchase_status, total from purchases m inner join vendor n on m.vendor_id = n.vendor_id 
                        where " + cond + "";
            ListBox lb = new ListBox();
            lb.Items.Add(purchaseID);
            lb.Items.Add(purchaseDate);
            lb.Items.Add(purchaseTime);
            lb.Items.Add(vendorID);
            lb.Items.Add(vendorName);
            lb.Items.Add(purchaseEmployee);
            lb.Items.Add(purchaseStatus);
            lb.Items.Add(purchaseTotal);
            MainClass.LoadData(qry, purchaseGV, lb);
            purchaseGV.Columns["paidButton"].Visible = false;
            purchaseGV.Columns["doneButton"].Visible = false;
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            GetData("purchase_id like '%" + searchBar.Text + "%'");
            endDP.MinDate = startDP.Value;
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            GetData("purchase_id like '%" + searchBar.Text + "%'");
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new MakePurchase());
        }

        private void purchaseGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (purchaseGV.CurrentCell.OwningColumn.Name == "detailButton")
            {
                PurchaseDetail frm = new PurchaseDetail
                {
                    ID = Convert.ToInt32(purchaseGV.CurrentRow.Cells["purchaseID"].Value)
                };
                MainClass.BlurBackground(frm);
            }
            if (purchaseGV.CurrentCell.OwningColumn.Name == "paidButton")
            {
                var confirmPaid = MessageBox.Show("Are you sure this purchase is paid", "Confirm Payment!!", MessageBoxButtons.YesNo);
                if (confirmPaid == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(purchaseGV.CurrentRow.Cells["purchaseID"].Value);
                    string qry = $"update purchases set purchase_status = 'Paid' where purchase_id ={ID}";
                    Hashtable ht = new Hashtable();
                    if (MainClass.SQL(qry, ht) > 0)
                    {
                        MessageBox.Show("Update successful!!!");
                    }
                }
                else { return; }
                GetData("purchase_id like '%" + searchBar.Text + "%'");
            }
            if (purchaseGV.CurrentCell.OwningColumn.Name == "doneButton")
            {
                var confirmDone = MessageBox.Show("Are you sure this purchase is received", "Confirm Status!!", MessageBoxButtons.YesNo);
                if (confirmDone == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(purchaseGV.CurrentRow.Cells["purchaseID"].Value);
                    string qry = @"select vp_id, m.product_name, vendor_name, qty, m.unit, purchase_employee from purchase_detail m inner join
                                   purchases n on m.purchase_id = n.purchase_id inner join vendor p on n.vendor_id = p.vendor_id
                                   inner join vendor_products o on p.vendor_id = o.vendor_id
                                   where n.purchase_id = " + ID + " and m.product_name = o.product_name";
                    SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    { 
                            string qry1 = @"if not exists (select product_id from products, vendor_products where product_id = @ID) 
                                            begin insert into products values(@ID, @Name, @Brand, 3, null, @Qty, @Unit, null);
                                               insert into log_product values(@ID, @Date, @Time, @Name, 0, 0, @Qty, @Qty, @Actor); end
                                            else begin insert into log_product values(@ID, @Date, @Time, @Name, (select product_quantity from products where product_id = @ID), 0, @Qty, (select product_quantity from products where product_id = @ID) + @Qty, @Actor);
                                               update products set product_quantity += @Qty where product_id = @ID;                                              
                                            end";
                            SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con);
                            cmd1.Parameters.AddWithValue("@ID", row["vp_id"]);
                            cmd1.Parameters.AddWithValue("@Name", row["product_name"]);
                            cmd1.Parameters.AddWithValue("@Brand", row["vendor_name"]);
                            cmd1.Parameters.AddWithValue("@Unit", row["unit"].ToString());
                            cmd1.Parameters.AddWithValue("@Qty", row["qty"]);
                            cmd1.Parameters.AddWithValue("@Date", Convert.ToDateTime(DateTime.Now.Date));
                            cmd1.Parameters.AddWithValue("@Time", DateTime.Now.ToShortTimeString());
                            cmd1.Parameters.AddWithValue("@Actor", row["purchase_employee"]);


                        if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                            cmd1.ExecuteNonQuery();
                            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }
                    }
                    
                    string qry2 = $"update purchases set purchase_status = 'Done' where purchase_id ={ID}";
                    Hashtable ht = new Hashtable();
                    if (MainClass.SQL(qry2, ht) > 0)
                    {
                        MessageBox.Show("Update successful!!!");
                    }
                }
                else { return; }
                GetData("purchase_id like '%" + searchBar.Text + "%'");
            }
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            GetData("purchase_id like '%" + searchBar.Text + "%'");
        }

        private void requestBtn_Click(object sender, EventArgs e)
        {
            GetData("purchase_status = 'Requested'");
            purchaseGV.Columns["paidButton"].Visible = true;
            purchaseGV.Columns["doneButton"].Visible = false;
        }

        private void paidBtn_Click(object sender, EventArgs e)
        {
            GetData("purchase_status = 'Paid'");
            purchaseGV.Columns["paidButton"].Visible = false;
            purchaseGV.Columns["doneButton"].Visible = true;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            GetData("purchase_status = 'Done'");
            purchaseGV.Columns["paidButton"].Visible = false;
            purchaseGV.Columns["doneButton"].Visible = false;
        }

        private void startDP_ValueChanged(object sender, EventArgs e)
        {
            endDP.MinDate = startDP.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GetData("purchase_date between '" + Convert.ToDateTime(startDP.Value).Date + "' and '" + Convert.ToDateTime(endDP.Value).Date + "'");
        }
    }
}
