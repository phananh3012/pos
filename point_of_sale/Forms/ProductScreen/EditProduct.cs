using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace point_of_sale.ProductScreen
{
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }
        public int ID = 0;

        private void saveButton_Click(object sender, EventArgs e)
        {
            string qry = @"update products set product_name = @Name, product_category = @Category, product_price = @Price, 
                    product_brand = @Brand, product_quantity = @Qty, product_unit = @Unit where product_id = @ID";

            Hashtable ht = new Hashtable
            {
                { "@ID", ID },
                { "@Name", nameTB.Text },
                { "@Brand", brandTB.Text },
                { "@Category", categoryCB.SelectedValue },
                { "@Price", priceTB.Text },
                { "@Qty", qtyTB.Text },
                { "@Unit", unitTB.Text }
            };


            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully");
                ID = 0;
                this.Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            if(ID == 0)
            {
                qtyTB.Text = "0";
            }
            qtyTB.Enabled = false;
            nameTB.Enabled = false;
            string qry = "select category_id 'id', category_name 'name' from categories";
            MainClass.CBFill(qry, categoryCB);
        }

        private void priceTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            MainClass.KeyPress(sender, e);
        }
    }
}
