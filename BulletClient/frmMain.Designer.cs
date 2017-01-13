namespace BulletClient
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnCommand = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblSignal = new System.Windows.Forms.Label();
            this.timMain = new System.Windows.Forms.Timer(this.components);
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.lblApMac = new System.Windows.Forms.Label();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.lblBaseSSID = new System.Windows.Forms.Label();
            this.lblUptime = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.lblACKTimeout = new System.Windows.Forms.Label();
            this.lblTxRate = new System.Windows.Forms.Label();
            this.lblRxRate = new System.Windows.Forms.Label();
            this.lblWlanIPAddress = new System.Windows.Forms.Label();
            this.grbStatus.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(29, 80);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(418, 20);
            this.txtCommand.TabIndex = 0;
            this.txtCommand.Text = "mca-status | grep signal";
            // 
            // btnCommand
            // 
            this.btnCommand.Location = new System.Drawing.Point(453, 79);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(154, 23);
            this.btnCommand.TabIndex = 1;
            this.btnCommand.Text = "Command";
            this.btnCommand.UseVisualStyleBackColor = true;
            this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 368);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(578, 61);
            this.txtLog.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(453, 53);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(534, 53);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(73, 23);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(29, 54);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(139, 20);
            this.txtHost.TabIndex = 5;
            this.txtHost.Text = "***REMOVED***";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(174, 54);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(51, 20);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "22";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(231, 54);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(84, 20);
            this.txtLogin.TabIndex = 7;
            this.txtLogin.Text = "***REMOVED***";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(321, 54);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(71, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "***REMOVED***";
            // 
            // lblSignal
            // 
            this.lblSignal.AutoSize = true;
            this.lblSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSignal.Location = new System.Drawing.Point(29, 103);
            this.lblSignal.Name = "lblSignal";
            this.lblSignal.Size = new System.Drawing.Size(43, 46);
            this.lblSignal.TabIndex = 9;
            this.lblSignal.Text = "0";
            // 
            // timMain
            // 
            this.timMain.Tick += new System.EventHandler(this.timMain_Tick);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(398, 54);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(49, 20);
            this.txtInterval.TabIndex = 10;
            this.txtInterval.Text = "1500";
            // 
            // grbStatus
            // 
            this.grbStatus.Controls.Add(this.lblWlanIPAddress);
            this.grbStatus.Controls.Add(this.lblRxRate);
            this.grbStatus.Controls.Add(this.lblTxRate);
            this.grbStatus.Controls.Add(this.lblACKTimeout);
            this.grbStatus.Controls.Add(this.lblChannel);
            this.grbStatus.Controls.Add(this.lblFrequency);
            this.grbStatus.Controls.Add(this.lblUptime);
            this.grbStatus.Controls.Add(this.lblBaseSSID);
            this.grbStatus.Controls.Add(this.lblApMac);
            this.grbStatus.Location = new System.Drawing.Point(29, 168);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(415, 152);
            this.grbStatus.TabIndex = 11;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Status";
            // 
            // lblApMac
            // 
            this.lblApMac.AutoSize = true;
            this.lblApMac.Location = new System.Drawing.Point(6, 29);
            this.lblApMac.Name = "lblApMac";
            this.lblApMac.Size = new System.Drawing.Size(51, 13);
            this.lblApMac.TabIndex = 0;
            this.lblApMac.Text = "lblApMac";
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnRefresh});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMain.Size = new System.Drawing.Size(696, 25);
            this.toolStripMain.TabIndex = 12;
            this.toolStripMain.Text = "toolStripMain";
            // 
            // tsBtnRefresh
            // 
            this.tsBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnRefresh.Image")));
            this.tsBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRefresh.Name = "tsBtnRefresh";
            this.tsBtnRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsBtnRefresh.Text = "Refresh";
            this.tsBtnRefresh.Click += new System.EventHandler(this.tsBtnRefresh_Click);
            // 
            // lblBaseSSID
            // 
            this.lblBaseSSID.AutoSize = true;
            this.lblBaseSSID.Location = new System.Drawing.Point(6, 16);
            this.lblBaseSSID.Name = "lblBaseSSID";
            this.lblBaseSSID.Size = new System.Drawing.Size(66, 13);
            this.lblBaseSSID.TabIndex = 1;
            this.lblBaseSSID.Text = "lblBaseSSID";
            // 
            // lblUptime
            // 
            this.lblUptime.AutoSize = true;
            this.lblUptime.Location = new System.Drawing.Point(254, 42);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(50, 13);
            this.lblUptime.TabIndex = 2;
            this.lblUptime.Text = "lblUptime";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(129, 16);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(67, 13);
            this.lblFrequency.TabIndex = 3;
            this.lblFrequency.Text = "lblFrequency";
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(129, 29);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(56, 13);
            this.lblChannel.TabIndex = 4;
            this.lblChannel.Text = "lblChannel";
            // 
            // lblACKTimeout
            // 
            this.lblACKTimeout.AutoSize = true;
            this.lblACKTimeout.Location = new System.Drawing.Point(129, 42);
            this.lblACKTimeout.Name = "lblACKTimeout";
            this.lblACKTimeout.Size = new System.Drawing.Size(76, 13);
            this.lblACKTimeout.TabIndex = 5;
            this.lblACKTimeout.Text = "lblACKTimeout";
            // 
            // lblTxRate
            // 
            this.lblTxRate.AutoSize = true;
            this.lblTxRate.Location = new System.Drawing.Point(254, 16);
            this.lblTxRate.Name = "lblTxRate";
            this.lblTxRate.Size = new System.Drawing.Size(52, 13);
            this.lblTxRate.TabIndex = 6;
            this.lblTxRate.Text = "lblTxRate";
            // 
            // lblRxRate
            // 
            this.lblRxRate.AutoSize = true;
            this.lblRxRate.Location = new System.Drawing.Point(254, 29);
            this.lblRxRate.Name = "lblRxRate";
            this.lblRxRate.Size = new System.Drawing.Size(53, 13);
            this.lblRxRate.TabIndex = 7;
            this.lblRxRate.Text = "lblRxRate";
            // 
            // lblWlanIPAddress
            // 
            this.lblWlanIPAddress.AutoSize = true;
            this.lblWlanIPAddress.Location = new System.Drawing.Point(6, 42);
            this.lblWlanIPAddress.Name = "lblWlanIPAddress";
            this.lblWlanIPAddress.Size = new System.Drawing.Size(90, 13);
            this.lblWlanIPAddress.TabIndex = 8;
            this.lblWlanIPAddress.Text = "lblWlanIPAddress";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 441);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.grbStatus);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.lblSignal);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnCommand);
            this.Controls.Add(this.txtCommand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Ubnt SSH Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnCommand;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblSignal;
        private System.Windows.Forms.Timer timMain;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.GroupBox grbStatus;
        private System.Windows.Forms.Label lblApMac;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tsBtnRefresh;
        private System.Windows.Forms.Label lblBaseSSID;
        private System.Windows.Forms.Label lblACKTimeout;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblUptime;
        private System.Windows.Forms.Label lblWlanIPAddress;
        private System.Windows.Forms.Label lblRxRate;
        private System.Windows.Forms.Label lblTxRate;
    }
}

