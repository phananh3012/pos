using point_of_sale.CustomerScreen;
using System;
using System.Windows.Forms;

namespace point_of_sale.POSScreen
{
    public partial class CustomerOrder : Form
    {
        public CustomerOrder()
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

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void customerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customerGridView.CurrentCell.OwningColumn.Name == "pickButton")
            {
                MainClass.CUSTOMER_ID = customerGridView.CurrentRow.Cells["customerID"].Value.ToString();
                MainClass.CUSTOMER_POINTS = customerGridView.CurrentRow.Cells["customerPoint"].Value.ToString();
                MessageBox.Show("Customer is set");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
