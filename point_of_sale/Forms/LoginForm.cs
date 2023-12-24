using point_of_sale.ProductScreen;
using System;
using System.Windows.Forms;

namespace point_of_sale
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please enter log in info");
            }
            else
            {
                if (MainClass.isValidUser(usernameTextBox.Text, passwordTextBox.Text) == false)
                {
                    MessageBox.Show("Invalid username or password!!!");
                    return;
                }
                else
                {
                    MainForm frm = new MainForm();
                    frm.AddControls(new Product());
                    frm.Show();
                    this.Hide();
                }
            }

        }
    }
}
