using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
namespace InternetTest
{
    
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        } 
        // To Check Internt
        public  bool CheckForInternetConnection()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
        // To Get Ip
        public string GetPublicIpAddress()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://ifconfig.me");
            request.UserAgent = "curl"; // this will tell the server to return the information as if the request was made by the linux "curl" command
            string publicIPAddress;
            request.Method = "GET";
            using (WebResponse response = request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    publicIPAddress = reader.ReadToEnd();
                }
            }
            return publicIPAddress.Replace("\n", "");
        }
        // To Get Ping
        public  string GetPing()
        {
            Ping myPing = new Ping();
            String host = "google.com";
            byte[] buffer = new byte[32];
            int timeout = 1000;
            PingOptions pingOptions = new PingOptions();
            PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
            return $"{reply.RoundtripTime.ToString()}  ms";
        }
        // To Get Gountry
        public void GetCountryByIP()
        {
            string url = "https://ipinfo.io/";
            var request = System.Net.WebRequest.Create(url);
            using (WebResponse wrs = request.GetResponse())
            {
                using (Stream stream = wrs.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string json = reader.ReadToEnd();
                        var obj = JObject.Parse(json);
                        string City = (string)obj["city"];
                        string CountryCode = (string)obj["country"];
                        string timezone = (string)obj["timezone"];
                        lblCity.Text = City;
                        lblCountry.Text = CountryCode;
                        lbltimezone.Text = timezone ;
                    }
                }
            }

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (CheckForInternetConnection())
            {
                panelOne.Visible = false;
                panelOK.Visible = true;
                panelNO.Visible = false;
                lblIp.Text = GetPublicIpAddress();
                lblping.Text = GetPing();
                GetCountryByIP();
            }
            else
            {
                panelOne.Visible = false;
                panelOK.Visible = false;
                panelNO.Visible = true;

            }
        }
    }
}
