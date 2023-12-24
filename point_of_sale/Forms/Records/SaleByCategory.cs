using point_of_sale.POSScreen;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace point_of_sale.Reports
{
    public partial class SaleByCategory : Form
    {
        public SaleByCategory()
        {
            InitializeComponent();
        }
        //category_name, qty, price, _sum, order_date, order_time, product_name
        private void printButton_Click(object sender, EventArgs e)
        {
            string qry = @"select * from orders m inner join order_detail n on m.order_id = n.order_id inner join products o on n.product_id = o.product_id
                        inner join categories p on p.category_id = product_category where order_date between @Start and @End";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            cmd.Parameters.AddWithValue("@Start", Convert.ToDateTime(startDatePicker.Value).Date);
            cmd.Parameters.AddWithValue("@End", Convert.ToDateTime(endDatePicker.Value).Date);

            MainClass.con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MainClass.con.Close();
            Print frm = new Print();
            ByCategory cr = new ByCategory();


            cr.SetDatabaseLogon("sa", "123");
            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaleByCategory_Load(object sender, EventArgs e)
        {
            endDatePicker.MinDate = startDatePicker.Value;
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            endDatePicker.MinDate = startDatePicker.Value;
        }
    }
}
