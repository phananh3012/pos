using System;
using System.Collections;
using System.Windows.Forms;

namespace point_of_sale.VendorScreen
{
    public partial class AddVendorProduct : Form
    {
        public AddVendorProduct()
        {
            InitializeComponent();
        }
        public int id = 0;
        public int MainID;

        private void saveButton_Click(object sender, EventArgs e)
        {
            string qry;
            if (id == 0) //insert
            {
                qry = "insert into vendor_products values(@Vendor, @Name, @Cost, @Unit)";
            }
            else //update
            {
                qry = "update vendor_products set product_name = @Name, cost = @Cost, unit = @Unit where vp_id = @id";
            }
            Hashtable ht = new Hashtable
            {
                { "@id", id },
                { "@Vendor", MainID },
                { "@Name", nameTextBox.Text },
                { "@Cost", costTB.Text },
                { "@Unit", unitTB.Text }
            };


            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully");
                id = 0;
                nameTextBox.Text = "";
                costTB.Text = "";
                unitTB.Text = "";
                nameTextBox.Focus();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void costTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            MainClass.KeyPress(sender, e);
        }
    }
}
