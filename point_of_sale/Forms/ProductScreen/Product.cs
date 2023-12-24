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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = @"select product_id, m.product_name, product_brand, category_name, product_price, product_quantity, product_unit, product_barcode,
                         category_id, vendor_id from products m inner join categories on category_id = product_category inner join vendor_products n on product_id = vp_id
                         where m.product_name like '%" + searchBar.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(productID);
            lb.Items.Add(productName);
            lb.Items.Add(productBrand);
            lb.Items.Add(productCategory);
            lb.Items.Add(productPrice);
            lb.Items.Add(productQty);
            lb.Items.Add(productUnit);
            lb.Items.Add(productBarcode);
            lb.Items.Add(categoryID);
            lb.Items.Add(vendorID);
            MainClass.LoadData(qry, productGV, lb);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new EditProduct());
            GetData();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void productGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productGV.CurrentCell.OwningColumn.Name == "editButton")
            {
                EditProduct frm = new EditProduct
                {
                    ID = Convert.ToInt32(productGV.CurrentRow.Cells["productID"].Value)
                };
                frm.nameTB.Text = Convert.ToString(productGV.CurrentRow.Cells["productName"].Value);
                frm.brandTB.Text = Convert.ToString(productGV.CurrentRow.Cells["productBrand"].Value);
                frm.categoryCB.Text = Convert.ToString(productGV.CurrentRow.Cells["productCategory"].Value);
                frm.priceTB.Text = Convert.ToString(productGV.CurrentRow.Cells["productPrice"].Value);
                frm.qtyTB.Text = Convert.ToString(productGV.CurrentRow.Cells["productQty"].Value);
                frm.unitTB.Text = Convert.ToString(productGV.CurrentRow.Cells["productUnit"].Value);

                MainClass.BlurBackground(frm);
                GetData();
            }
            if (productGV.CurrentCell.OwningColumn.Name == "deleteButton")
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete", "Confirm Delete!!", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(productGV.CurrentRow.Cells["productID"].Value);
                    string qry = "delete from products where product_id =" + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(qry, ht);
                    MessageBox.Show("Delete Successfully!");
                    GetData();
                }
                else
                {
                    return;
                }
            }
            if (productGV.CurrentCell.OwningColumn.Name == "barcodeButton")
            {
                string pid = productGV.CurrentRow.Cells["productID"].Value.ToString();
                for(int i=0; pid.Length < 4; i++)
                {
                    pid = "0" + pid;
                }
                string cid = productGV.CurrentRow.Cells["categoryID"].Value.ToString();
                for (int i = 0; cid.Length < 4; i++)
                {
                    cid = "0" + cid;
                }
                string vid = productGV.CurrentRow.Cells["vendorID"].Value.ToString();
                for (int i = 0; vid.Length < 4; i++)
                {
                    vid = "0" + vid;
                }
                string qry = $"update products set product_barcode = @Barcode where product_id ={pid}";
                Hashtable ht = new Hashtable
                {
                    { "@Barcode", pid + cid + vid }
                };
                MainClass.SQL(qry, ht);
                MessageBox.Show("Generate Barcode Successfully!");
                GetData();
            }
        }
    }
}
