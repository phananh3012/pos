using System;
using System.Windows.Forms;

namespace point_of_sale.Records
{
    public partial class ProductLog : Form
    {
        public ProductLog()
        {
            InitializeComponent();
        }
        private void GetData(string cond)
        {
            string qry = $"select * from log_product {cond}";

            ListBox lb = new ListBox();
            lb.Items.Add(logID);
            lb.Items.Add(productID);
            lb.Items.Add(logDate);
            lb.Items.Add(logTime);
            lb.Items.Add(productName);
            lb.Items.Add(startQty);
            lb.Items.Add(deliveredQty);
            lb.Items.Add(receivedQty);
            lb.Items.Add(endQty);
            lb.Items.Add(actorID);
            MainClass.LoadData(qry, logGV, lb);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GetData("where log_date between '" + Convert.ToDateTime(startDP.Value).Date + "' and '" + Convert.ToDateTime(endDP.Value).Date + "'");
        }

        private void ProductLog_Load(object sender, EventArgs e)
        {
            GetData("");
            endDP.MinDate = startDP.Value;
        }

        private void startDP_ValueChanged(object sender, EventArgs e)
        {
            endDP.MinDate = startDP.Value;
        }
    }
}
