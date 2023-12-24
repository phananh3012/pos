using System;
using System.Collections;
using System.Windows.Forms;

namespace point_of_sale.EmployeeScreen
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = $"select * from employees where employee_name like '%{searchBar.Text}%'";
            ListBox lb = new ListBox();
            lb.Items.Add(employeeID);
            lb.Items.Add(employeeName);
            lb.Items.Add(employeePosition);
            lb.Items.Add(employeePhone);
            lb.Items.Add(employeeEmail);
            lb.Items.Add(userID);

            MainClass.LoadData(qry, employeeGridView, lb);
        }

        private void newEmployeeButton_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new AddEmployee());
            GetData();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void searchBar_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void employeeGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employeeGridView.CurrentCell.OwningColumn.Name == "editButton")
            {
                AddEmployee frm = new AddEmployee
                {
                    id = Convert.ToInt32(employeeGridView.CurrentRow.Cells["employeeID"].Value)
                };
                frm.nameTextBox.Text = Convert.ToString(employeeGridView.CurrentRow.Cells["employeeName"].Value);
                frm.positionComboBox.Text = Convert.ToString(employeeGridView.CurrentRow.Cells["employeePosition"].Value);
                frm.phoneTextBox.Text = Convert.ToString(employeeGridView.CurrentRow.Cells["employeePhone"].Value);
                frm.emailTextBox.Text = Convert.ToString(employeeGridView.CurrentRow.Cells["employeeEmail"].Value);
                MainClass.BlurBackground(frm);
                GetData();
            }
            if (employeeGridView.CurrentCell.OwningColumn.Name == "deleteButton")
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete", "Confirm Delete!!", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(employeeGridView.CurrentRow.Cells["employeeID"].Value);
                    string qry = $"delete from employees where employee_id = {id}";
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
