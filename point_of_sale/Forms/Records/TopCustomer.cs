using System;
using System.Windows.Forms;

namespace point_of_sale.Reports
{
    public partial class TopCustomer : Form
    {
        public TopCustomer()
        {
            InitializeComponent();
        }
        private void GetData(string cond)
        {
            string qry = @"select customer_id, customer_name, customer_phone, count(order_id), sum(total) from customers m, orders n
                            where order_customer = customer_id " + cond + "" +
                            " group by customer_id, customer_name, customer_phone order by count(order_id) desc";
            ListBox lb = new ListBox();
            lb.Items.Add(customerID);
            lb.Items.Add(customerName);
            lb.Items.Add(customerPhone);
            lb.Items.Add(customerOrders);
            lb.Items.Add(customerTotal);
            MainClass.LoadData(qry, topCustomerGV, lb);
        }

        private void TopCustomer_Load(object sender, EventArgs e)
        {
            GetData("");
            endDP.MinDate = startDP.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GetData("and order_date between '" + Convert.ToDateTime(startDP.Value).Date + "' and '" + Convert.ToDateTime(endDP.Value).Date + "'");

        }

        private void startDP_ValueChanged(object sender, EventArgs e)
        {
            endDP.MinDate = startDP.Value;
        }
    }
}
