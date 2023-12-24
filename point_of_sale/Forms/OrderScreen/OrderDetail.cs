using System;
using System.Windows.Forms;

namespace point_of_sale.OrderScreen
{
    public partial class OrderDetail : Form
    {
        public OrderDetail()
        {
            InitializeComponent();
        }
        public int ID = 0;

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void GetData()
        {
            string qry = @"select n.product_name, m.qty, price, _sum from order_detail m inner join products n
                            on m.product_id = n.product_id where order_id = " + ID + "";
            ListBox lb = new ListBox();
            lb.Items.Add(ordProduct);
            lb.Items.Add(productQty);
            lb.Items.Add(productPrice);
            lb.Items.Add(productSum);
            MainClass.LoadData(qry, detailGV, lb);
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void detailGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in detailGV.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }
    }
}
