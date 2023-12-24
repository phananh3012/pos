using point_of_sale.OrderScreen;
using point_of_sale.Reports;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace point_of_sale.POSScreen
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        public double amt;
        public int MainID = 0;
        public double Total;
        private void receivedTB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(totalTB.Text, out double amt);
            double.TryParse(receivedTB.Text, out double received);

            double change = received - amt;
            changeTB.Text = change.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(double.Parse(changeTB.Text) < 0)
            {
                MessageBox.Show("Received amount is smaller than total!");
            }
            else
            {
                string qry = @"update orders set total = @Total, received = @Received, change = @Change, payment_method = @Method,
                            order_status='Done' where order_id = @ID";
                Hashtable ht = new Hashtable
                {
                    { "@ID", MainID },
                    { "@Total", Convert.ToDouble(totalTB.Text) },
                    { "@Received", Convert.ToDouble(receivedTB.Text) },
                    { "@Change", Convert.ToDouble(changeTB.Text) },
                    { "@Method", methodCB.Text }
                };

                if (MainClass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Payment Successful");
                    this.Close();
                }
                string qry1 = @"select * from orders m inner join order_detail n on m.order_id = n.order_id 
                               inner join products p on p.product_id = n.product_id where m.order_id = " + MainID + "";
                SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con);
                MainClass.con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MainClass.con.Close();
                OrderBill cr = new OrderBill();
                Print frm = new Print();


                cr.SetDatabaseLogon("sa", "123");
                cr.SetDataSource(dt);
                frm.crystalReportViewer1.ReportSource = cr;
                frm.crystalReportViewer1.Refresh();
                frm.Show();
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            totalTB.Text = Total.ToString();
            customerTB.Text = MainClass.CUSTOMER_ID;
            //for cb fill
            string qry = "select method_id 'id', method_name 'name' from payment_method";
            MainClass.CBFill(qry, methodCB);
        }

        private void methodCB_DropDownClosed(object sender, EventArgs e)
        {
            if(methodCB.SelectedValue != null)
            {
                if (methodCB.SelectedValue.ToString() == "2")
                {
                    receivedTB.Text = totalTB.Text;
                    receivedTB.Enabled = false;
                }
                if (methodCB.SelectedValue.ToString() == "1")
                {
                    receivedTB.Enabled = true;
                }
            }
            else { return; }
        }

        private void newQR_Click(object sender, EventArgs e)
        {
            QR frm = new QR
            {
                amount = Total
            };
            frm.ShowDialog();
        }

        private void receivedTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            MainClass.KeyPress(sender, e);
        }

        private void Payment_MouseMove(object sender, MouseEventArgs e)
        {
            if(changeTB.Text == "" || methodCB.GetItemText(methodCB.SelectedItem) == "")
            {
                saveButton.Enabled = false;
            }
            else
            {
                saveButton.Enabled = true;
            }
        }
    }
}
