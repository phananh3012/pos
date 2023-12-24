using System;
using System.Collections;
using System.Windows.Forms;

namespace point_of_sale
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }
        public int id = 0;
        public void saveButton_Click(object sender, EventArgs e)
        {
            if(categoryName.Text == "")
            {
                MessageBox.Show("Info cannot be null");
            }
            else
            {
                string qry;
                if (id == 0) //insert
                {
                    qry = "insert into categories values(@Name)";
                }
                else //update
                {
                    qry = "update categories set category_name = @Name where category_id = @id";
                }
                Hashtable ht = new Hashtable
                {
                    { "@id", id },
                    { "@Name", categoryName.Text }
                };

                if (MainClass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Saved successfully");
                    id = 0;
                    categoryName.Text = "";
                    categoryName.Focus();
                }
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
