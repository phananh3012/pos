using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace point_of_sale.POSScreen
{
    public partial class QR : Form
    {
        public QR()
        {
            InitializeComponent();
        }
        public double amount;

        private void QR_Load(object sender, EventArgs e)
        {
            var request = WebRequest.Create("https://img.vietqr.io/image/tpbank-90099009701-qr_only.png?amount="+amount+"&addInfo=AT%2024MART&accountName=NGUYEN%20PHAN%20ANH");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                qrPic.Image = Bitmap.FromStream(stream);
            }
        }

        private void qrPic_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
