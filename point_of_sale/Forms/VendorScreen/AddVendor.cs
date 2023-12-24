using System;
using System.Collections;
using System.Windows.Forms;

namespace point_of_sale.VendorScreen
{
    public partial class AddVendor : Form
    {
        public AddVendor()
        {
            InitializeComponent();
        }
        public int id = 0;

        private void saveButton_Click(object sender, EventArgs e)
        {
            string qry;
            if (id == 0) //insert
            {
                qry = "insert into vendor values(@Name, @Phone, @Email, @Address)";
            }
            else //update
            {
                qry = "update vendor set vendor_name = @Name, vendor_phone = @Phone, vendor_email = @Email, vendor_address = @Address where vendor_id = @id";
            }
            Hashtable ht = new Hashtable
            {
                { "@id", id },
                { "@Name", nameTextBox.Text },
                { "@Phone", phoneTextBox.Text },
                { "@Email", emailTextBox.Text },
                { "@Address", addressTB.Text }
            };


            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully");
                id = 0;
                nameTextBox.Text = "";
                phoneTextBox.Text = "";
                emailTextBox.Text = "";
                addressTB.Text = "";
                nameTextBox.Focus();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MainClass.KeyPress(sender, e);
        }
    }
}
