using point_of_sale.CustomerScreen;
using point_of_sale.EmployeeScreen;
using point_of_sale.OrderScreen;
using point_of_sale.POSScreen;
using point_of_sale.ProductScreen;
using point_of_sale.PurchaseScreen;
using point_of_sale.Reports;
using point_of_sale.UsersScreen;
using point_of_sale.VendorScreen;
using System;
using System.Windows.Forms;

namespace point_of_sale
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // for accessing main form
        static MainForm _obj;
        public static MainForm Instance 
        { 
            get { if (_obj == null) { _obj = new MainForm(); } return _obj; }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = MainClass.USER;
            _obj = this;
            if(MainClass.USER != "admin")
            {
                purchaseButton.Enabled = false;
                employeeButton.Enabled = false;
                vendorButton.Enabled = false;
                usersButton.Enabled = false;
                categoryButton.Enabled = false;
            }
        }

        //add controls in mainform
        public void AddControls(Form f)
        {
            controlPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            controlPanel.Controls.Add(f);
            f.Show();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            AddControls(new Category());
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            AddControls(new Customer());
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            AddControls(new Employee());
        }


        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Close();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            AddControls(new Order());
        }


        private void reportsButton_Click(object sender, EventArgs e)
        {
            AddControls(new Record());
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            AddControls(new Users());
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            AddControls(new Product());
        }

        private void vendorButton_Click(object sender, EventArgs e)
        {
            AddControls(new Vendor());
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            AddControls(new Purchase());
        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            POS frm = new POS();
            frm.Show();
        }
    }
}
