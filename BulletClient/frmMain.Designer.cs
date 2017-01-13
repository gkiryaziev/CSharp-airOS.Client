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
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.timMain = new System.Windows.Forms.Timer(this.components);
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.lblWlanIPAddress = new System.Windows.Forms.Label();
            this.lblRxRate = new System.Windows.Forms.Label();
            this.lblTxRate = new System.Windows.Forms.Label();
            this.lblACKTimeout = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblUptime = new System.Windows.Forms.Label();
            this.lblBaseSSID = new System.Windows.Forms.Label();
            this.lblApMac = new System.Windows.Forms.Label();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsBtnConnect = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDisconnect = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.cirPbSignal = new CircularProgressBar.CircularProgressBar();
            this.cirPbNoise = new CircularProgressBar.CircularProgressBar();
            this.cirPbCCQ = new CircularProgressBar.CircularProgressBar();
            this.grbStatus.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(12, 336);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(418, 20);
            this.txtCommand.TabIndex = 0;
            this.txtCommand.Text = "mca-status | grep signal";
            // 
            // btnCommand
            // 
            this.btnCommand.Location = new System.Drawing.Point(436, 335);
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
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(12, 310);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(139, 20);
            this.txtHost.TabIndex = 5;
            this.txtHost.Text = "***REMOVED***";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(157, 310);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(51, 20);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "22";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(214, 310);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(84, 20);
            this.txtLogin.TabIndex = 7;
            this.txtLogin.Text = "***REMOVED***";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(304, 310);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(71, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "***REMOVED***";
            // 
            // timMain
            // 
            this.timMain.Tick += new System.EventHandler(this.timMain_Tick);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(381, 310);
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
            this.grbStatus.Location = new System.Drawing.Point(12, 28);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(510, 65);
            this.grbStatus.TabIndex = 11;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Status";
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
            // lblRxRate
            // 
            this.lblRxRate.AutoSize = true;
            this.lblRxRate.Location = new System.Drawing.Point(254, 29);
            this.lblRxRate.Name = "lblRxRate";
            this.lblRxRate.Size = new System.Drawing.Size(53, 13);
            this.lblRxRate.TabIndex = 7;
            this.lblRxRate.Text = "lblRxRate";
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
            // lblACKTimeout
            // 
            this.lblACKTimeout.AutoSize = true;
            this.lblACKTimeout.Location = new System.Drawing.Point(129, 42);
            this.lblACKTimeout.Name = "lblACKTimeout";
            this.lblACKTimeout.Size = new System.Drawing.Size(76, 13);
            this.lblACKTimeout.TabIndex = 5;
            this.lblACKTimeout.Text = "lblACKTimeout";
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
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(129, 16);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(67, 13);
            this.lblFrequency.TabIndex = 3;
            this.lblFrequency.Text = "lblFrequency";
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
            // lblBaseSSID
            // 
            this.lblBaseSSID.AutoSize = true;
            this.lblBaseSSID.Location = new System.Drawing.Point(6, 16);
            this.lblBaseSSID.Name = "lblBaseSSID";
            this.lblBaseSSID.Size = new System.Drawing.Size(66, 13);
            this.lblBaseSSID.TabIndex = 1;
            this.lblBaseSSID.Text = "lblBaseSSID";
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
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnConnect,
            this.tsBtnDisconnect,
            this.tsBtnRefresh});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMain.Size = new System.Drawing.Size(723, 25);
            this.toolStripMain.TabIndex = 12;
            this.toolStripMain.Text = "toolStripMain";
            // 
            // tsBtnConnect
            // 
            this.tsBtnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnConnect.Name = "tsBtnConnect";
            this.tsBtnConnect.Size = new System.Drawing.Size(56, 22);
            this.tsBtnConnect.Text = "Connect";
            this.tsBtnConnect.Click += new System.EventHandler(this.tsBtnConnect_Click);
            // 
            // tsBtnDisconnect
            // 
            this.tsBtnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDisconnect.Name = "tsBtnDisconnect";
            this.tsBtnDisconnect.Size = new System.Drawing.Size(70, 22);
            this.tsBtnDisconnect.Text = "Disconnect";
            this.tsBtnDisconnect.Click += new System.EventHandler(this.tsBtnDisconnect_Click);
            // 
            // tsBtnRefresh
            // 
            this.tsBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRefresh.Name = "tsBtnRefresh";
            this.tsBtnRefresh.Size = new System.Drawing.Size(50, 22);
            this.tsBtnRefresh.Text = "Refresh";
            this.tsBtnRefresh.Click += new System.EventHandler(this.tsBtnRefresh_Click);
            // 
            // cirPbSignal
            // 
            this.cirPbSignal.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("cirPbSignal.AnimationFunction")));
            this.cirPbSignal.AnimationSpeed = 500;
            this.cirPbSignal.BackColor = System.Drawing.Color.Transparent;
            this.cirPbSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.cirPbSignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cirPbSignal.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cirPbSignal.InnerMargin = 2;
            this.cirPbSignal.InnerWidth = -1;
            this.cirPbSignal.Location = new System.Drawing.Point(12, 105);
            this.cirPbSignal.Margin = new System.Windows.Forms.Padding(0);
            this.cirPbSignal.MarqueeAnimationSpeed = 2000;
            this.cirPbSignal.Name = "cirPbSignal";
            this.cirPbSignal.OuterColor = System.Drawing.Color.Gray;
            this.cirPbSignal.OuterMargin = -25;
            this.cirPbSignal.OuterWidth = 20;
            this.cirPbSignal.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.cirPbSignal.ProgressWidth = 25;
            this.cirPbSignal.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cirPbSignal.Size = new System.Drawing.Size(170, 170);
            this.cirPbSignal.StartAngle = 90;
            this.cirPbSignal.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbSignal.SubscriptMargin = new System.Windows.Forms.Padding(-30, 0, 0, 0);
            this.cirPbSignal.SubscriptText = "dBm";
            this.cirPbSignal.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbSignal.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cirPbSignal.SuperscriptText = "";
            this.cirPbSignal.TabIndex = 15;
            this.cirPbSignal.Text = "-70";
            this.cirPbSignal.TextMargin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cirPbSignal.Value = 70;
            // 
            // cirPbNoise
            // 
            this.cirPbNoise.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("cirPbNoise.AnimationFunction")));
            this.cirPbNoise.AnimationSpeed = 500;
            this.cirPbNoise.BackColor = System.Drawing.Color.Transparent;
            this.cirPbNoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.cirPbNoise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cirPbNoise.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cirPbNoise.InnerMargin = 2;
            this.cirPbNoise.InnerWidth = -1;
            this.cirPbNoise.Location = new System.Drawing.Point(182, 105);
            this.cirPbNoise.Margin = new System.Windows.Forms.Padding(0);
            this.cirPbNoise.MarqueeAnimationSpeed = 2000;
            this.cirPbNoise.Name = "cirPbNoise";
            this.cirPbNoise.OuterColor = System.Drawing.Color.Gray;
            this.cirPbNoise.OuterMargin = -25;
            this.cirPbNoise.OuterWidth = 20;
            this.cirPbNoise.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.cirPbNoise.ProgressWidth = 25;
            this.cirPbNoise.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cirPbNoise.Size = new System.Drawing.Size(170, 170);
            this.cirPbNoise.StartAngle = 90;
            this.cirPbNoise.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbNoise.SubscriptMargin = new System.Windows.Forms.Padding(-30, 0, 0, 0);
            this.cirPbNoise.SubscriptText = "dBm";
            this.cirPbNoise.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbNoise.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cirPbNoise.SuperscriptText = "";
            this.cirPbNoise.TabIndex = 16;
            this.cirPbNoise.Text = "-70";
            this.cirPbNoise.TextMargin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cirPbNoise.Value = 70;
            // 
            // cirPbCCQ
            // 
            this.cirPbCCQ.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("cirPbCCQ.AnimationFunction")));
            this.cirPbCCQ.AnimationSpeed = 500;
            this.cirPbCCQ.BackColor = System.Drawing.Color.Transparent;
            this.cirPbCCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.cirPbCCQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cirPbCCQ.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cirPbCCQ.InnerMargin = 2;
            this.cirPbCCQ.InnerWidth = -1;
            this.cirPbCCQ.Location = new System.Drawing.Point(352, 105);
            this.cirPbCCQ.Margin = new System.Windows.Forms.Padding(0);
            this.cirPbCCQ.MarqueeAnimationSpeed = 2000;
            this.cirPbCCQ.Name = "cirPbCCQ";
            this.cirPbCCQ.OuterColor = System.Drawing.Color.Gray;
            this.cirPbCCQ.OuterMargin = -25;
            this.cirPbCCQ.OuterWidth = 20;
            this.cirPbCCQ.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(220)))), ((int)(((byte)(57)))));
            this.cirPbCCQ.ProgressWidth = 25;
            this.cirPbCCQ.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cirPbCCQ.Size = new System.Drawing.Size(170, 170);
            this.cirPbCCQ.StartAngle = 90;
            this.cirPbCCQ.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbCCQ.SubscriptMargin = new System.Windows.Forms.Padding(-34, 0, 0, 0);
            this.cirPbCCQ.SubscriptText = "%";
            this.cirPbCCQ.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbCCQ.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cirPbCCQ.SuperscriptText = "";
            this.cirPbCCQ.TabIndex = 17;
            this.cirPbCCQ.Text = "99";
            this.cirPbCCQ.TextMargin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cirPbCCQ.Value = 70;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 449);
            this.Controls.Add(this.cirPbCCQ);
            this.Controls.Add(this.cirPbNoise);
            this.Controls.Add(this.cirPbSignal);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.grbStatus);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnCommand);
            this.Controls.Add(this.txtCommand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Ubnt SSH Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
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
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
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
        private System.Windows.Forms.ToolStripButton tsBtnConnect;
        private System.Windows.Forms.ToolStripButton tsBtnDisconnect;
        private CircularProgressBar.CircularProgressBar cirPbSignal;
        private CircularProgressBar.CircularProgressBar cirPbNoise;
        private CircularProgressBar.CircularProgressBar cirPbCCQ;
    }
}

