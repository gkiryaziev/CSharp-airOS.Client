using ConfigManager;
using CryptoManager;
using System;
using System.Windows.Forms;

namespace BulletClient
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        BinaryConfig _config;
        AesCrypto _crypto;

        public void Open(BinaryConfig config, AesCrypto crypto)
        {
            _config = config;
            _crypto = crypto;
            this.ShowDialog();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadConfig();
        }

        private void ReadConfig()
        {
            ConfigModel config = (ConfigModel)_config.Read();
            txtHost.Text = config.Host;
            txtPort.Text = config.Port.ToString();
            txtLogin.Text = _crypto.Dectypt(config.Login);
            txtPassword.Text = _crypto.Dectypt(config.Password);
            txtInterval.Text = config.Interval.ToString();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            ConfigModel config = new ConfigModel();
            config.Host = txtHost.Text;
            config.Port = Convert.ToInt32(txtPort.Text);
            config.Login = _crypto.Encrypt(txtLogin.Text);
            config.Password = _crypto.Encrypt(txtPassword.Text);
            config.Interval = Convert.ToInt32(txtInterval.Text);
            _config.Write(config);
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            ReadConfig();
        }
    }
}
