using System;
using System.Windows.Forms;

namespace point_of_sale.Reports
{
    public partial class TopSelling : Form
    {
        public TopSelling()
        {
            InitializeComponent();
        }
        private void GetData(string cond)
        {
            string qry = @"select p.product_id, product_name, product_brand, sum(qty) from orders m, order_detail n, products p 
                            where m.order_id = n.order_id and n.product_id = p.product_id " + cond + "" +
                            " group by p.product_id, product_name, product_brand order by sum(qty) desc";
            ListBox lb = new ListBox();
            lb.Items.Add(productID);
            lb.Items.Add(productName);
            lb.Items.Add(productBrand);
            lb.Items.Add(productQty);
            MainClass.LoadData(qry, topSellingGV, lb);
        }

        private void TopSelling_Load(object sender, EventArgs e)
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
