using System;
using System.Collections;
using System.Windows.Forms;

namespace point_of_sale.VendorScreen
{
    public partial class VendorList : Form
    {
        public VendorList()
        {
            InitializeComponent();
        }
        public int MainID;
        public void GetData()
        {
            string qry = $"select * from vendor_products where vendor_id ={MainID} and product_name like '%{searchBar.Text}%'";
            ListBox lb = new ListBox();
            lb.Items.Add(productID);
            lb.Items.Add(vendorID);
            lb.Items.Add(productName);
            lb.Items.Add(productCost);
            lb.Items.Add(productUnit);
            MainClass.LoadData(qry, vpGridView, lb);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            AddVendorProduct frm = new AddVendorProduct
            {
                MainID = MainID
            };
            MainClass.BlurBackground(frm);
            GetData();
        }

        private void VendorList_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void vpGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vpGridView.CurrentCell.OwningColumn.Name == "editButton")
            {
                AddVendorProduct frm = new AddVendorProduct
                {
                    id = Convert.ToInt32(vpGridView.CurrentRow.Cells["productID"].Value),
                    MainID = Convert.ToInt32(vpGridView.CurrentRow.Cells["vendorID"].Value)
                };
                frm.nameTextBox.Text = Convert.ToString(vpGridView.CurrentRow.Cells["productName"].Value);
                frm.costTB.Text = Convert.ToString(vpGridView.CurrentRow.Cells["productCost"].Value);
                frm.unitTB.Text = Convert.ToString(vpGridView.CurrentRow.Cells["productUnit"].Value);

                MainClass.BlurBackground(frm);
                GetData();
            }
            if (vpGridView.CurrentCell.OwningColumn.Name == "deleteButton")
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete", "Confirm Delete!!", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(vpGridView.CurrentRow.Cells["productID"].Value);
                    string qry = $"delete from vendor_products where vp_id ={id}";
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
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            UploadProduct frm = new UploadProduct
            {
                MainID = MainID
            };
            frm.Show();
        }
    }
}
