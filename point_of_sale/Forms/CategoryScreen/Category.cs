using System;
using System.Collections;
using System.Windows.Forms;

namespace point_of_sale
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = $"select * from categories where category_name like '%{searchBar.Text}%'";
            ListBox lb = new ListBox();
            lb.Items.Add(categoryID);
            lb.Items.Add(categoryName);
            MainClass.LoadData(qry, categoryGridView,lb);
        }

        private void Category_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void searchBar_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void newCategoryButton_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new AddCategory());
            GetData();
        }

        private void categoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(categoryGridView.CurrentCell.OwningColumn.Name == "editButton")
            {
                AddCategory frm = new AddCategory
                {
                    id = Convert.ToInt32(categoryGridView.CurrentRow.Cells["categoryID"].Value)
                };
                frm.categoryName.Text = Convert.ToString(categoryGridView.CurrentRow.Cells["categoryName"].Value);
                MainClass.BlurBackground(frm);
                GetData();
            }
            if (categoryGridView.CurrentCell.OwningColumn.Name == "deleteButton")
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete", "Confirm Delete!!", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes) 
                {
                    int id = Convert.ToInt32(categoryGridView.CurrentRow.Cells["categoryID"].Value);
                    string qry = "delete from categories where category_id =" + id + "";
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
