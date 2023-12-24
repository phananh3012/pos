using point_of_sale.POSScreen;
using point_of_sale.Reports;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace point_of_sale.OrderScreen
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        public void GetData(string cond)
        {
            string qry = "select * from orders where " + cond;
            ListBox lb = new ListBox();
            lb.Items.Add(orderID);
            lb.Items.Add(orderDate);
            lb.Items.Add(orderTime);
            lb.Items.Add(orderEmployee);
            lb.Items.Add(orderCustomer);
            lb.Items.Add(orderMethod);
            lb.Items.Add(ordStatus);
            lb.Items.Add(ordSubTotal);
            lb.Items.Add(ordDis);
            lb.Items.Add(orderTotal);
            lb.Items.Add(ordReceived);
            lb.Items.Add(ordChange);
            MainClass.LoadData(qry, orderGV, lb);
        }

        private void Order_Load(object sender, EventArgs e)
        {
            GetData("order_id like '%" + searchBar.Text + "%'");
            endDP.MinDate = startDP.Value;
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            GetData("order_id like '%" + searchBar.Text + "%'");
        }

        private void orderGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (orderGV.CurrentCell.OwningColumn.Name == "detailButton")
            {
                OrderDetail frm = new OrderDetail
                {
                    ID = Convert.ToInt32(orderGV.CurrentRow.Cells["orderID"].Value)
                };
                MainClass.BlurBackground(frm);
            }
            if (orderGV.CurrentCell.OwningColumn.Name == "printButton")
            {
                int MainID = Convert.ToInt32(orderGV.CurrentRow.Cells["orderID"].Value);
                string qry = @"select * from orders m inner join order_detail n on m.order_id = n.order_id 
                               inner join products p on p.product_id = n.product_id where m.order_id = " + MainID + "";
                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                MainClass.con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
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

        private void startDP_ValueChanged(object sender, EventArgs e)
        {
            endDP.MinDate = startDP.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GetData("order_date between '" + Convert.ToDateTime(startDP.Value).Date + "' and '" + Convert.ToDateTime(endDP.Value).Date + "'");
        }
    }
}
