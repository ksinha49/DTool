using System;
using System.Text;
using System.Windows.Forms;

namespace Minor_Project_MAS
{
    public partial class GPS_system1 : Form
    {
        public GPS_system1(string lat, string lon)
        {
            InitializeComponent();
            if (lat == string.Empty || lon == string.Empty)
            {
                this.Dispose();
            }
            try
            {
                StringBuilder queryAddress = new StringBuilder();
                queryAddress.Append("http://maps.google.com/maps?q=");
                if (lat != string.Empty)
                {
                    queryAddress.Append(lat + "%2C");
                }
                if (lon != string.Empty)
                {
                    queryAddress.Append(lon);
                }
                webBrowser1.Navigate(queryAddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");

            }
        }
    }
}
