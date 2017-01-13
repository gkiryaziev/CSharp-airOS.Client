using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulletClient
{
    public partial class frmMain : Form
    {
        MySSHClient mySshClient = new MySSHClient();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (mySshClient.Open(txtHost.Text, Convert.ToInt32(txtPort.Text), txtLogin.Text, txtPassword.Text))
            {
                txtLog.Text += "Connected..." + Environment.NewLine;
                timMain.Interval = 1500;
                timMain.Start();
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            timMain.Stop();
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

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            mySshClient.Close();
        }

        private void timMain_Tick(object sender, EventArgs e)
        {
            String result = mySshClient.Command("mca-status | grep signal");
            if (result != "")
            {
                lblSignal.Text = result.TrimEnd(Environment.NewLine.ToCharArray()).Split('=')[1];
            }
        }
    }
}
