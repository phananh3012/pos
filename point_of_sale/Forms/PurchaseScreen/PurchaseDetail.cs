using System;
using System.Windows.Forms;

namespace point_of_sale.PurchaseScreen
{
    public partial class PurchaseDetail : Form
    {
        public PurchaseDetail()
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
            string qry = $"select product_name, qty, cost, unit, _sum from purchase_detail where purchase_id = {ID}";
            ListBox lb = new ListBox();
            lb.Items.Add(vendorProduct);
            lb.Items.Add(productQty);
            lb.Items.Add(productCost);
            lb.Items.Add(productUnit);
            lb.Items.Add(productSum);
            MainClass.LoadData(qry, detailGV, lb);
        }

        private void PurchaseDetail_Load(object sender, EventArgs e)
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
