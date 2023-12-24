using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace point_of_sale.CustomerScreen
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        public int id = 0;
        public int point;
        public void saveButton_Click(object sender, EventArgs e)
        {
            string qry;
            if (id == 0) //insert
            {
                qry = @"insert into users values(@Phone, 1, 'Customer');
                         select SCOPE_IDENTITY()";
            }
            else //update
            {
                qry = @"update customers set customer_phone = @Phone, customer_name = @Name, customer_point = @Point
                    where customer_id =" + id + "";
            }
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            cmd.Parameters.AddWithValue("@Phone", phoneTextBox.Text);
            cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
            cmd.Parameters.AddWithValue("@Point", Convert.ToInt64(pointTB.Text));
            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            int userID = Convert.ToInt32(cmd.ExecuteScalar());
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }
            if(id == 0)
            {
                string qry1 = "insert into customers values(@Name, @Phone, 0, @UserID)";
                Hashtable ht = new Hashtable
                {
                    { "@Name", nameTextBox.Text },
                    { "@Phone", phoneTextBox.Text },
                    { "@Point", Convert.ToInt64(pointTB.Text) },
                    { "@UserID", userID }
                };
                MainClass.SQL(qry1, ht);
            }
            MessageBox.Show("Saved Successfully");
            this.Close();
  
    }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            pointTB.Text = point.ToString();
            pointTB.Enabled = false;
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MainClass.KeyPress(sender, e);
        }
    }
}
