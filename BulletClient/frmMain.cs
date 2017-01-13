﻿using System;
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
        MyUbntClient myUbntClient = new MyUbntClient();

        public frmMain()
        {
            InitializeComponent();
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

        private void timMain_Tick(object sender, EventArgs e)
        {
            int signal = myUbntClient.GetSignal();
            cirPbSignal.Value = signal + 100;
            cirPbSignal.Text = signal.ToString();

            int noise = myUbntClient.GetNoiseFloor();
            cirPbNoise.Value = noise + 100;
            cirPbNoise.Text = noise.ToString();

            int ccq = myUbntClient.GetTransmitCCQ();
            cirPbCCQ.Value = ccq;
            cirPbCCQ.Text = ccq.ToString();
        }

        private void tsBtnRefresh_Click(object sender, EventArgs e)
        {
            GetStatus();
        }

        private void GetStatus()
        {
            lblBaseSSID.Text = myUbntClient.GetBaseSSID();
            lblApMac.Text = myUbntClient.GetApMAC();
            lblWlanIPAddress.Text = myUbntClient.GetWlanIpAddress();
            lblFrequency.Text = myUbntClient.GetFrequency();
            lblChannel.Text = myUbntClient.GetChannel();
            lblACKTimeout.Text = myUbntClient.GetAckTimeout();
            lblTxRate.Text = myUbntClient.GetTxRate();
            lblRxRate.Text = myUbntClient.GetRxRate();
            lblUptime.Text = myUbntClient.GetUptimeFormatted();
        }

        private void tsBtnConnect_Click(object sender, EventArgs e)
        {
            if (mySshClient.Open(txtHost.Text, Convert.ToInt32(txtPort.Text), txtLogin.Text, txtPassword.Text))
            {
                myUbntClient.SetSSHClient(mySshClient);
                txtLog.Text += "Connected..." + Environment.NewLine;
                GetStatus();
                timMain.Interval = 1500;
                timMain.Start();
            }
        }

        private void tsBtnDisconnect_Click(object sender, EventArgs e)
        {
            timMain.Stop();
            mySshClient.Close();
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
    }
}
