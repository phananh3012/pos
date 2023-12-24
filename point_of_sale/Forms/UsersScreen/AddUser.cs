using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace point_of_sale.UsersScreen
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        public int userID = 0;
        private void saveButton_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (userID == 0) //insert
            {
                qry = "insert into users values(@Username, @Password, @Type)";
            }
            else //update
            {
                qry = "update users set username = @Username, user_password = @Password, user_type = @Type where userid = @UserID;" +
                    "update employees set userid = @UserID where employee_id = @EmployeeID ";
            }
            Hashtable ht = new Hashtable
            {
                { "@UserID", userID },
                { "@Username", nameTB.Text },
                { "@Password", passwordTB.Text },
                { "@Type", typeCB.GetItemText(typeCB.SelectedItem) },
                { "@EmployeeID", Convert.ToInt32(employeeCB.SelectedValue) }
            };


            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully");
                nameTB.Text = "";
                employeeCB.Text = "";
                passwordTB.Text = "";
                typeCB.Text = "";
                nameTB.Focus();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            //for cb fill
            string qry = "select employee_id 'id', employee_name 'name', userid from employees";
            MainClass.CBFill(qry, employeeCB);
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                if (row["userid"] != (object)DBNull.Value)
                {
                    if (userID > 0 && userID == Convert.ToInt32(row["userid"])) // for update
                    {
                        employeeCB.SelectedValue = row["id"];
                    }
                }
            }
            UpdateLoadData();
        }
        private void UpdateLoadData()
        {
            string qry = $"select * from users where userid = {userID}";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                nameTB.Text = dt.Rows[0]["username"].ToString();
                passwordTB.Text = dt.Rows[0]["user_password"].ToString();
                typeCB.Text = dt.Rows[0]["user_type"].ToString();
            }
        }
    }
}
