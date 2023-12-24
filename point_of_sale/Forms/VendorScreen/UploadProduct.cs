using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace point_of_sale.VendorScreen
{
    public partial class UploadProduct : Form
    {
        public UploadProduct()
        {
            InitializeComponent();
        }
        public int MainID;
        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dlg.FileName;
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string PathCon = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={txtPath.Text};Extended Properties = Excel 8.0";
                OleDbConnection con = new OleDbConnection(PathCon);
                OleDbDataAdapter da = new OleDbDataAdapter($"select * from [{txtName.Text}$]", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                productsGV.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Enter Worksheet name");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in productsGV.Rows)
            {
                string qry = "insert into vendor_products values(@ID, @Name, @Cost, @Unit)";
                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                cmd.Parameters.AddWithValue("@ID", MainID);
                cmd.Parameters.AddWithValue("@Name", row.Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@Cost", Convert.ToDouble(row.Cells[1].Value));
                cmd.Parameters.AddWithValue("@Unit", row.Cells[2].Value.ToString());
                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd.ExecuteNonQuery();
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }
            }
            MessageBox.Show("Save successfully");
            txtName.Clear();
            txtPath.Clear();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
