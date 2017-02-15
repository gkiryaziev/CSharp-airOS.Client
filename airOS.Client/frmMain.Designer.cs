namespace AirOSClient
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
            this.btnCommandSend = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.timMain = new System.Windows.Forms.Timer(this.components);
            this.grBoxStatus = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnClearLog = new System.Windows.Forms.ToolStripButton();
            this.cirPbSignal = new CircularProgressBar.CircularProgressBar();
            this.cirPbNoise = new CircularProgressBar.CircularProgressBar();
            this.cirPbCCQ = new CircularProgressBar.CircularProgressBar();
            this.chkBoxSignal = new System.Windows.Forms.CheckBox();
            this.chkBoxNoise = new System.Windows.Forms.CheckBox();
            this.chkBoxCCQ = new System.Windows.Forms.CheckBox();
            this.grBoxSignal = new System.Windows.Forms.GroupBox();
            this.grBoxNoise = new System.Windows.Forms.GroupBox();
            this.grBoxCCQ = new System.Windows.Forms.GroupBox();
            this.grBoxCommand = new System.Windows.Forms.GroupBox();
            this.grBoxLog = new System.Windows.Forms.GroupBox();
            this.grBoxStatus.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.grBoxSignal.SuspendLayout();
            this.grBoxNoise.SuspendLayout();
            this.grBoxCCQ.SuspendLayout();
            this.grBoxCommand.SuspendLayout();
            this.grBoxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.BackColor = System.Drawing.SystemColors.Control;
            this.txtCommand.Location = new System.Drawing.Point(9, 19);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(482, 20);
            this.txtCommand.TabIndex = 0;
            this.txtCommand.Text = "mca-status | grep signal";
            // 
            // btnCommandSend
            // 
            this.btnCommandSend.Location = new System.Drawing.Point(497, 17);
            this.btnCommandSend.Name = "btnCommandSend";
            this.btnCommandSend.Size = new System.Drawing.Size(68, 23);
            this.btnCommandSend.TabIndex = 1;
            this.btnCommandSend.Text = "Send";
            this.btnCommandSend.UseVisualStyleBackColor = true;
            this.btnCommandSend.Click += new System.EventHandler(this.btnCommandSend_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.Control;
            this.txtLog.Location = new System.Drawing.Point(9, 19);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(556, 71);
            this.txtLog.TabIndex = 2;
            // 
            // timMain
            // 
            this.timMain.Tick += new System.EventHandler(this.timMain_Tick);
            // 
            // grBoxStatus
            // 
            this.grBoxStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grBoxStatus.Controls.Add(this.label7);
            this.grBoxStatus.Controls.Add(this.label8);
            this.grBoxStatus.Controls.Add(this.label9);
            this.grBoxStatus.Controls.Add(this.label4);
            this.grBoxStatus.Controls.Add(this.label5);
            this.grBoxStatus.Controls.Add(this.label6);
            this.grBoxStatus.Controls.Add(this.label1);
            this.grBoxStatus.Controls.Add(this.label2);
            this.grBoxStatus.Controls.Add(this.label3);
            this.grBoxStatus.Controls.Add(this.lblWlanIPAddress);
            this.grBoxStatus.Controls.Add(this.lblRxRate);
            this.grBoxStatus.Controls.Add(this.lblTxRate);
            this.grBoxStatus.Controls.Add(this.lblACKTimeout);
            this.grBoxStatus.Controls.Add(this.lblChannel);
            this.grBoxStatus.Controls.Add(this.lblFrequency);
            this.grBoxStatus.Controls.Add(this.lblUptime);
            this.grBoxStatus.Controls.Add(this.lblBaseSSID);
            this.grBoxStatus.Controls.Add(this.lblApMac);
            this.grBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBoxStatus.Location = new System.Drawing.Point(12, 28);
            this.grBoxStatus.Name = "grBoxStatus";
            this.grBoxStatus.Size = new System.Drawing.Size(573, 106);
            this.grBoxStatus.TabIndex = 11;
            this.grBoxStatus.TabStop = false;
            this.grBoxStatus.Text = "Status";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(389, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Rx Rate";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(389, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tx Rate";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(389, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Uptime";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(199, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "ACK Timeout";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(199, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Channel";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(199, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Frequency";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "WLAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "SSID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "MAC";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWlanIPAddress
            // 
            this.lblWlanIPAddress.BackColor = System.Drawing.SystemColors.Control;
            this.lblWlanIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWlanIPAddress.Location = new System.Drawing.Point(59, 76);
            this.lblWlanIPAddress.Name = "lblWlanIPAddress";
            this.lblWlanIPAddress.Size = new System.Drawing.Size(128, 25);
            this.lblWlanIPAddress.TabIndex = 8;
            this.lblWlanIPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRxRate
            // 
            this.lblRxRate.BackColor = System.Drawing.SystemColors.Control;
            this.lblRxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRxRate.Location = new System.Drawing.Point(448, 48);
            this.lblRxRate.Name = "lblRxRate";
            this.lblRxRate.Size = new System.Drawing.Size(117, 25);
            this.lblRxRate.TabIndex = 7;
            this.lblRxRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTxRate
            // 
            this.lblTxRate.BackColor = System.Drawing.SystemColors.Control;
            this.lblTxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTxRate.Location = new System.Drawing.Point(448, 20);
            this.lblTxRate.Name = "lblTxRate";
            this.lblTxRate.Size = new System.Drawing.Size(117, 25);
            this.lblTxRate.TabIndex = 6;
            this.lblTxRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblACKTimeout
            // 
            this.lblACKTimeout.BackColor = System.Drawing.SystemColors.Control;
            this.lblACKTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblACKTimeout.Location = new System.Drawing.Point(289, 76);
            this.lblACKTimeout.Name = "lblACKTimeout";
            this.lblACKTimeout.Size = new System.Drawing.Size(91, 25);
            this.lblACKTimeout.TabIndex = 5;
            this.lblACKTimeout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChannel
            // 
            this.lblChannel.BackColor = System.Drawing.SystemColors.Control;
            this.lblChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChannel.Location = new System.Drawing.Point(289, 48);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(91, 25);
            this.lblChannel.TabIndex = 4;
            this.lblChannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFrequency
            // 
            this.lblFrequency.BackColor = System.Drawing.SystemColors.Control;
            this.lblFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrequency.Location = new System.Drawing.Point(289, 20);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(91, 25);
            this.lblFrequency.TabIndex = 3;
            this.lblFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUptime
            // 
            this.lblUptime.BackColor = System.Drawing.SystemColors.Control;
            this.lblUptime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUptime.Location = new System.Drawing.Point(448, 76);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(117, 25);
            this.lblUptime.TabIndex = 2;
            this.lblUptime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBaseSSID
            // 
            this.lblBaseSSID.BackColor = System.Drawing.SystemColors.Control;
            this.lblBaseSSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBaseSSID.Location = new System.Drawing.Point(59, 20);
            this.lblBaseSSID.Name = "lblBaseSSID";
            this.lblBaseSSID.Size = new System.Drawing.Size(128, 25);
            this.lblBaseSSID.TabIndex = 1;
            this.lblBaseSSID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApMac
            // 
            this.lblApMac.BackColor = System.Drawing.SystemColors.Control;
            this.lblApMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblApMac.Location = new System.Drawing.Point(59, 48);
            this.lblApMac.Name = "lblApMac";
            this.lblApMac.Size = new System.Drawing.Size(128, 25);
            this.lblApMac.TabIndex = 0;
            this.lblApMac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripMain
            // 
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnConnect,
            this.tsBtnDisconnect,
            this.tsBtnRefresh,
            this.toolStripSeparator1,
            this.tsBtnSetting,
            this.toolStripSeparator2,
            this.tsBtnClearLog});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMain.Size = new System.Drawing.Size(596, 25);
            this.toolStripMain.TabIndex = 12;
            this.toolStripMain.Text = "toolStripMain";
            // 
            // tsBtnConnect
            // 
            this.tsBtnConnect.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnConnect.Name = "tsBtnConnect";
            this.tsBtnConnect.Size = new System.Drawing.Size(62, 22);
            this.tsBtnConnect.Text = "Connect";
            this.tsBtnConnect.Click += new System.EventHandler(this.tsBtnConnect_Click);
            // 
            // tsBtnDisconnect
            // 
            this.tsBtnDisconnect.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDisconnect.Name = "tsBtnDisconnect";
            this.tsBtnDisconnect.Size = new System.Drawing.Size(78, 22);
            this.tsBtnDisconnect.Text = "Disconnect";
            this.tsBtnDisconnect.Click += new System.EventHandler(this.tsBtnDisconnect_Click);
            // 
            // tsBtnRefresh
            // 
            this.tsBtnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRefresh.Name = "tsBtnRefresh";
            this.tsBtnRefresh.Size = new System.Drawing.Size(57, 22);
            this.tsBtnRefresh.Text = "Refresh";
            this.tsBtnRefresh.Click += new System.EventHandler(this.tsBtnRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnSetting
            // 
            this.tsBtnSetting.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSetting.Name = "tsBtnSetting";
            this.tsBtnSetting.Size = new System.Drawing.Size(55, 22);
            this.tsBtnSetting.Text = "Setting";
            this.tsBtnSetting.Click += new System.EventHandler(this.tsBtnSettingClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnClearLog
            // 
            this.tsBtnClearLog.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnClearLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClearLog.Name = "tsBtnClearLog";
            this.tsBtnClearLog.Size = new System.Drawing.Size(68, 22);
            this.tsBtnClearLog.Text = "Clear Log";
            this.tsBtnClearLog.Click += new System.EventHandler(this.tsBtnClearLog_Click);
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
            this.cirPbCCQ.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
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
            this.cirPbCCQ.Text = "70";
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
            this.chkBoxSignal.Size = new System.Drawing.Size(50, 19);
            this.chkBoxSignal.TabIndex = 18;
            this.chkBoxSignal.Text = "Auto";
            this.chkBoxSignal.UseVisualStyleBackColor = true;
            // 
            // chkBoxNoise
            // 
            this.chkBoxNoise.AutoSize = true;
            this.chkBoxNoise.Location = new System.Drawing.Point(9, 188);
            this.chkBoxNoise.Name = "chkBoxNoise";
            this.chkBoxNoise.Size = new System.Drawing.Size(50, 19);
            this.chkBoxNoise.TabIndex = 19;
            this.chkBoxNoise.Text = "Auto";
            this.chkBoxNoise.UseVisualStyleBackColor = true;
            // 
            // chkBoxCCQ
            // 
            this.chkBoxCCQ.AutoSize = true;
            this.chkBoxCCQ.Location = new System.Drawing.Point(9, 188);
            this.chkBoxCCQ.Name = "chkBoxCCQ";
            this.chkBoxCCQ.Size = new System.Drawing.Size(50, 19);
            this.chkBoxCCQ.TabIndex = 20;
            this.chkBoxCCQ.Text = "Auto";
            this.chkBoxCCQ.UseVisualStyleBackColor = true;
            // 
            // grBoxSignal
            // 
            this.grBoxSignal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grBoxSignal.Controls.Add(this.cirPbSignal);
            this.grBoxSignal.Controls.Add(this.chkBoxSignal);
            this.grBoxSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBoxSignal.Location = new System.Drawing.Point(12, 140);
            this.grBoxSignal.Name = "grBoxSignal";
            this.grBoxSignal.Size = new System.Drawing.Size(187, 213);
            this.grBoxSignal.TabIndex = 21;
            this.grBoxSignal.TabStop = false;
            this.grBoxSignal.Text = "Signal";
            // 
            // grBoxNoise
            // 
            this.grBoxNoise.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grBoxNoise.Controls.Add(this.cirPbNoise);
            this.grBoxNoise.Controls.Add(this.chkBoxNoise);
            this.grBoxNoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBoxNoise.Location = new System.Drawing.Point(205, 140);
            this.grBoxNoise.Name = "grBoxNoise";
            this.grBoxNoise.Size = new System.Drawing.Size(187, 213);
            this.grBoxNoise.TabIndex = 22;
            this.grBoxNoise.TabStop = false;
            this.grBoxNoise.Text = "Noise";
            // 
            // grBoxCCQ
            // 
            this.grBoxCCQ.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grBoxCCQ.Controls.Add(this.cirPbCCQ);
            this.grBoxCCQ.Controls.Add(this.chkBoxCCQ);
            this.grBoxCCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBoxCCQ.Location = new System.Drawing.Point(398, 140);
            this.grBoxCCQ.Name = "grBoxCCQ";
            this.grBoxCCQ.Size = new System.Drawing.Size(187, 213);
            this.grBoxCCQ.TabIndex = 23;
            this.grBoxCCQ.TabStop = false;
            this.grBoxCCQ.Text = "CCQ";
            // 
            // grBoxCommand
            // 
            this.grBoxCommand.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grBoxCommand.Controls.Add(this.txtCommand);
            this.grBoxCommand.Controls.Add(this.btnCommandSend);
            this.grBoxCommand.Location = new System.Drawing.Point(12, 359);
            this.grBoxCommand.Name = "grBoxCommand";
            this.grBoxCommand.Size = new System.Drawing.Size(573, 50);
            this.grBoxCommand.TabIndex = 24;
            this.grBoxCommand.TabStop = false;
            this.grBoxCommand.Text = "Command";
            // 
            // grBoxLog
            // 
            this.grBoxLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grBoxLog.Controls.Add(this.txtLog);
            this.grBoxLog.Location = new System.Drawing.Point(12, 415);
            this.grBoxLog.Name = "grBoxLog";
            this.grBoxLog.Size = new System.Drawing.Size(573, 96);
            this.grBoxLog.TabIndex = 25;
            this.grBoxLog.TabStop = false;
            this.grBoxLog.Text = "Log";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 519);
            this.Controls.Add(this.grBoxLog);
            this.Controls.Add(this.grBoxCommand);
            this.Controls.Add(this.grBoxCCQ);
            this.Controls.Add(this.grBoxNoise);
            this.Controls.Add(this.grBoxSignal);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.grBoxStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "airOS SSH Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grBoxStatus.ResumeLayout(false);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.grBoxSignal.ResumeLayout(false);
            this.grBoxSignal.PerformLayout();
            this.grBoxNoise.ResumeLayout(false);
            this.grBoxNoise.PerformLayout();
            this.grBoxCCQ.ResumeLayout(false);
            this.grBoxCCQ.PerformLayout();
            this.grBoxCommand.ResumeLayout(false);
            this.grBoxCommand.PerformLayout();
            this.grBoxLog.ResumeLayout(false);
            this.grBoxLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnCommandSend;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Timer timMain;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton tsBtnSetting;
        private System.Windows.Forms.GroupBox grBoxCommand;
        private System.Windows.Forms.GroupBox grBoxLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnClearLog;
    }
}

