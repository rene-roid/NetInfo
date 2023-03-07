namespace NetSpy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            iphost.Text += " " + GetData.GetLocalIpAddress();
            ipgateway.Text += " " + GetData.GetDefaultGateway();
            macaddress.Text += " " + GetData.GetMacAddress();

            ssid.Text += " " + GetData.GetSSID();
            ssidstatus.Text += " " + GetData.GetSSIDStatus();

            internetconnection.Text += " " + GetData.GetConnection();

            username.Text += " " + GetData.GetCurrentUserUsername();
            hostname.Text += " " + GetData.GetOSName();

            virtualbox.Text += " " + GetData.VirtualBoxInstalled();
            virtualboxversion.Text += " " + GetData.VirtualBoxVersion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iphost_Click(object sender, EventArgs e)
        {

        }
    }
}