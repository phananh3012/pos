using System;
using System.Collections;
using System.Windows.Forms;

namespace point_of_sale.UsersScreen
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = $"select * from users where username like '%{searchBar.Text}%'";
            ListBox lb = new ListBox();
            lb.Items.Add(userID);
            lb.Items.Add(userName);
            lb.Items.Add(userPassword);
            lb.Items.Add(userType);
            MainClass.LoadData(qry, usersGridView, lb);
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new AddUser());
            GetData();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void usersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (usersGridView.CurrentCell.OwningColumn.Name == "editButton")
            {
                AddUser frm = new AddUser
                {
                    userID = Convert.ToInt32(usersGridView.CurrentRow.Cells["userID"].Value)
                };
                if (usersGridView.CurrentRow.Cells["userType"].Value.ToString() == "Customer")
                {
                    frm.employeeCB.Enabled = false;
                }               
                MainClass.BlurBackground(frm);
                GetData();
            }
            if (usersGridView.CurrentCell.OwningColumn.Name == "deleteButton")
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete", "Confirm Delete!!", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(usersGridView.CurrentRow.Cells["userID"].Value);
                    string qry = $"delete from users where userid = {id}";
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
