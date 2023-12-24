using point_of_sale.POSScreen;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace point_of_sale.Reports
{
    public partial class PurchaseReport : Form
    {
        public PurchaseReport()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string qry = @"select * from purchases m inner join purchase_detail n on m.purchase_id = n.purchase_id inner join 
                        vendor o on m.vendor_id = o.vendor_id where purchase_date between @Start and @End";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            cmd.Parameters.AddWithValue("@Start", Convert.ToDateTime(startDatePicker.Value).Date);
            cmd.Parameters.AddWithValue("@End", Convert.ToDateTime(endDatePicker.Value).Date);

            MainClass.con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MainClass.con.Close();
            Print frm = new Print();
            Purchases cr = new Purchases();


            cr.SetDatabaseLogon("sa", "123");
            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void PurchaseReport_Load(object sender, EventArgs e)
        {
            endDatePicker.MinDate = startDatePicker.Value;
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            endDatePicker.MinDate = startDatePicker.Value;
        }
    }
}
