using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace point_of_sale
{
    class MainClass
    {
        public static readonly string con_string = "Data Source = NAMNP-2020\\SQLEXPRESS; Initial Catalog = POS; Integrated Security = True";
        public static SqlConnection con = new SqlConnection(con_string);

        //check user validation
        public static bool isValidUser(string user, string pass)
        {
            bool isValid = false;
            string qry = $"select * from users where username = '{user}' and user_password = '{pass}'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0 ) 
            { 
                isValid = true;
                USER = dt.Rows[0]["username"].ToString();
                USER_ID = dt.Rows[0]["userid"].ToString();
            }

            return isValid;
        }

        //create propety for username
        public static string user;
        public static string user_id;
        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }
        public static string USER_ID
        {
            get { return user_id; }
            private set { user_id = value; }
        }

        //method for crud operation
        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if(con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            return res;
        }

        //load data from database
        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for(int i=0;i<lb.Items.Count;i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();
                }
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using(Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = MainForm.Instance.Size;
                Background.Location = MainForm.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();

            }
        }
        //for cb fill
        public static void CBFill(string qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource= dt;
            cb.SelectedIndex = -1;
        }
        public static string CUSTOMER_ID = null;
        public static string CUSTOMER_POINTS;
        public static void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {

            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }
    }
}
