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
            this.grBoxStatus = new System.Windows.Forms.GroupBox();
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
            this.chkBoxSignal = new System.Windows.Forms.CheckBox();
            this.chkBoxNoise = new System.Windows.Forms.CheckBox();
            this.chkBoxCCQ = new System.Windows.Forms.CheckBox();
            this.grBoxSignal = new System.Windows.Forms.GroupBox();
            this.grBoxNoise = new System.Windows.Forms.GroupBox();
            this.grBoxCCQ = new System.Windows.Forms.GroupBox();
            this.grBoxStatus.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.grBoxSignal.SuspendLayout();
            this.grBoxNoise.SuspendLayout();
            this.grBoxCCQ.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(12, 385);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(418, 20);
            this.txtCommand.TabIndex = 0;
            this.txtCommand.Text = "mca-status | grep signal";
            // 
            // btnCommand
            // 
            this.btnCommand.Location = new System.Drawing.Point(436, 383);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(149, 23);
            this.btnCommand.TabIndex = 1;
            this.btnCommand.Text = "Command";
            this.btnCommand.UseVisualStyleBackColor = true;
            this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 411);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(573, 61);
            this.txtLog.TabIndex = 2;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(12, 359);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(139, 20);
            this.txtHost.TabIndex = 5;
            this.txtHost.Text = "***REMOVED***";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(157, 359);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(51, 20);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "22";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(214, 359);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(84, 20);
            this.txtLogin.TabIndex = 7;
            this.txtLogin.Text = "***REMOVED***";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(304, 359);
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
            this.txtInterval.Location = new System.Drawing.Point(381, 359);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(49, 20);
            this.txtInterval.TabIndex = 10;
            this.txtInterval.Text = "1500";
            // 
            // grBoxStatus
            // 
            this.grBoxStatus.Controls.Add(this.lblWlanIPAddress);
            this.grBoxStatus.Controls.Add(this.lblRxRate);
            this.grBoxStatus.Controls.Add(this.lblTxRate);
            this.grBoxStatus.Controls.Add(this.lblACKTimeout);
            this.grBoxStatus.Controls.Add(this.lblChannel);
            this.grBoxStatus.Controls.Add(this.lblFrequency);
            this.grBoxStatus.Controls.Add(this.lblUptime);
            this.grBoxStatus.Controls.Add(this.lblBaseSSID);
            this.grBoxStatus.Controls.Add(this.lblApMac);
            this.grBoxStatus.Location = new System.Drawing.Point(12, 28);
            this.grBoxStatus.Name = "grBoxStatus";
            this.grBoxStatus.Size = new System.Drawing.Size(573, 106);
            this.grBoxStatus.TabIndex = 11;
            this.grBoxStatus.TabStop = false;
            this.grBoxStatus.Text = "Status";
            // 
            // lblWlanIPAddress
            // 
            this.lblWlanIPAddress.AutoSize = true;
            this.lblWlanIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWlanIPAddress.Location = new System.Drawing.Point(49, 73);
            this.lblWlanIPAddress.Name = "lblWlanIPAddress";
            this.lblWlanIPAddress.Size = new System.Drawing.Size(76, 17);
            this.lblWlanIPAddress.TabIndex = 8;
            this.lblWlanIPAddress.Text = "IP Address";
            // 
            // lblRxRate
            // 
            this.lblRxRate.AutoSize = true;
            this.lblRxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRxRate.Location = new System.Drawing.Point(437, 47);
            this.lblRxRate.Name = "lblRxRate";
            this.lblRxRate.Size = new System.Drawing.Size(58, 17);
            this.lblRxRate.TabIndex = 7;
            this.lblRxRate.Text = "Rx Rate";
            // 
            // lblTxRate
            // 
            this.lblTxRate.AutoSize = true;
            this.lblTxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTxRate.Location = new System.Drawing.Point(437, 23);
            this.lblTxRate.Name = "lblTxRate";
            this.lblTxRate.Size = new System.Drawing.Size(57, 17);
            this.lblTxRate.TabIndex = 6;
            this.lblTxRate.Text = "Tx Rate";
            // 
            // lblACKTimeout
            // 
            this.lblACKTimeout.AutoSize = true;
            this.lblACKTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblACKTimeout.Location = new System.Drawing.Point(219, 73);
            this.lblACKTimeout.Name = "lblACKTimeout";
            this.lblACKTimeout.Size = new System.Drawing.Size(90, 17);
            this.lblACKTimeout.TabIndex = 5;
            this.lblACKTimeout.Text = "ACK Timeout";
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChannel.Location = new System.Drawing.Point(219, 47);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(60, 17);
            this.lblChannel.TabIndex = 4;
            this.lblChannel.Text = "Channel";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrequency.Location = new System.Drawing.Point(219, 23);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(75, 17);
            this.lblFrequency.TabIndex = 3;
            this.lblFrequency.Text = "Frequency";
            // 
            // lblUptime
            // 
            this.lblUptime.AutoSize = true;
            this.lblUptime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUptime.Location = new System.Drawing.Point(437, 73);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(52, 17);
            this.lblUptime.TabIndex = 2;
            this.lblUptime.Text = "Uptime";
            // 
            // lblBaseSSID
            // 
            this.lblBaseSSID.AutoSize = true;
            this.lblBaseSSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBaseSSID.Location = new System.Drawing.Point(49, 23);
            this.lblBaseSSID.Name = "lblBaseSSID";
            this.lblBaseSSID.Size = new System.Drawing.Size(39, 17);
            this.lblBaseSSID.TabIndex = 1;
            this.lblBaseSSID.Text = "SSID";
            // 
            // lblApMac
            // 
            this.lblApMac.AutoSize = true;
            this.lblApMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblApMac.Location = new System.Drawing.Point(49, 47);
            this.lblApMac.Name = "lblApMac";
            this.lblApMac.Size = new System.Drawing.Size(37, 17);
            this.lblApMac.TabIndex = 0;
            this.lblApMac.Text = "MAC";
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
            this.toolStripMain.Size = new System.Drawing.Size(730, 25);
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
            this.cirPbSignal.Location = new System.Drawing.Point(9, 15);
            this.cirPbSignal.Margin = new System.Windows.Forms.Padding(0);
            this.cirPbSignal.MarqueeAnimationSpeed = 2000;
            this.cirPbSignal.Name = "cirPbSignal";
            this.cirPbSignal.OuterColor = System.Drawing.Color.Gray;
            this.cirPbSignal.OuterMargin = -25;
            this.cirPbSignal.OuterWidth = 20;
            this.cirPbSignal.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.cirPbSignal.ProgressWidth = 25;
            this.cirPbSignal.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cirPbSignal.Size = new System.Drawing.Size(170, 170);
            this.cirPbSignal.StartAngle = 90;
            this.cirPbSignal.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbSignal.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cirPbSignal.SubscriptText = "dBm";
            this.cirPbSignal.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbSignal.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cirPbSignal.SuperscriptText = "";
            this.cirPbSignal.TabIndex = 15;
            this.cirPbSignal.Text = "-70";
            this.cirPbSignal.TextMargin = new System.Windows.Forms.Padding(0);
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
            this.cirPbNoise.Location = new System.Drawing.Point(9, 15);
            this.cirPbNoise.Margin = new System.Windows.Forms.Padding(0);
            this.cirPbNoise.MarqueeAnimationSpeed = 2000;
            this.cirPbNoise.Name = "cirPbNoise";
            this.cirPbNoise.OuterColor = System.Drawing.Color.Gray;
            this.cirPbNoise.OuterMargin = -25;
            this.cirPbNoise.OuterWidth = 20;
            this.cirPbNoise.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.cirPbNoise.ProgressWidth = 25;
            this.cirPbNoise.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cirPbNoise.Size = new System.Drawing.Size(170, 170);
            this.cirPbNoise.StartAngle = 90;
            this.cirPbNoise.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbNoise.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cirPbNoise.SubscriptText = "dBm";
            this.cirPbNoise.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbNoise.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cirPbNoise.SuperscriptText = "";
            this.cirPbNoise.TabIndex = 16;
            this.cirPbNoise.Text = "-70";
            this.cirPbNoise.TextMargin = new System.Windows.Forms.Padding(0);
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
            this.cirPbCCQ.Location = new System.Drawing.Point(9, 15);
            this.cirPbCCQ.Margin = new System.Windows.Forms.Padding(0);
            this.cirPbCCQ.MarqueeAnimationSpeed = 2000;
            this.cirPbCCQ.Name = "cirPbCCQ";
            this.cirPbCCQ.OuterColor = System.Drawing.Color.Gray;
            this.cirPbCCQ.OuterMargin = -25;
            this.cirPbCCQ.OuterWidth = 20;
            this.cirPbCCQ.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(220)))), ((int)(((byte)(57)))));
            this.cirPbCCQ.ProgressWidth = 25;
            this.cirPbCCQ.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cirPbCCQ.Size = new System.Drawing.Size(170, 170);
            this.cirPbCCQ.StartAngle = 90;
            this.cirPbCCQ.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbCCQ.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cirPbCCQ.SubscriptText = "%";
            this.cirPbCCQ.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cirPbCCQ.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cirPbCCQ.SuperscriptText = "";
            this.cirPbCCQ.TabIndex = 17;
            this.cirPbCCQ.Text = "99";
            this.cirPbCCQ.TextMargin = new System.Windows.Forms.Padding(0);
            this.cirPbCCQ.Value = 70;
            // 
            // chkBoxSignal
            // 
            this.chkBoxSignal.AutoSize = true;
            this.chkBoxSignal.Checked = true;
            this.chkBoxSignal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxSignal.Location = new System.Drawing.Point(9, 188);
            this.chkBoxSignal.Name = "chkBoxSignal";
            this.chkBoxSignal.Size = new System.Drawing.Size(48, 17);
            this.chkBoxSignal.TabIndex = 18;
            this.chkBoxSignal.Text = "Auto";
            this.chkBoxSignal.UseVisualStyleBackColor = true;
            // 
            // chkBoxNoise
            // 
            this.chkBoxNoise.AutoSize = true;
            this.chkBoxNoise.Location = new System.Drawing.Point(9, 188);
            this.chkBoxNoise.Name = "chkBoxNoise";
            this.chkBoxNoise.Size = new System.Drawing.Size(48, 17);
            this.chkBoxNoise.TabIndex = 19;
            this.chkBoxNoise.Text = "Auto";
            this.chkBoxNoise.UseVisualStyleBackColor = true;
            // 
            // chkBoxCCQ
            // 
            this.chkBoxCCQ.AutoSize = true;
            this.chkBoxCCQ.Location = new System.Drawing.Point(9, 188);
            this.chkBoxCCQ.Name = "chkBoxCCQ";
            this.chkBoxCCQ.Size = new System.Drawing.Size(48, 17);
            this.chkBoxCCQ.TabIndex = 20;
            this.chkBoxCCQ.Text = "Auto";
            this.chkBoxCCQ.UseVisualStyleBackColor = true;
            // 
            // grBoxSignal
            // 
            this.grBoxSignal.Controls.Add(this.cirPbSignal);
            this.grBoxSignal.Controls.Add(this.chkBoxSignal);
            this.grBoxSignal.Location = new System.Drawing.Point(12, 140);
            this.grBoxSignal.Name = "grBoxSignal";
            this.grBoxSignal.Size = new System.Drawing.Size(187, 213);
            this.grBoxSignal.TabIndex = 21;
            this.grBoxSignal.TabStop = false;
            this.grBoxSignal.Text = "Signal";
            // 
            // grBoxNoise
            // 
            this.grBoxNoise.Controls.Add(this.cirPbNoise);
            this.grBoxNoise.Controls.Add(this.chkBoxNoise);
            this.grBoxNoise.Location = new System.Drawing.Point(205, 140);
            this.grBoxNoise.Name = "grBoxNoise";
            this.grBoxNoise.Size = new System.Drawing.Size(187, 213);
            this.grBoxNoise.TabIndex = 22;
            this.grBoxNoise.TabStop = false;
            this.grBoxNoise.Text = "Noise";
            // 
            // grBoxCCQ
            // 
            this.grBoxCCQ.Controls.Add(this.cirPbCCQ);
            this.grBoxCCQ.Controls.Add(this.chkBoxCCQ);
            this.grBoxCCQ.Location = new System.Drawing.Point(398, 140);
            this.grBoxCCQ.Name = "grBoxCCQ";
            this.grBoxCCQ.Size = new System.Drawing.Size(187, 213);
            this.grBoxCCQ.TabIndex = 23;
            this.grBoxCCQ.TabStop = false;
            this.grBoxCCQ.Text = "CCQ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 501);
            this.Controls.Add(this.grBoxCCQ);
            this.Controls.Add(this.grBoxNoise);
            this.Controls.Add(this.grBoxSignal);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.grBoxStatus);
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
            this.grBoxStatus.ResumeLayout(false);
            this.grBoxStatus.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.grBoxSignal.ResumeLayout(false);
            this.grBoxSignal.PerformLayout();
            this.grBoxNoise.ResumeLayout(false);
            this.grBoxNoise.PerformLayout();
            this.grBoxCCQ.ResumeLayout(false);
            this.grBoxCCQ.PerformLayout();
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
        private System.Windows.Forms.GroupBox grBoxStatus;
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
        private System.Windows.Forms.CheckBox chkBoxSignal;
        private System.Windows.Forms.CheckBox chkBoxNoise;
        private System.Windows.Forms.CheckBox chkBoxCCQ;
        private System.Windows.Forms.GroupBox grBoxSignal;
        private System.Windows.Forms.GroupBox grBoxNoise;
        private System.Windows.Forms.GroupBox grBoxCCQ;
    }
}

