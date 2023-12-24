using System;
using System.Collections;
using System.Windows.Forms;

namespace point_of_sale.VendorScreen
{
    public partial class Vendor : Form
    {
        public Vendor()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = $"select * from vendor where vendor_name like '%{searchBar.Text}%'";
            ListBox lb = new ListBox();
            lb.Items.Add(vendorID);
            lb.Items.Add(vendorName);
            lb.Items.Add(vendorPhone);
            lb.Items.Add(vendorEmail);
            lb.Items.Add(vendorAddress);
            MainClass.LoadData(qry, vendorGridView, lb);
        }

        private void newVendorButton_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new AddVendor());
            GetData();
        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void vendorGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vendorGridView.CurrentCell.OwningColumn.Name == "editButton")
            {
                AddVendor frm = new AddVendor
                {
                    id = Convert.ToInt32(vendorGridView.CurrentRow.Cells["vendorID"].Value)
                };
                frm.nameTextBox.Text = Convert.ToString(vendorGridView.CurrentRow.Cells["vendorName"].Value);
                frm.phoneTextBox.Text = Convert.ToString(vendorGridView.CurrentRow.Cells["vendorPhone"].Value);
                frm.emailTextBox.Text = Convert.ToString(vendorGridView.CurrentRow.Cells["vendorEmail"].Value);
                frm.addressTB.Text = Convert.ToString(vendorGridView.CurrentRow.Cells["vendorAddress"].Value);

                MainClass.BlurBackground(frm);
                GetData();
            }
            if (vendorGridView.CurrentCell.OwningColumn.Name == "deleteButton")
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete", "Confirm Delete!!", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(vendorGridView.CurrentRow.Cells["vendorID"].Value);
                    string qry = $"delete from vendor where vendor_id ={id}";
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
            if (vendorGridView.CurrentCell.OwningColumn.Name == "listButton")
            {
                VendorList frm = new VendorList
                {
                    MainID = Convert.ToInt32(vendorGridView.CurrentRow.Cells["vendorID"].Value)
                };
                MainClass.BlurBackground(frm);            
            }
        }
    }
}
