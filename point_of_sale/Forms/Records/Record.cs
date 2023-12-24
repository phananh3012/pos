using point_of_sale.Records;
using System;
using System.Windows.Forms;

namespace point_of_sale.Reports
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }
        public void AddControls(Form f)
        {
            controlPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            controlPanel.Controls.Add(f);
            f.Show();
        }

        private void topSelling_Click(object sender, EventArgs e)
        {
            AddControls(new TopSelling());
        }

        private void byCategory_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new SaleByCategory());
        }

        private void purchaseReport_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new PurchaseReport());

        }

        private void topCus_Click(object sender, EventArgs e)
        {
            AddControls(new TopCustomer());
        }

        private void Record_Load(object sender, EventArgs e)
        {
            AddControls(new ProductLog());
        }

        private void productLog_Click(object sender, EventArgs e)
        {
            AddControls(new ProductLog());
        }
    }
}
