using System;
using System.Collections;
using System.Windows.Forms;

namespace point_of_sale.EmployeeScreen
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }
        public int id = 0;
        public void saveButton_Click(object sender, EventArgs e)
        {
            string qry;
            if (id == 0) //insert
            {
                qry = "insert into employees values(@Name, @Position, @Phone, @Email, null )";
            }
            else //update
            {
                qry = "update employees set employee_name = @Name, employee_phone = @Phone, employee_email = @Email, employee_position = @Position where employee_id = @id";
            }
            Hashtable ht = new Hashtable
            {
                { "@id", id },
                { "@Name", nameTextBox.Text },
                { "@Position", positionComboBox.Text },
                { "@Phone", phoneTextBox.Text },
                { "@Email", emailTextBox.Text }
            };


            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully");
                id = 0;
                this.Close();
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
