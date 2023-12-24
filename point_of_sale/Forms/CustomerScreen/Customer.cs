using System;
using System.Collections;
using System.Windows.Forms;

namespace point_of_sale.CustomerScreen
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = $"select * from customers where customer_phone like '%{searchBar.Text}%'";
            ListBox lb = new ListBox();
            lb.Items.Add(customerID);
            lb.Items.Add(customerName);
            lb.Items.Add(customerPhone);
            lb.Items.Add(customerPoint);
            lb.Items.Add(userID);
            MainClass.LoadData(qry, customerGridView, lb);
        }
        private void newCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomer frm = new AddCustomer();
            MainClass.BlurBackground(frm);
            GetData();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void searchBar_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
        private void customerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customerGridView.CurrentCell.OwningColumn.Name == "editButton")
            {
                AddCustomer frm = new AddCustomer
                {
                    id = Convert.ToInt32(customerGridView.CurrentRow.Cells["customerID"].Value),
                    point = Convert.ToInt32(customerGridView.CurrentRow.Cells["customerPoint"].Value)
                };
                frm.nameTextBox.Text = Convert.ToString(customerGridView.CurrentRow.Cells["customerName"].Value);
                frm.phoneTextBox.Text = Convert.ToString(customerGridView.CurrentRow.Cells["customerPhone"].Value);
                MainClass.BlurBackground(frm);
                GetData();
            }
            if (customerGridView.CurrentCell.OwningColumn.Name == "deleteButton")
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete", "Confirm Delete!!", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(customerGridView.CurrentRow.Cells["customerID"].Value);
                    string qry = $"delete from customers where customer_id = {id}";
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
    }
}
