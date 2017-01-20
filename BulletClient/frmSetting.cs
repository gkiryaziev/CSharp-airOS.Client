using ConfigManager;
using CryptoManager;
using System;
using System.Windows.Forms;

namespace BulletClient
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        BinaryConfig _config;
        AesCrypto _crypto;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            LoadConfig();
        }

        //---------------------------------
        // Load config from file
        //---------------------------------
        private void LoadConfig()
        {
            ConfigModel config = (ConfigModel)_config.Read();
            txtHost.Text = config.Host;
            txtPort.Text = config.Port.ToString();
            txtLogin.Text = _crypto.Dectypt(config.Login);
            txtPassword.Text = _crypto.Dectypt(config.Password);
            txtInterval.Text = config.Interval.ToString();
        }

        //---------------------------------
        // Open form
        //---------------------------------
        public void Open(BinaryConfig config, AesCrypto crypto)
        {
            _config = config;
            _crypto = crypto;
            this.ShowDialog();
        }
    }
}
