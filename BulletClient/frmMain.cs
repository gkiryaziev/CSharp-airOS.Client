using ConfigManager;
using CryptoManager;
using System;
using System.Text;
using System.Windows.Forms;

namespace BulletClient
{
    public partial class frmMain : Form
    {
        MySSHClient mySshClient = new MySSHClient();
        MyUbntClient myUbntClient = new MyUbntClient();

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
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            mySshClient.Close();
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            String result = mySshClient.Command(txtCommand.Text);
            if (result != "")
            {
                txtLog.Text += result + Environment.NewLine;
            }
        }        

        private void tsBtnRefresh_Click(object sender, EventArgs e)
        {
            GetStatus();
        }

        private void tsBtnConnect_Click(object sender, EventArgs e)
        {
            ConfigModel config = (ConfigModel)binaryConfig.Read();

            if (mySshClient.Open(config.Host, config.Port,
                aesCrypto.Dectypt(config.Login), aesCrypto.Dectypt(config.Password)))
            {
                myUbntClient.SetSSHClient(mySshClient);
                txtLog.Text += "Connected..." + Environment.NewLine;
                GetStatus();
                timMain.Interval = config.Interval;
                timMain.Start();
            }
        }

        private void tsBtnDisconnect_Click(object sender, EventArgs e)
        {
            timMain.Stop();
            mySshClient.Close();
        }

        private void tsBtnConfig_Click(object sender, EventArgs e)
        {
            frmConfig c = new frmConfig();
            c.Open(binaryConfig, aesCrypto);
        }

        private void timMain_Tick(object sender, EventArgs e)
        {
            if (chkBoxSignal.Checked)
            {
                int signal = myUbntClient.GetSignal();
                cirPbSignal.Value = signal + 100;
                cirPbSignal.Text = signal.ToString();
            }

            if (chkBoxNoise.Checked)
            {
                int noise = myUbntClient.GetNoiseFloor();
                cirPbNoise.Value = noise + 100;
                cirPbNoise.Text = noise.ToString();
            }

            if (chkBoxCCQ.Checked)
            {
                int ccq = myUbntClient.GetTransmitCCQ();
                cirPbCCQ.Value = ccq;
                cirPbCCQ.Text = ccq.ToString();
            }
        }

        private void GetStatus()
        {
            lblBaseSSID.Text = myUbntClient.GetBaseSSID();
            lblApMac.Text = myUbntClient.GetApMAC();
            lblWlanIPAddress.Text = myUbntClient.GetWlanIpAddress();
            lblFrequency.Text = myUbntClient.GetFrequency() + " MHz";
            lblChannel.Text = myUbntClient.GetChannel();
            lblACKTimeout.Text = myUbntClient.GetAckTimeout();
            lblTxRate.Text = myUbntClient.GetTxRate() + " Mbps";
            lblRxRate.Text = myUbntClient.GetRxRate() + " Mbps";
            lblUptime.Text = myUbntClient.GetUptimeFormatted();
        }
    }
}
