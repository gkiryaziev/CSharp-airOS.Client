using ConfigManager;
using ConnectionManager;
using CryptoManager;
using System;
using System.Text;
using System.Windows.Forms;

namespace AirOSClient
{
    public partial class frmMain : Form
    {
        // client
        SSHClient sshClient = new SSHClient();
        UbntClient ubntClient = new UbntClient();

        // config
        BinaryConfig binaryConfig = new BinaryConfig("config.dat");
        AesCrypto aesCrypto = new AesCrypto(
            Encoding.UTF8.GetBytes("I82XAGa4VfektNos"),
            Encoding.UTF8.GetBytes("d6p75VWsd80ISL0e")
        );

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cirPbSignal.Value = 0;
            cirPbSignal.Text = "0";
            cirPbNoise.Value = 0;
            cirPbNoise.Text = "0";
            cirPbCCQ.Value = 0;
            cirPbCCQ.Text = "0";
            StatusOnDisconnect();

            if (!binaryConfig.Exists())
                CreateDefaultConfig();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            sshClient.Close();
        }

        private void btnCommandSend_Click(object sender, EventArgs e)
        {
            string result = sshClient.Command(txtCommand.Text);
            if (result != "")
            {
                Log(result);
            }
        }

        private void tsBtnRefresh_Click(object sender, EventArgs e)
        {
            GetStatus();
        }

        private void tsBtnConnect_Click(object sender, EventArgs e)
        {
            ConfigModel config = (ConfigModel)binaryConfig.Read();

            if (sshClient.Open(config.Host, config.Port,
                aesCrypto.Dectypt(config.Login), aesCrypto.Dectypt(config.Password)))
            {
                ubntClient.SetSSHClient(sshClient);
                Log("Connected.");
                GetStatus();
                timMain.Interval = config.Interval;
                timMain.Start();
                StatusOnConnect();
            }
        }

        private void tsBtnDisconnect_Click(object sender, EventArgs e)
        {
            timMain.Stop();
            sshClient.Close();
            Log("Disconnected.");
            StatusOnDisconnect();
        }

        private void tsBtnSettingClick(object sender, EventArgs e)
        {
            frmSetting c = new frmSetting();
            c.Open(binaryConfig, aesCrypto);
        }

        private void tsBtnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }

        private async void timMain_Tick(object sender, EventArgs e)
        {
            if (chkBoxSignal.Checked)
            {
                int signal = await ubntClient.GetSignalAsync();
                cirPbSignal.Value = signal + 100;
                cirPbSignal.Text = signal.ToString();
            }

            if (chkBoxNoise.Checked)
            {
                int noise = await ubntClient.GetNoiseFloorAsync();
                cirPbNoise.Value = noise + 100;
                cirPbNoise.Text = noise.ToString();
            }

            if (chkBoxCCQ.Checked)
            {
                int ccq = await ubntClient.GetTransmitCCQAsync();
                cirPbCCQ.Value = ccq;
                cirPbCCQ.Text = ccq.ToString();
            }
        }

        //---------------------------------
        // Get main status
        //---------------------------------
        private void GetStatus()
        {
            lblBaseSSID.Text = ubntClient.GetBaseSSID();
            lblApMac.Text = ubntClient.GetApMAC();
            lblWlanIPAddress.Text = ubntClient.GetWlanIpAddress();
            lblFrequency.Text = ubntClient.GetFrequency() + " MHz";
            lblChannel.Text = ubntClient.GetChannel();
            lblACKTimeout.Text = ubntClient.GetAckTimeout();
            lblTxRate.Text = ubntClient.GetTxRate() + " Mbps";
            lblRxRate.Text = ubntClient.GetRxRate() + " Mbps";
            lblUptime.Text = ubntClient.GetUptimeFormatted();
        }

        //---------------------------------
        // Log
        //---------------------------------
        private void Log(string message)
        {
            txtLog.Text += DateTime.Now.ToString("HH:mm:ss") + " > " + message.TrimEnd('\r', '\n') + Environment.NewLine;
        }

        //---------------------------------
        // Control state on connect
        //---------------------------------
        private void StatusOnConnect()
        {
            tsBtnConnect.Enabled = false;
            tsBtnDisconnect.Enabled = true;
            tsBtnRefresh.Enabled = true;
            tsBtnSetting.Enabled = false;
            btnCommandSend.Enabled = true;
        }

        //---------------------------------
        // Control state on disconnect
        //---------------------------------
        private void StatusOnDisconnect()
        {
            tsBtnConnect.Enabled = true;
            tsBtnDisconnect.Enabled = false;
            tsBtnRefresh.Enabled = false;
            tsBtnSetting.Enabled = true;
            btnCommandSend.Enabled = false;
        }

        //---------------------------------
        // Check if config file exists
        //---------------------------------
        private void CreateDefaultConfig()
        {
            ConfigModel config = new ConfigModel();
            config.Host = "192.168.1.1";
            config.Port = 22;
            config.Login = aesCrypto.Encrypt("admin");
            config.Password = aesCrypto.Encrypt("admin");
            config.Interval = 2000;
            binaryConfig.Write(config);
            Log("Created default config file.");
        }
    }
}
