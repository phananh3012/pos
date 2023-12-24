using point_of_sale.POSScreen;
using point_of_sale.Reports;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace point_of_sale.PurchaseScreen
{
    public partial class MakePurchase : Form
    {
        public MakePurchase()
        {
            InitializeComponent();
        }

        private void MakePurchase_Load(object sender, EventArgs e)
        {
            string qry = "select vendor_id 'id', vendor_name 'name' from vendor";
            MainClass.CBFill(qry, vendorCB);
        }

        private void purchaseGV1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in purchaseGV1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void vendorCB_DropDownClosed(object sender, EventArgs e)
        {
            if(vendorCB.SelectedValue != null)
            {
                string qry = $"select vp_id 'id', product_name 'name' from vendor_products where vendor_id = {vendorCB.SelectedValue}";
                MainClass.CBFill(qry, productCB);
            }
            else { return; }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string qry = $"select * from vendor_products where vendor_id ={vendorCB.SelectedValue}";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow item in dt.Rows) 
            {
                if (item["product_name"].ToString() == productCB.GetItemText(productCB.SelectedItem))
                {
                    purchaseGV1.Rows.Add(new object[] { 0, item["product_name"].ToString(), qtyTB.Text, item["cost"].ToString(), item["unit"].ToString(), 0 });
                }
            }
            foreach(DataGridViewRow item in purchaseGV1.Rows)
            {
                item.Cells["productSum"].Value = int.Parse(item.Cells["productQty"].Value.ToString()) *
                                                    double.Parse(item.Cells["productCost"].Value.ToString());
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetTotal()
        {
            double total = 0;
            totalLabel.Text = "";
            foreach (DataGridViewRow item in purchaseGV1.Rows)
            {
                total += double.Parse((item.Cells["productSum"].Value)?.ToString() ?? "0");
                totalLabel.Text = total.ToString("N2");
            }

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            purchaseGV1.Rows.RemoveAt(purchaseGV1.Rows.Count - 1);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string qry = @"insert into purchases values(@Date, @Time, @VendorID, @Employee, @Status, @Total);
                        select SCOPE_IDENTITY()";
            //get recent add id value

            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@Time", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@VendorID", vendorCB.SelectedValue);
            cmd.Parameters.AddWithValue("@Employee", MainClass.USER_ID);
            cmd.Parameters.AddWithValue("@Status", "Requested");
            cmd.Parameters.AddWithValue("@Total", Convert.ToDouble(totalLabel.Text)); 

            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            int MainID = Convert.ToInt32(cmd.ExecuteScalar());
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            foreach (DataGridViewRow row in purchaseGV1.Rows)
            {
                string qry1 = @"insert into purchase_detail values(@ID, @Product, @Qty, @Cost, @Unit, @Sum)";

                SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con);
                cmd1.Parameters.AddWithValue("@ID", MainID);
                cmd1.Parameters.AddWithValue("@Product", row.Cells["vendorProduct"].Value.ToString());
                cmd1.Parameters.AddWithValue("@Qty", Convert.ToInt32(row.Cells["productQty"].Value));
                cmd1.Parameters.AddWithValue("@Cost", Convert.ToDouble(row.Cells["productCost"].Value));
                cmd1.Parameters.AddWithValue("@Unit", row.Cells["productUnit"].Value.ToString());
                cmd1.Parameters.AddWithValue("@Sum", Convert.ToDouble(row.Cells["productSum"].Value));

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd1.ExecuteNonQuery();
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            }
            purchaseGV1.Rows.Clear();
            totalLabel.Text = "0.00";
            MessageBox.Show("Saved successfully");

            string qry2 = @"select * from purchases m inner join purchase_detail n on m.purchase_id = n.purchase_id 
                               inner join vendor p on p.vendor_id = m.vendor_id where m.purchase_id = " + MainID + "";
            SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
            MainClass.con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MainClass.con.Close();
            RequestPurchase cr = new RequestPurchase();
            Print frm = new Print();


            cr.SetDatabaseLogon("sa", "123");
            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();
            this.Close();
        }

        private void purchaseGV1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            GetTotal();
        }
    }
}
