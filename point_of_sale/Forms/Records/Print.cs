using System;
using System.Windows.Forms;

namespace point_of_sale.POSScreen
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
