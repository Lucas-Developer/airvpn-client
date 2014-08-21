namespace AirVPN.Gui.Forms
{
    partial class Settings
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
			AirVPN.Gui.Skin.TabPage tabPage1;
			AirVPN.Gui.Skin.TabPage tabPage2;
			AirVPN.Gui.Skin.TabPage tabPage3;
			AirVPN.Gui.Skin.ColumnHeader columnHeader1;
			AirVPN.Gui.Skin.ColumnHeader columnHeader2;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
			this.chkAdvancedNetworkLocking = new AirVPN.Gui.Skin.CheckBox();
			this.label7 = new AirVPN.Gui.Skin.Label();
			this.cboDnsSwitchMode = new AirVPN.Gui.Skin.ComboBox();
			this.pnlAdvancedGeneralWindowsOnly = new System.Windows.Forms.GroupBox();
			this.chkAdvancedWindowsTapUp = new AirVPN.Gui.Skin.CheckBox();
			this.chkAdvancedWindowsForceDns = new AirVPN.Gui.Skin.CheckBox();
			this.chkAdvancedWindowsDhcpSwitch = new AirVPN.Gui.Skin.CheckBox();
			this.cmdAdvancedUninstallDriver = new AirVPN.Gui.Skin.Button();
			this.lnkAdvancedDocs = new AirVPN.Gui.Skin.LinkLabel();
			this.chkAdvancedPingerAlways = new AirVPN.Gui.Skin.CheckBox();
			this.chkAdvancedPingerEnabled = new AirVPN.Gui.Skin.CheckBox();
			this.cmdExeBrowse = new AirVPN.Gui.Skin.Button();
			this.txtExePath = new AirVPN.Gui.Skin.TextBox();
			this.label4 = new AirVPN.Gui.Skin.Label();
			this.chkAdvancedCheckRoute = new AirVPN.Gui.Skin.CheckBox();
			this.chkAdvancedCheckDns = new AirVPN.Gui.Skin.CheckBox();
			this.chkExpert = new AirVPN.Gui.Skin.CheckBox();
			this.label3 = new AirVPN.Gui.Skin.Label();
			this.label2 = new AirVPN.Gui.Skin.Label();
			this.chkAdvancedOpenVpnDirectivesDefaultSkip = new AirVPN.Gui.Skin.CheckBox();
			this.txtAdvancedOpenVpnDirectivesDefault = new AirVPN.Gui.Skin.TextBox();
			this.txtAdvancedOpenVpnDirectivesCustom = new AirVPN.Gui.Skin.TextBox();
			this.cmdAdvancedEventsEdit = new AirVPN.Gui.Skin.Button();
			this.cmdAdvancedEventsClear = new AirVPN.Gui.Skin.Button();
			this.lstAdvancedEvents = new AirVPN.Gui.Skin.ListView();
			this.columnHeader3 = ((AirVPN.Gui.Skin.ColumnHeader)(new AirVPN.Gui.Skin.ColumnHeader()));
			this.columnHeader4 = ((AirVPN.Gui.Skin.ColumnHeader)(new AirVPN.Gui.Skin.ColumnHeader()));
			this.imgRoutes = new System.Windows.Forms.ImageList(this.components);
			this.label1 = new AirVPN.Gui.Skin.Label();
			this.mnuRoutes = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuRoutesAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRoutesRemove = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRoutesEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.colLogDate = ((AirVPN.Gui.Skin.ColumnHeader)(new AirVPN.Gui.Skin.ColumnHeader()));
			this.colLogMessage = ((AirVPN.Gui.Skin.ColumnHeader)(new AirVPN.Gui.Skin.ColumnHeader()));
			this.myToolTip = new AirVPN.Gui.Skin.ToolTip(this.components);
			this.openExeDialog = new System.Windows.Forms.OpenFileDialog();
			this.pnlCommands = new AirVPN.Gui.Skin.Panel();
			this.cmdCancel = new AirVPN.Gui.Skin.Button();
			this.cmdOk = new AirVPN.Gui.Skin.Button();
			this.tabSettings = new AirVPN.Gui.Skin.TabControl();
			this.tabGeneral = new AirVPN.Gui.Skin.TabPage();
			this.pnlGeneralWindowsOnly = new System.Windows.Forms.GroupBox();
			this.chkSystemStart = new AirVPN.Gui.Skin.CheckBox();
			this.chkMinimizeTray = new AirVPN.Gui.Skin.CheckBox();
			this.lblGeneralTheme = new AirVPN.Gui.Skin.Label();
			this.cboGeneralTheme = new AirVPN.Gui.Skin.ComboBox();
			this.chkGeneralStartLast = new AirVPN.Gui.Skin.CheckBox();
			this.cmdTos = new AirVPN.Gui.Skin.Button();
			this.chkAutoStart = new AirVPN.Gui.Skin.CheckBox();
			this.tabMode = new AirVPN.Gui.Skin.TabPage();
			this.optModeTCP443 = new AirVPN.Gui.Skin.RadioButton();
			this.optModeUDP443 = new AirVPN.Gui.Skin.RadioButton();
			this.optModeTCP2018 = new AirVPN.Gui.Skin.RadioButton();
			this.optModeUDP2018 = new AirVPN.Gui.Skin.RadioButton();
			this.optModeTCP53 = new AirVPN.Gui.Skin.RadioButton();
			this.optModeUDP53 = new AirVPN.Gui.Skin.RadioButton();
			this.optModeTCP80 = new AirVPN.Gui.Skin.RadioButton();
			this.optModeUDP80 = new AirVPN.Gui.Skin.RadioButton();
			this.label11 = new AirVPN.Gui.Skin.Label();
			this.optModeSSH53 = new AirVPN.Gui.Skin.RadioButton();
			this.optModeSSH80 = new AirVPN.Gui.Skin.RadioButton();
			this.optModeSSH22Alt = new AirVPN.Gui.Skin.RadioButton();
			this.optModeSSH22 = new AirVPN.Gui.Skin.RadioButton();
			this.optModeSSL443 = new AirVPN.Gui.Skin.RadioButton();
			this.lblModeSSH = new AirVPN.Gui.Skin.Label();
			this.lblModeSSL = new AirVPN.Gui.Skin.Label();
			this.optModeTCP2018Alt = new AirVPN.Gui.Skin.RadioButton();
			this.optModeUDP2018Alt = new AirVPN.Gui.Skin.RadioButton();
			this.optModeUDP53Alt = new AirVPN.Gui.Skin.RadioButton();
			this.optModeUDP80Alt = new AirVPN.Gui.Skin.RadioButton();
			this.optModeUDP443Alt = new AirVPN.Gui.Skin.RadioButton();
			this.label5 = new AirVPN.Gui.Skin.Label();
			this.lnkModeMore = new AirVPN.Gui.Skin.LinkLabel();
			this.tabProxy = new AirVPN.Gui.Skin.TabPage();
			this.label12 = new AirVPN.Gui.Skin.Label();
			this.lblProxyAuthentication = new AirVPN.Gui.Skin.Label();
			this.cboProxyAuthentication = new AirVPN.Gui.Skin.ComboBox();
			this.txtProxyPassword = new AirVPN.Gui.Skin.TextBox();
			this.lblProxyPassword = new AirVPN.Gui.Skin.Label();
			this.txtProxyLogin = new AirVPN.Gui.Skin.TextBox();
			this.lblProxyLogin = new AirVPN.Gui.Skin.Label();
			this.lblProxyType = new AirVPN.Gui.Skin.Label();
			this.cboProxyMode = new AirVPN.Gui.Skin.ComboBox();
			this.txtProxyPort = new AirVPN.Gui.Skin.TextBox();
			this.lblProxyPort = new AirVPN.Gui.Skin.Label();
			this.txtProxyHost = new AirVPN.Gui.Skin.TextBox();
			this.lblProxyHost = new AirVPN.Gui.Skin.Label();
			this.tabRoutes = new AirVPN.Gui.Skin.TabPage();
			this.cmdRouteEdit = new AirVPN.Gui.Skin.Button();
			this.cmdRouteRemove = new AirVPN.Gui.Skin.Button();
			this.cmdRouteAdd = new AirVPN.Gui.Skin.Button();
			this.label6 = new AirVPN.Gui.Skin.Label();
			this.cboRoutesOtherwise = new AirVPN.Gui.Skin.ComboBox();
			this.lblRoutesOtherwise = new AirVPN.Gui.Skin.Label();
			this.lstRoutes = new AirVPN.Gui.Skin.ListView();
			this.colRoutesIp = ((AirVPN.Gui.Skin.ColumnHeader)(new AirVPN.Gui.Skin.ColumnHeader()));
			this.colRoutesMask = ((AirVPN.Gui.Skin.ColumnHeader)(new AirVPN.Gui.Skin.ColumnHeader()));
			this.colRoutesAction = ((AirVPN.Gui.Skin.ColumnHeader)(new AirVPN.Gui.Skin.ColumnHeader()));
			this.tabAdvanced = new AirVPN.Gui.Skin.TabPage();
			this.tabAdvancedMain = new AirVPN.Gui.Skin.TabControl();
			this.tabPage4 = new AirVPN.Gui.Skin.TabPage();
			this.TxtLoggingPathComputed = new AirVPN.Gui.Skin.Label();
			this.lblLoggingHelp = new AirVPN.Gui.Skin.Label();
			this.TxtLoggingPath = new AirVPN.Gui.Skin.TextBox();
			this.label8 = new AirVPN.Gui.Skin.Label();
			this.chkLoggingEnabled = new AirVPN.Gui.Skin.CheckBox();
			tabPage1 = new AirVPN.Gui.Skin.TabPage();
			tabPage2 = new AirVPN.Gui.Skin.TabPage();
			tabPage3 = new AirVPN.Gui.Skin.TabPage();
			columnHeader1 = ((AirVPN.Gui.Skin.ColumnHeader)(new AirVPN.Gui.Skin.ColumnHeader()));
			columnHeader2 = ((AirVPN.Gui.Skin.ColumnHeader)(new AirVPN.Gui.Skin.ColumnHeader()));
			tabPage1.SuspendLayout();
			this.pnlAdvancedGeneralWindowsOnly.SuspendLayout();
			tabPage2.SuspendLayout();
			tabPage3.SuspendLayout();
			this.mnuRoutes.SuspendLayout();
			this.pnlCommands.SuspendLayout();
			this.tabSettings.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			this.pnlGeneralWindowsOnly.SuspendLayout();
			this.tabMode.SuspendLayout();
			this.tabProxy.SuspendLayout();
			this.tabRoutes.SuspendLayout();
			this.tabAdvanced.SuspendLayout();
			this.tabAdvancedMain.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabPage1
			// 
			tabPage1.BackColor = System.Drawing.Color.White;
			tabPage1.Controls.Add(this.chkAdvancedNetworkLocking);
			tabPage1.Controls.Add(this.label7);
			tabPage1.Controls.Add(this.cboDnsSwitchMode);
			tabPage1.Controls.Add(this.pnlAdvancedGeneralWindowsOnly);
			tabPage1.Controls.Add(this.lnkAdvancedDocs);
			tabPage1.Controls.Add(this.chkAdvancedPingerAlways);
			tabPage1.Controls.Add(this.chkAdvancedPingerEnabled);
			tabPage1.Controls.Add(this.cmdExeBrowse);
			tabPage1.Controls.Add(this.txtExePath);
			tabPage1.Controls.Add(this.label4);
			tabPage1.Controls.Add(this.chkAdvancedCheckRoute);
			tabPage1.Controls.Add(this.chkAdvancedCheckDns);
			tabPage1.Controls.Add(this.chkExpert);
			tabPage1.Location = new System.Drawing.Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new System.Windows.Forms.Padding(3);
			tabPage1.Size = new System.Drawing.Size(622, 263);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "General";
			// 
			// chkAdvancedNetworkLocking
			// 
			this.chkAdvancedNetworkLocking.BackColor = System.Drawing.Color.Transparent;
			this.chkAdvancedNetworkLocking.ForeColor = System.Drawing.Color.Black;
			this.chkAdvancedNetworkLocking.Location = new System.Drawing.Point(450, 179);
			this.chkAdvancedNetworkLocking.Name = "chkAdvancedNetworkLocking";
			this.chkAdvancedNetworkLocking.Size = new System.Drawing.Size(152, 26);
			this.chkAdvancedNetworkLocking.TabIndex = 68;
			this.chkAdvancedNetworkLocking.Text = "Enable Network Locking";
			this.chkAdvancedNetworkLocking.UseVisualStyleBackColor = false;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(15, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 13);
			this.label7.TabIndex = 72;
			this.label7.Text = "DNS Switch mode:";
			// 
			// cboDnsSwitchMode
			// 
			this.cboDnsSwitchMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cboDnsSwitchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDnsSwitchMode.FormattingEnabled = true;
			this.cboDnsSwitchMode.Items.AddRange(new object[] {
            "Disabled",
            "Automatic",
            "Resolvconf (Linux only)",
            "Renaming (Linux only)"});
			this.cboDnsSwitchMode.Location = new System.Drawing.Point(131, 53);
			this.cboDnsSwitchMode.Name = "cboDnsSwitchMode";
			this.cboDnsSwitchMode.Size = new System.Drawing.Size(125, 21);
			this.cboDnsSwitchMode.TabIndex = 71;
			// 
			// pnlAdvancedGeneralWindowsOnly
			// 
			this.pnlAdvancedGeneralWindowsOnly.Controls.Add(this.chkAdvancedWindowsTapUp);
			this.pnlAdvancedGeneralWindowsOnly.Controls.Add(this.chkAdvancedWindowsForceDns);
			this.pnlAdvancedGeneralWindowsOnly.Controls.Add(this.chkAdvancedWindowsDhcpSwitch);
			this.pnlAdvancedGeneralWindowsOnly.Controls.Add(this.cmdAdvancedUninstallDriver);
			this.pnlAdvancedGeneralWindowsOnly.Location = new System.Drawing.Point(338, 18);
			this.pnlAdvancedGeneralWindowsOnly.Name = "pnlAdvancedGeneralWindowsOnly";
			this.pnlAdvancedGeneralWindowsOnly.Size = new System.Drawing.Size(264, 141);
			this.pnlAdvancedGeneralWindowsOnly.TabIndex = 69;
			this.pnlAdvancedGeneralWindowsOnly.TabStop = false;
			this.pnlAdvancedGeneralWindowsOnly.Text = "Microsoft Windows Only";
			// 
			// chkAdvancedWindowsTapUp
			// 
			this.chkAdvancedWindowsTapUp.AutoSize = true;
			this.chkAdvancedWindowsTapUp.BackColor = System.Drawing.Color.Transparent;
			this.chkAdvancedWindowsTapUp.ForeColor = System.Drawing.Color.Black;
			this.chkAdvancedWindowsTapUp.Location = new System.Drawing.Point(23, 23);
			this.chkAdvancedWindowsTapUp.Name = "chkAdvancedWindowsTapUp";
			this.chkAdvancedWindowsTapUp.Size = new System.Drawing.Size(139, 17);
			this.chkAdvancedWindowsTapUp.TabIndex = 55;
			this.chkAdvancedWindowsTapUp.Text = "Force TAP interface UP";
			this.chkAdvancedWindowsTapUp.UseVisualStyleBackColor = false;
			// 
			// chkAdvancedWindowsForceDns
			// 
			this.chkAdvancedWindowsForceDns.BackColor = System.Drawing.Color.Transparent;
			this.chkAdvancedWindowsForceDns.ForeColor = System.Drawing.Color.Black;
			this.chkAdvancedWindowsForceDns.Location = new System.Drawing.Point(23, 46);
			this.chkAdvancedWindowsForceDns.Name = "chkAdvancedWindowsForceDns";
			this.chkAdvancedWindowsForceDns.Size = new System.Drawing.Size(300, 17);
			this.chkAdvancedWindowsForceDns.TabIndex = 61;
			this.chkAdvancedWindowsForceDns.Text = "Force DNS";
			this.chkAdvancedWindowsForceDns.UseVisualStyleBackColor = false;
			// 
			// chkAdvancedWindowsDhcpSwitch
			// 
			this.chkAdvancedWindowsDhcpSwitch.BackColor = System.Drawing.Color.Transparent;
			this.chkAdvancedWindowsDhcpSwitch.ForeColor = System.Drawing.Color.Black;
			this.chkAdvancedWindowsDhcpSwitch.Location = new System.Drawing.Point(23, 69);
			this.chkAdvancedWindowsDhcpSwitch.Name = "chkAdvancedWindowsDhcpSwitch";
			this.chkAdvancedWindowsDhcpSwitch.Size = new System.Drawing.Size(300, 17);
			this.chkAdvancedWindowsDhcpSwitch.TabIndex = 64;
			this.chkAdvancedWindowsDhcpSwitch.Text = "Switch DHCP to Static";
			this.chkAdvancedWindowsDhcpSwitch.UseVisualStyleBackColor = false;
			// 
			// cmdAdvancedUninstallDriver
			// 
			this.cmdAdvancedUninstallDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdAdvancedUninstallDriver.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdAdvancedUninstallDriver.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdAdvancedUninstallDriver.FlatAppearance.BorderSize = 0;
			this.cmdAdvancedUninstallDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdAdvancedUninstallDriver.Location = new System.Drawing.Point(6, 99);
			this.cmdAdvancedUninstallDriver.Name = "cmdAdvancedUninstallDriver";
			this.cmdAdvancedUninstallDriver.Size = new System.Drawing.Size(252, 30);
			this.cmdAdvancedUninstallDriver.TabIndex = 65;
			this.cmdAdvancedUninstallDriver.Text = "Uninstall Driver";
			this.cmdAdvancedUninstallDriver.UseVisualStyleBackColor = true;
			this.cmdAdvancedUninstallDriver.Click += new System.EventHandler(this.cmdAdvancedUninstallDriver_Click);
			// 
			// lnkAdvancedDocs
			// 
			this.lnkAdvancedDocs.BackColor = System.Drawing.Color.Transparent;
			this.lnkAdvancedDocs.ForeColor = System.Drawing.Color.Black;
			this.lnkAdvancedDocs.Image = global::AirVPN.Lib.Forms.Properties.Resources.tip;
			this.lnkAdvancedDocs.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.lnkAdvancedDocs.Location = new System.Drawing.Point(471, 220);
			this.lnkAdvancedDocs.Name = "lnkAdvancedDocs";
			this.lnkAdvancedDocs.Size = new System.Drawing.Size(131, 27);
			this.lnkAdvancedDocs.TabIndex = 68;
			this.lnkAdvancedDocs.TabStop = true;
			this.lnkAdvancedDocs.Text = "     Click here to read about advanced options.";
			this.lnkAdvancedDocs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdvancedDocs_LinkClicked);
			// 
			// chkAdvancedPingerAlways
			// 
			this.chkAdvancedPingerAlways.BackColor = System.Drawing.Color.Transparent;
			this.chkAdvancedPingerAlways.ForeColor = System.Drawing.Color.Black;
			this.chkAdvancedPingerAlways.Location = new System.Drawing.Point(16, 165);
			this.chkAdvancedPingerAlways.Name = "chkAdvancedPingerAlways";
			this.chkAdvancedPingerAlways.Size = new System.Drawing.Size(300, 17);
			this.chkAdvancedPingerAlways.TabIndex = 67;
			this.chkAdvancedPingerAlways.Text = "Enable Pinger outside tunnel during connection";
			this.chkAdvancedPingerAlways.UseVisualStyleBackColor = false;
			// 
			// chkAdvancedPingerEnabled
			// 
			this.chkAdvancedPingerEnabled.BackColor = System.Drawing.Color.Transparent;
			this.chkAdvancedPingerEnabled.ForeColor = System.Drawing.Color.Black;
			this.chkAdvancedPingerEnabled.Location = new System.Drawing.Point(16, 142);
			this.chkAdvancedPingerEnabled.Name = "chkAdvancedPingerEnabled";
			this.chkAdvancedPingerEnabled.Size = new System.Drawing.Size(300, 17);
			this.chkAdvancedPingerEnabled.TabIndex = 66;
			this.chkAdvancedPingerEnabled.Text = "Enable Pinger / Latency Tests";
			this.chkAdvancedPingerEnabled.UseVisualStyleBackColor = false;
			// 
			// cmdExeBrowse
			// 
			this.cmdExeBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdExeBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdExeBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdExeBrowse.FlatAppearance.BorderSize = 0;
			this.cmdExeBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdExeBrowse.Image = global::AirVPN.Lib.Forms.Properties.Resources.browse;
			this.cmdExeBrowse.Location = new System.Drawing.Point(308, 224);
			this.cmdExeBrowse.Name = "cmdExeBrowse";
			this.cmdExeBrowse.Size = new System.Drawing.Size(31, 25);
			this.cmdExeBrowse.TabIndex = 60;
			this.cmdExeBrowse.UseVisualStyleBackColor = true;
			this.cmdExeBrowse.Click += new System.EventHandler(this.cmdExeBrowse_Click);
			// 
			// txtExePath
			// 
			this.txtExePath.Location = new System.Drawing.Point(16, 227);
			this.txtExePath.Name = "txtExePath";
			this.txtExePath.Size = new System.Drawing.Size(286, 20);
			this.txtExePath.TabIndex = 59;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(15, 211);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 13);
			this.label4.TabIndex = 58;
			this.label4.Text = "OpenVPN Custom Path:";
			// 
			// chkAdvancedCheckRoute
			// 
			this.chkAdvancedCheckRoute.BackColor = System.Drawing.Color.Transparent;
			this.chkAdvancedCheckRoute.ForeColor = System.Drawing.Color.Black;
			this.chkAdvancedCheckRoute.Location = new System.Drawing.Point(16, 103);
			this.chkAdvancedCheckRoute.Name = "chkAdvancedCheckRoute";
			this.chkAdvancedCheckRoute.Size = new System.Drawing.Size(300, 17);
			this.chkAdvancedCheckRoute.TabIndex = 57;
			this.chkAdvancedCheckRoute.Text = "Checking if the tunnel effectively works";
			this.chkAdvancedCheckRoute.UseVisualStyleBackColor = false;
			// 
			// chkAdvancedCheckDns
			// 
			this.chkAdvancedCheckDns.AutoSize = true;
			this.chkAdvancedCheckDns.BackColor = System.Drawing.Color.Transparent;
			this.chkAdvancedCheckDns.ForeColor = System.Drawing.Color.Black;
			this.chkAdvancedCheckDns.Location = new System.Drawing.Point(16, 80);
			this.chkAdvancedCheckDns.Name = "chkAdvancedCheckDns";
			this.chkAdvancedCheckDns.Size = new System.Drawing.Size(212, 17);
			this.chkAdvancedCheckDns.TabIndex = 56;
			this.chkAdvancedCheckDns.Text = "Checking if the tunnel use AirVPN DNS";
			this.chkAdvancedCheckDns.UseVisualStyleBackColor = false;
			// 
			// chkExpert
			// 
			this.chkExpert.AutoSize = true;
			this.chkExpert.BackColor = System.Drawing.Color.Transparent;
			this.chkExpert.ForeColor = System.Drawing.Color.Black;
			this.chkExpert.Location = new System.Drawing.Point(16, 21);
			this.chkExpert.Name = "chkExpert";
			this.chkExpert.Size = new System.Drawing.Size(86, 17);
			this.chkExpert.TabIndex = 54;
			this.chkExpert.Text = "Expert Mode";
			this.chkExpert.UseVisualStyleBackColor = false;
			// 
			// tabPage2
			// 
			tabPage2.BackColor = System.Drawing.Color.White;
			tabPage2.Controls.Add(this.label3);
			tabPage2.Controls.Add(this.label2);
			tabPage2.Controls.Add(this.chkAdvancedOpenVpnDirectivesDefaultSkip);
			tabPage2.Controls.Add(this.txtAdvancedOpenVpnDirectivesDefault);
			tabPage2.Controls.Add(this.txtAdvancedOpenVpnDirectivesCustom);
			tabPage2.Location = new System.Drawing.Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new System.Windows.Forms.Padding(3);
			tabPage2.Size = new System.Drawing.Size(622, 263);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "OVPN directives";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(310, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 13);
			this.label3.TabIndex = 61;
			this.label3.Text = "Default:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(6, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 13);
			this.label2.TabIndex = 60;
			this.label2.Text = "Custom:";
			// 
			// chkAdvancedOpenVpnDirectivesDefaultSkip
			// 
			this.chkAdvancedOpenVpnDirectivesDefaultSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.chkAdvancedOpenVpnDirectivesDefaultSkip.BackColor = System.Drawing.Color.Transparent;
			this.chkAdvancedOpenVpnDirectivesDefaultSkip.ForeColor = System.Drawing.Color.Black;
			this.chkAdvancedOpenVpnDirectivesDefaultSkip.Location = new System.Drawing.Point(313, 225);
			this.chkAdvancedOpenVpnDirectivesDefaultSkip.Name = "chkAdvancedOpenVpnDirectivesDefaultSkip";
			this.chkAdvancedOpenVpnDirectivesDefaultSkip.Size = new System.Drawing.Size(306, 32);
			this.chkAdvancedOpenVpnDirectivesDefaultSkip.TabIndex = 59;
			this.chkAdvancedOpenVpnDirectivesDefaultSkip.Text = "Skip the above default directives. If unchecked, your custom directives are appen" +
    "ded.";
			this.chkAdvancedOpenVpnDirectivesDefaultSkip.UseVisualStyleBackColor = false;
			// 
			// txtAdvancedOpenVpnDirectivesDefault
			// 
			this.txtAdvancedOpenVpnDirectivesDefault.AcceptsReturn = true;
			this.txtAdvancedOpenVpnDirectivesDefault.AcceptsTab = true;
			this.txtAdvancedOpenVpnDirectivesDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAdvancedOpenVpnDirectivesDefault.Location = new System.Drawing.Point(313, 23);
			this.txtAdvancedOpenVpnDirectivesDefault.Multiline = true;
			this.txtAdvancedOpenVpnDirectivesDefault.Name = "txtAdvancedOpenVpnDirectivesDefault";
			this.txtAdvancedOpenVpnDirectivesDefault.ReadOnly = true;
			this.txtAdvancedOpenVpnDirectivesDefault.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtAdvancedOpenVpnDirectivesDefault.Size = new System.Drawing.Size(306, 196);
			this.txtAdvancedOpenVpnDirectivesDefault.TabIndex = 58;
			// 
			// txtAdvancedOpenVpnDirectivesCustom
			// 
			this.txtAdvancedOpenVpnDirectivesCustom.AcceptsReturn = true;
			this.txtAdvancedOpenVpnDirectivesCustom.AcceptsTab = true;
			this.txtAdvancedOpenVpnDirectivesCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAdvancedOpenVpnDirectivesCustom.Location = new System.Drawing.Point(9, 23);
			this.txtAdvancedOpenVpnDirectivesCustom.Multiline = true;
			this.txtAdvancedOpenVpnDirectivesCustom.Name = "txtAdvancedOpenVpnDirectivesCustom";
			this.txtAdvancedOpenVpnDirectivesCustom.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtAdvancedOpenVpnDirectivesCustom.Size = new System.Drawing.Size(304, 196);
			this.txtAdvancedOpenVpnDirectivesCustom.TabIndex = 57;
			// 
			// tabPage3
			// 
			tabPage3.BackColor = System.Drawing.Color.White;
			tabPage3.Controls.Add(this.cmdAdvancedEventsEdit);
			tabPage3.Controls.Add(this.cmdAdvancedEventsClear);
			tabPage3.Controls.Add(this.lstAdvancedEvents);
			tabPage3.Controls.Add(this.label1);
			tabPage3.Location = new System.Drawing.Point(4, 24);
			tabPage3.Name = "tabPage3";
			tabPage3.Size = new System.Drawing.Size(622, 263);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "Events";
			// 
			// cmdAdvancedEventsEdit
			// 
			this.cmdAdvancedEventsEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAdvancedEventsEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdAdvancedEventsEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdAdvancedEventsEdit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdAdvancedEventsEdit.FlatAppearance.BorderSize = 0;
			this.cmdAdvancedEventsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdAdvancedEventsEdit.Image = global::AirVPN.Lib.Forms.Properties.Resources.edit_16;
			this.cmdAdvancedEventsEdit.Location = new System.Drawing.Point(589, 57);
			this.cmdAdvancedEventsEdit.Name = "cmdAdvancedEventsEdit";
			this.cmdAdvancedEventsEdit.Size = new System.Drawing.Size(30, 30);
			this.cmdAdvancedEventsEdit.TabIndex = 59;
			this.cmdAdvancedEventsEdit.UseVisualStyleBackColor = true;
			this.cmdAdvancedEventsEdit.Click += new System.EventHandler(this.cmdAdvancedEventsEdit_Click);
			// 
			// cmdAdvancedEventsClear
			// 
			this.cmdAdvancedEventsClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAdvancedEventsClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdAdvancedEventsClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdAdvancedEventsClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdAdvancedEventsClear.FlatAppearance.BorderSize = 0;
			this.cmdAdvancedEventsClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdAdvancedEventsClear.Image = global::AirVPN.Lib.Forms.Properties.Resources.delete_16;
			this.cmdAdvancedEventsClear.Location = new System.Drawing.Point(589, 23);
			this.cmdAdvancedEventsClear.Name = "cmdAdvancedEventsClear";
			this.cmdAdvancedEventsClear.Size = new System.Drawing.Size(30, 30);
			this.cmdAdvancedEventsClear.TabIndex = 58;
			this.cmdAdvancedEventsClear.UseVisualStyleBackColor = true;
			this.cmdAdvancedEventsClear.Click += new System.EventHandler(this.cmdAdvancedEventsClear_Click);
			// 
			// lstAdvancedEvents
			// 
			this.lstAdvancedEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstAdvancedEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lstAdvancedEvents.FullRowSelect = true;
			this.lstAdvancedEvents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstAdvancedEvents.HideSelection = false;
			this.lstAdvancedEvents.Location = new System.Drawing.Point(9, 23);
			this.lstAdvancedEvents.MultiSelect = false;
			this.lstAdvancedEvents.Name = "lstAdvancedEvents";
			this.lstAdvancedEvents.OwnerDraw = true;
			this.lstAdvancedEvents.Size = new System.Drawing.Size(574, 228);
			this.lstAdvancedEvents.SmallImageList = this.imgRoutes;
			this.lstAdvancedEvents.TabIndex = 57;
			this.lstAdvancedEvents.UseCompatibleStateImageBehavior = false;
			this.lstAdvancedEvents.View = System.Windows.Forms.View.Details;
			this.lstAdvancedEvents.SelectedIndexChanged += new System.EventHandler(this.lstAdvancedEvents_SelectedIndexChanged);
			this.lstAdvancedEvents.DoubleClick += new System.EventHandler(this.lstAdvancedEvents_DoubleClick);
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Event";
			columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "File name";
			columnHeader2.Width = 220;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Arguments";
			this.columnHeader3.Width = 180;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Wait End";
			// 
			// imgRoutes
			// 
			this.imgRoutes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgRoutes.ImageStream")));
			this.imgRoutes.TransparentColor = System.Drawing.Color.Transparent;
			this.imgRoutes.Images.SetKeyName(0, "in");
			this.imgRoutes.Images.SetKeyName(1, "out");
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(6, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(324, 13);
			this.label1.TabIndex = 56;
			this.label1.Text = "External shell (double click to browse):";
			// 
			// mnuRoutes
			// 
			this.mnuRoutes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRoutesAdd,
            this.mnuRoutesRemove,
            this.mnuRoutesEdit});
			this.mnuRoutes.Name = "mnuServers";
			this.mnuRoutes.Size = new System.Drawing.Size(117, 70);
			// 
			// mnuRoutesAdd
			// 
			this.mnuRoutesAdd.Image = global::AirVPN.Lib.Forms.Properties.Resources.add_16;
			this.mnuRoutesAdd.Name = "mnuRoutesAdd";
			this.mnuRoutesAdd.Size = new System.Drawing.Size(116, 22);
			this.mnuRoutesAdd.Text = "Add";
			this.mnuRoutesAdd.Click += new System.EventHandler(this.mnuRoutesAdd_Click);
			// 
			// mnuRoutesRemove
			// 
			this.mnuRoutesRemove.Image = global::AirVPN.Lib.Forms.Properties.Resources.delete_16;
			this.mnuRoutesRemove.Name = "mnuRoutesRemove";
			this.mnuRoutesRemove.Size = new System.Drawing.Size(116, 22);
			this.mnuRoutesRemove.Text = "Remove";
			this.mnuRoutesRemove.Click += new System.EventHandler(this.mnuRoutesRemove_Click);
			// 
			// mnuRoutesEdit
			// 
			this.mnuRoutesEdit.Image = global::AirVPN.Lib.Forms.Properties.Resources.edit_16;
			this.mnuRoutesEdit.Name = "mnuRoutesEdit";
			this.mnuRoutesEdit.Size = new System.Drawing.Size(116, 22);
			this.mnuRoutesEdit.Text = "Edit";
			this.mnuRoutesEdit.Click += new System.EventHandler(this.mnuRoutesEdit_Click);
			// 
			// colLogDate
			// 
			this.colLogDate.Text = "Date";
			// 
			// colLogMessage
			// 
			this.colLogMessage.Text = "Message";
			this.colLogMessage.Width = 600;
			// 
			// openExeDialog
			// 
			this.openExeDialog.FileName = "openvpn.exe";
			this.openExeDialog.Filter = "openvpn.exe|openvpn.exe";
			this.openExeDialog.ReadOnlyChecked = true;
			this.openExeDialog.ShowReadOnly = true;
			// 
			// pnlCommands
			// 
			this.pnlCommands.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.pnlCommands.BackColor = System.Drawing.Color.Transparent;
			this.pnlCommands.Controls.Add(this.cmdCancel);
			this.pnlCommands.Controls.Add(this.cmdOk);
			this.pnlCommands.Location = new System.Drawing.Point(165, 325);
			this.pnlCommands.Name = "pnlCommands";
			this.pnlCommands.Size = new System.Drawing.Size(309, 36);
			this.pnlCommands.TabIndex = 42;
			// 
			// cmdCancel
			// 
			this.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdCancel.FlatAppearance.BorderSize = 0;
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdCancel.Location = new System.Drawing.Point(156, 3);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(150, 30);
			this.cmdCancel.TabIndex = 41;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.UseVisualStyleBackColor = true;
			// 
			// cmdOk
			// 
			this.cmdOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdOk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmdOk.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdOk.FlatAppearance.BorderSize = 0;
			this.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdOk.Location = new System.Drawing.Point(3, 3);
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.Size = new System.Drawing.Size(150, 30);
			this.cmdOk.TabIndex = 40;
			this.cmdOk.Text = "Save";
			this.cmdOk.UseVisualStyleBackColor = true;
			this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
			// 
			// tabSettings
			// 
			this.tabSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabSettings.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabSettings.Controls.Add(this.tabGeneral);
			this.tabSettings.Controls.Add(this.tabMode);
			this.tabSettings.Controls.Add(this.tabProxy);
			this.tabSettings.Controls.Add(this.tabRoutes);
			this.tabSettings.Controls.Add(this.tabAdvanced);
			this.tabSettings.ItemSize = new System.Drawing.Size(80, 20);
			this.tabSettings.Location = new System.Drawing.Point(0, 0);
			this.tabSettings.Name = "tabSettings";
			this.tabSettings.SelectedIndex = 0;
			this.tabSettings.Size = new System.Drawing.Size(638, 319);
			this.tabSettings.TabIndex = 41;
			// 
			// tabGeneral
			// 
			this.tabGeneral.BackColor = System.Drawing.Color.White;
			this.tabGeneral.Controls.Add(this.pnlGeneralWindowsOnly);
			this.tabGeneral.Controls.Add(this.lblGeneralTheme);
			this.tabGeneral.Controls.Add(this.cboGeneralTheme);
			this.tabGeneral.Controls.Add(this.chkGeneralStartLast);
			this.tabGeneral.Controls.Add(this.cmdTos);
			this.tabGeneral.Controls.Add(this.chkAutoStart);
			this.tabGeneral.Location = new System.Drawing.Point(4, 24);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Size = new System.Drawing.Size(630, 291);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "General";
			// 
			// pnlGeneralWindowsOnly
			// 
			this.pnlGeneralWindowsOnly.Controls.Add(this.chkSystemStart);
			this.pnlGeneralWindowsOnly.Controls.Add(this.chkMinimizeTray);
			this.pnlGeneralWindowsOnly.Location = new System.Drawing.Point(409, 15);
			this.pnlGeneralWindowsOnly.Name = "pnlGeneralWindowsOnly";
			this.pnlGeneralWindowsOnly.Size = new System.Drawing.Size(200, 100);
			this.pnlGeneralWindowsOnly.TabIndex = 65;
			this.pnlGeneralWindowsOnly.TabStop = false;
			this.pnlGeneralWindowsOnly.Text = "Microsoft Windows Only";
			// 
			// chkSystemStart
			// 
			this.chkSystemStart.AutoSize = true;
			this.chkSystemStart.BackColor = System.Drawing.Color.Transparent;
			this.chkSystemStart.ForeColor = System.Drawing.Color.Black;
			this.chkSystemStart.Location = new System.Drawing.Point(20, 23);
			this.chkSystemStart.Name = "chkSystemStart";
			this.chkSystemStart.Size = new System.Drawing.Size(117, 17);
			this.chkSystemStart.TabIndex = 31;
			this.chkSystemStart.Text = "Start with Windows";
			this.chkSystemStart.UseVisualStyleBackColor = false;
			// 
			// chkMinimizeTray
			// 
			this.chkMinimizeTray.AutoSize = true;
			this.chkMinimizeTray.BackColor = System.Drawing.Color.Transparent;
			this.chkMinimizeTray.ForeColor = System.Drawing.Color.Black;
			this.chkMinimizeTray.Location = new System.Drawing.Point(20, 46);
			this.chkMinimizeTray.Name = "chkMinimizeTray";
			this.chkMinimizeTray.Size = new System.Drawing.Size(120, 17);
			this.chkMinimizeTray.TabIndex = 39;
			this.chkMinimizeTray.Text = "Minimize in tray icon";
			this.chkMinimizeTray.UseVisualStyleBackColor = false;
			// 
			// lblGeneralTheme
			// 
			this.lblGeneralTheme.BackColor = System.Drawing.Color.Transparent;
			this.lblGeneralTheme.ForeColor = System.Drawing.Color.Black;
			this.lblGeneralTheme.Location = new System.Drawing.Point(17, 258);
			this.lblGeneralTheme.Name = "lblGeneralTheme";
			this.lblGeneralTheme.Size = new System.Drawing.Size(45, 20);
			this.lblGeneralTheme.TabIndex = 43;
			this.lblGeneralTheme.Text = "Theme:";
			this.lblGeneralTheme.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cboGeneralTheme
			// 
			this.cboGeneralTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboGeneralTheme.FormattingEnabled = true;
			this.cboGeneralTheme.Items.AddRange(new object[] {
            "Light",
            "Dark"});
			this.cboGeneralTheme.Location = new System.Drawing.Point(66, 254);
			this.cboGeneralTheme.Name = "cboGeneralTheme";
			this.cboGeneralTheme.Size = new System.Drawing.Size(63, 21);
			this.cboGeneralTheme.TabIndex = 42;
			this.cboGeneralTheme.SelectedIndexChanged += new System.EventHandler(this.cboGeneralTheme_SelectedIndexChanged);
			// 
			// chkGeneralStartLast
			// 
			this.chkGeneralStartLast.BackColor = System.Drawing.Color.Transparent;
			this.chkGeneralStartLast.ForeColor = System.Drawing.Color.Black;
			this.chkGeneralStartLast.Location = new System.Drawing.Point(16, 38);
			this.chkGeneralStartLast.Name = "chkGeneralStartLast";
			this.chkGeneralStartLast.Size = new System.Drawing.Size(263, 40);
			this.chkGeneralStartLast.TabIndex = 40;
			this.chkGeneralStartLast.Text = "Force reconnection to last server at startup (otherwise current best server is pi" +
    "cked)";
			this.chkGeneralStartLast.UseVisualStyleBackColor = false;
			// 
			// cmdTos
			// 
			this.cmdTos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdTos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdTos.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdTos.FlatAppearance.BorderSize = 0;
			this.cmdTos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdTos.Location = new System.Drawing.Point(409, 245);
			this.cmdTos.Name = "cmdTos";
			this.cmdTos.Size = new System.Drawing.Size(200, 30);
			this.cmdTos.TabIndex = 38;
			this.cmdTos.Text = "Terms of Service";
			this.cmdTos.UseVisualStyleBackColor = true;
			this.cmdTos.Click += new System.EventHandler(this.cmdTos_Click);
			// 
			// chkAutoStart
			// 
			this.chkAutoStart.AutoSize = true;
			this.chkAutoStart.BackColor = System.Drawing.Color.Transparent;
			this.chkAutoStart.ForeColor = System.Drawing.Color.Black;
			this.chkAutoStart.Location = new System.Drawing.Point(16, 15);
			this.chkAutoStart.Name = "chkAutoStart";
			this.chkAutoStart.Size = new System.Drawing.Size(113, 17);
			this.chkAutoStart.TabIndex = 30;
			this.chkAutoStart.Text = "Connect at startup";
			this.chkAutoStart.UseVisualStyleBackColor = false;
			// 
			// tabMode
			// 
			this.tabMode.BackColor = System.Drawing.Color.White;
			this.tabMode.Controls.Add(this.optModeTCP443);
			this.tabMode.Controls.Add(this.optModeUDP443);
			this.tabMode.Controls.Add(this.optModeTCP2018);
			this.tabMode.Controls.Add(this.optModeUDP2018);
			this.tabMode.Controls.Add(this.optModeTCP53);
			this.tabMode.Controls.Add(this.optModeUDP53);
			this.tabMode.Controls.Add(this.optModeTCP80);
			this.tabMode.Controls.Add(this.optModeUDP80);
			this.tabMode.Controls.Add(this.label11);
			this.tabMode.Controls.Add(this.optModeSSH53);
			this.tabMode.Controls.Add(this.optModeSSH80);
			this.tabMode.Controls.Add(this.optModeSSH22Alt);
			this.tabMode.Controls.Add(this.optModeSSH22);
			this.tabMode.Controls.Add(this.optModeSSL443);
			this.tabMode.Controls.Add(this.lblModeSSH);
			this.tabMode.Controls.Add(this.lblModeSSL);
			this.tabMode.Controls.Add(this.optModeTCP2018Alt);
			this.tabMode.Controls.Add(this.optModeUDP2018Alt);
			this.tabMode.Controls.Add(this.optModeUDP53Alt);
			this.tabMode.Controls.Add(this.optModeUDP80Alt);
			this.tabMode.Controls.Add(this.optModeUDP443Alt);
			this.tabMode.Controls.Add(this.label5);
			this.tabMode.Controls.Add(this.lnkModeMore);
			this.tabMode.Location = new System.Drawing.Point(4, 24);
			this.tabMode.Name = "tabMode";
			this.tabMode.Size = new System.Drawing.Size(630, 291);
			this.tabMode.TabIndex = 3;
			this.tabMode.Text = "Protocols";
			// 
			// optModeTCP443
			// 
			this.optModeTCP443.AutoSize = true;
			this.optModeTCP443.BackColor = System.Drawing.Color.Transparent;
			this.optModeTCP443.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optModeTCP443.ForeColor = System.Drawing.Color.Black;
			this.optModeTCP443.Location = new System.Drawing.Point(40, 50);
			this.optModeTCP443.Name = "optModeTCP443";
			this.optModeTCP443.Size = new System.Drawing.Size(183, 20);
			this.optModeTCP443.TabIndex = 31;
			this.optModeTCP443.TabStop = true;
			this.optModeTCP443.Text = "Protocol TCP, port 443";
			this.optModeTCP443.UseVisualStyleBackColor = false;
			// 
			// optModeUDP443
			// 
			this.optModeUDP443.AutoSize = true;
			this.optModeUDP443.BackColor = System.Drawing.Color.Transparent;
			this.optModeUDP443.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optModeUDP443.ForeColor = System.Drawing.Color.Black;
			this.optModeUDP443.Location = new System.Drawing.Point(40, 23);
			this.optModeUDP443.Name = "optModeUDP443";
			this.optModeUDP443.Size = new System.Drawing.Size(185, 20);
			this.optModeUDP443.TabIndex = 30;
			this.optModeUDP443.TabStop = true;
			this.optModeUDP443.Text = "Protocol UDP, port 443";
			this.optModeUDP443.UseVisualStyleBackColor = false;
			// 
			// optModeTCP2018
			// 
			this.optModeTCP2018.AutoSize = true;
			this.optModeTCP2018.BackColor = System.Drawing.Color.Transparent;
			this.optModeTCP2018.ForeColor = System.Drawing.Color.Black;
			this.optModeTCP2018.Location = new System.Drawing.Point(15, 257);
			this.optModeTCP2018.Name = "optModeTCP2018";
			this.optModeTCP2018.Size = new System.Drawing.Size(141, 17);
			this.optModeTCP2018.TabIndex = 29;
			this.optModeTCP2018.TabStop = true;
			this.optModeTCP2018.Text = "Protocol TCP, port 2018";
			this.optModeTCP2018.UseVisualStyleBackColor = false;
			// 
			// optModeUDP2018
			// 
			this.optModeUDP2018.AutoSize = true;
			this.optModeUDP2018.BackColor = System.Drawing.Color.Transparent;
			this.optModeUDP2018.ForeColor = System.Drawing.Color.Black;
			this.optModeUDP2018.Location = new System.Drawing.Point(15, 234);
			this.optModeUDP2018.Name = "optModeUDP2018";
			this.optModeUDP2018.Size = new System.Drawing.Size(143, 17);
			this.optModeUDP2018.TabIndex = 28;
			this.optModeUDP2018.TabStop = true;
			this.optModeUDP2018.Text = "Protocol UDP, port 2018";
			this.optModeUDP2018.UseVisualStyleBackColor = false;
			// 
			// optModeTCP53
			// 
			this.optModeTCP53.AutoSize = true;
			this.optModeTCP53.BackColor = System.Drawing.Color.Transparent;
			this.optModeTCP53.ForeColor = System.Drawing.Color.Black;
			this.optModeTCP53.Location = new System.Drawing.Point(15, 211);
			this.optModeTCP53.Name = "optModeTCP53";
			this.optModeTCP53.Size = new System.Drawing.Size(129, 17);
			this.optModeTCP53.TabIndex = 27;
			this.optModeTCP53.TabStop = true;
			this.optModeTCP53.Text = "Protocol TCP, port 53";
			this.optModeTCP53.UseVisualStyleBackColor = false;
			// 
			// optModeUDP53
			// 
			this.optModeUDP53.AutoSize = true;
			this.optModeUDP53.BackColor = System.Drawing.Color.Transparent;
			this.optModeUDP53.ForeColor = System.Drawing.Color.Black;
			this.optModeUDP53.Location = new System.Drawing.Point(15, 188);
			this.optModeUDP53.Name = "optModeUDP53";
			this.optModeUDP53.Size = new System.Drawing.Size(131, 17);
			this.optModeUDP53.TabIndex = 26;
			this.optModeUDP53.TabStop = true;
			this.optModeUDP53.Text = "Protocol UDP, port 53";
			this.optModeUDP53.UseVisualStyleBackColor = false;
			// 
			// optModeTCP80
			// 
			this.optModeTCP80.AutoSize = true;
			this.optModeTCP80.BackColor = System.Drawing.Color.Transparent;
			this.optModeTCP80.ForeColor = System.Drawing.Color.Black;
			this.optModeTCP80.Location = new System.Drawing.Point(15, 165);
			this.optModeTCP80.Name = "optModeTCP80";
			this.optModeTCP80.Size = new System.Drawing.Size(129, 17);
			this.optModeTCP80.TabIndex = 25;
			this.optModeTCP80.TabStop = true;
			this.optModeTCP80.Text = "Protocol TCP, port 80";
			this.optModeTCP80.UseVisualStyleBackColor = false;
			// 
			// optModeUDP80
			// 
			this.optModeUDP80.AutoSize = true;
			this.optModeUDP80.BackColor = System.Drawing.Color.Transparent;
			this.optModeUDP80.ForeColor = System.Drawing.Color.Black;
			this.optModeUDP80.Location = new System.Drawing.Point(15, 142);
			this.optModeUDP80.Name = "optModeUDP80";
			this.optModeUDP80.Size = new System.Drawing.Size(131, 17);
			this.optModeUDP80.TabIndex = 24;
			this.optModeUDP80.TabStop = true;
			this.optModeUDP80.Text = "Protocol UDP, port 80";
			this.optModeUDP80.UseVisualStyleBackColor = false;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(6, 95);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(161, 39);
			this.label11.TabIndex = 23;
			this.label11.Text = "Alternative ports, \r\nif your ISP applies caps or blocks";
			// 
			// optModeSSH53
			// 
			this.optModeSSH53.AutoSize = true;
			this.optModeSSH53.BackColor = System.Drawing.Color.Transparent;
			this.optModeSSH53.ForeColor = System.Drawing.Color.Black;
			this.optModeSSH53.Location = new System.Drawing.Point(440, 206);
			this.optModeSSH53.Name = "optModeSSH53";
			this.optModeSSH53.Size = new System.Drawing.Size(61, 17);
			this.optModeSSH53.TabIndex = 22;
			this.optModeSSH53.TabStop = true;
			this.optModeSSH53.Text = "Port 53";
			this.optModeSSH53.UseVisualStyleBackColor = false;
			// 
			// optModeSSH80
			// 
			this.optModeSSH80.AutoSize = true;
			this.optModeSSH80.BackColor = System.Drawing.Color.Transparent;
			this.optModeSSH80.ForeColor = System.Drawing.Color.Black;
			this.optModeSSH80.Location = new System.Drawing.Point(440, 183);
			this.optModeSSH80.Name = "optModeSSH80";
			this.optModeSSH80.Size = new System.Drawing.Size(61, 17);
			this.optModeSSH80.TabIndex = 21;
			this.optModeSSH80.TabStop = true;
			this.optModeSSH80.Text = "Port 80";
			this.optModeSSH80.UseVisualStyleBackColor = false;
			// 
			// optModeSSH22Alt
			// 
			this.optModeSSH22Alt.AutoSize = true;
			this.optModeSSH22Alt.BackColor = System.Drawing.Color.Transparent;
			this.optModeSSH22Alt.ForeColor = System.Drawing.Color.Black;
			this.optModeSSH22Alt.Location = new System.Drawing.Point(440, 160);
			this.optModeSSH22Alt.Name = "optModeSSH22Alt";
			this.optModeSSH22Alt.Size = new System.Drawing.Size(160, 17);
			this.optModeSSH22Alt.TabIndex = 20;
			this.optModeSSH22Alt.TabStop = true;
			this.optModeSSH22Alt.Text = "Port 22 (Alternative Entry-IP)";
			this.optModeSSH22Alt.UseVisualStyleBackColor = false;
			// 
			// optModeSSH22
			// 
			this.optModeSSH22.AutoSize = true;
			this.optModeSSH22.BackColor = System.Drawing.Color.Transparent;
			this.optModeSSH22.ForeColor = System.Drawing.Color.Black;
			this.optModeSSH22.Location = new System.Drawing.Point(440, 137);
			this.optModeSSH22.Name = "optModeSSH22";
			this.optModeSSH22.Size = new System.Drawing.Size(61, 17);
			this.optModeSSH22.TabIndex = 19;
			this.optModeSSH22.TabStop = true;
			this.optModeSSH22.Text = "Port 22";
			this.optModeSSH22.UseVisualStyleBackColor = false;
			// 
			// optModeSSL443
			// 
			this.optModeSSL443.AutoSize = true;
			this.optModeSSL443.BackColor = System.Drawing.Color.Transparent;
			this.optModeSSL443.ForeColor = System.Drawing.Color.Black;
			this.optModeSSL443.Location = new System.Drawing.Point(440, 257);
			this.optModeSSL443.Name = "optModeSSL443";
			this.optModeSSL443.Size = new System.Drawing.Size(67, 17);
			this.optModeSSL443.TabIndex = 18;
			this.optModeSSL443.TabStop = true;
			this.optModeSSL443.Text = "Port 443";
			this.optModeSSL443.UseVisualStyleBackColor = false;
			// 
			// lblModeSSH
			// 
			this.lblModeSSH.BackColor = System.Drawing.Color.Transparent;
			this.lblModeSSH.ForeColor = System.Drawing.Color.Black;
			this.lblModeSSH.Location = new System.Drawing.Point(426, 116);
			this.lblModeSSH.Name = "lblModeSSH";
			this.lblModeSSH.Size = new System.Drawing.Size(221, 18);
			this.lblModeSSH.TabIndex = 17;
			this.lblModeSSH.Text = "SSH Tunnel";
			// 
			// lblModeSSL
			// 
			this.lblModeSSL.BackColor = System.Drawing.Color.Transparent;
			this.lblModeSSL.ForeColor = System.Drawing.Color.Black;
			this.lblModeSSL.Location = new System.Drawing.Point(426, 234);
			this.lblModeSSL.Name = "lblModeSSL";
			this.lblModeSSL.Size = new System.Drawing.Size(221, 15);
			this.lblModeSSL.TabIndex = 16;
			this.lblModeSSL.Text = "SSL Tunnel";
			// 
			// optModeTCP2018Alt
			// 
			this.optModeTCP2018Alt.AutoSize = true;
			this.optModeTCP2018Alt.BackColor = System.Drawing.Color.Transparent;
			this.optModeTCP2018Alt.ForeColor = System.Drawing.Color.Black;
			this.optModeTCP2018Alt.Location = new System.Drawing.Point(207, 234);
			this.optModeTCP2018Alt.Name = "optModeTCP2018Alt";
			this.optModeTCP2018Alt.Size = new System.Drawing.Size(141, 17);
			this.optModeTCP2018Alt.TabIndex = 15;
			this.optModeTCP2018Alt.TabStop = true;
			this.optModeTCP2018Alt.Text = "Protocol TCP, port 2018";
			this.optModeTCP2018Alt.UseVisualStyleBackColor = false;
			// 
			// optModeUDP2018Alt
			// 
			this.optModeUDP2018Alt.AutoSize = true;
			this.optModeUDP2018Alt.BackColor = System.Drawing.Color.Transparent;
			this.optModeUDP2018Alt.ForeColor = System.Drawing.Color.Black;
			this.optModeUDP2018Alt.Location = new System.Drawing.Point(207, 211);
			this.optModeUDP2018Alt.Name = "optModeUDP2018Alt";
			this.optModeUDP2018Alt.Size = new System.Drawing.Size(143, 17);
			this.optModeUDP2018Alt.TabIndex = 14;
			this.optModeUDP2018Alt.TabStop = true;
			this.optModeUDP2018Alt.Text = "Protocol UDP, port 2018";
			this.optModeUDP2018Alt.UseVisualStyleBackColor = false;
			// 
			// optModeUDP53Alt
			// 
			this.optModeUDP53Alt.AutoSize = true;
			this.optModeUDP53Alt.BackColor = System.Drawing.Color.Transparent;
			this.optModeUDP53Alt.ForeColor = System.Drawing.Color.Black;
			this.optModeUDP53Alt.Location = new System.Drawing.Point(207, 188);
			this.optModeUDP53Alt.Name = "optModeUDP53Alt";
			this.optModeUDP53Alt.Size = new System.Drawing.Size(131, 17);
			this.optModeUDP53Alt.TabIndex = 13;
			this.optModeUDP53Alt.TabStop = true;
			this.optModeUDP53Alt.Text = "Protocol UDP, port 53";
			this.optModeUDP53Alt.UseVisualStyleBackColor = false;
			// 
			// optModeUDP80Alt
			// 
			this.optModeUDP80Alt.AutoSize = true;
			this.optModeUDP80Alt.BackColor = System.Drawing.Color.Transparent;
			this.optModeUDP80Alt.ForeColor = System.Drawing.Color.Black;
			this.optModeUDP80Alt.Location = new System.Drawing.Point(207, 165);
			this.optModeUDP80Alt.Name = "optModeUDP80Alt";
			this.optModeUDP80Alt.Size = new System.Drawing.Size(131, 17);
			this.optModeUDP80Alt.TabIndex = 12;
			this.optModeUDP80Alt.TabStop = true;
			this.optModeUDP80Alt.Text = "Protocol UDP, port 80";
			this.optModeUDP80Alt.UseVisualStyleBackColor = false;
			// 
			// optModeUDP443Alt
			// 
			this.optModeUDP443Alt.AutoSize = true;
			this.optModeUDP443Alt.BackColor = System.Drawing.Color.Transparent;
			this.optModeUDP443Alt.ForeColor = System.Drawing.Color.Black;
			this.optModeUDP443Alt.Location = new System.Drawing.Point(207, 142);
			this.optModeUDP443Alt.Name = "optModeUDP443Alt";
			this.optModeUDP443Alt.Size = new System.Drawing.Size(137, 17);
			this.optModeUDP443Alt.TabIndex = 11;
			this.optModeUDP443Alt.TabStop = true;
			this.optModeUDP443Alt.Text = "Protocol UDP, port 443";
			this.optModeUDP443Alt.UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(199, 105);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(221, 29);
			this.label5.TabIndex = 8;
			this.label5.Text = "Alternative Entry IP, \r\nif your ISP blocks the standard Entry IP";
			// 
			// lnkModeMore
			// 
			this.lnkModeMore.AutoSize = true;
			this.lnkModeMore.BackColor = System.Drawing.Color.Transparent;
			this.lnkModeMore.ForeColor = System.Drawing.Color.Black;
			this.lnkModeMore.Image = global::AirVPN.Lib.Forms.Properties.Resources.tip;
			this.lnkModeMore.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.lnkModeMore.Location = new System.Drawing.Point(355, 43);
			this.lnkModeMore.Name = "lnkModeMore";
			this.lnkModeMore.Size = new System.Drawing.Size(260, 13);
			this.lnkModeMore.TabIndex = 7;
			this.lnkModeMore.TabStop = true;
			this.lnkModeMore.Text = "     Click here to read more about choosing a protocol.";
			this.lnkModeMore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkModeMore_LinkClicked);
			// 
			// tabProxy
			// 
			this.tabProxy.BackColor = System.Drawing.Color.White;
			this.tabProxy.Controls.Add(this.label12);
			this.tabProxy.Controls.Add(this.lblProxyAuthentication);
			this.tabProxy.Controls.Add(this.cboProxyAuthentication);
			this.tabProxy.Controls.Add(this.txtProxyPassword);
			this.tabProxy.Controls.Add(this.lblProxyPassword);
			this.tabProxy.Controls.Add(this.txtProxyLogin);
			this.tabProxy.Controls.Add(this.lblProxyLogin);
			this.tabProxy.Controls.Add(this.lblProxyType);
			this.tabProxy.Controls.Add(this.cboProxyMode);
			this.tabProxy.Controls.Add(this.txtProxyPort);
			this.tabProxy.Controls.Add(this.lblProxyPort);
			this.tabProxy.Controls.Add(this.txtProxyHost);
			this.tabProxy.Controls.Add(this.lblProxyHost);
			this.tabProxy.Location = new System.Drawing.Point(4, 24);
			this.tabProxy.Name = "tabProxy";
			this.tabProxy.Padding = new System.Windows.Forms.Padding(3);
			this.tabProxy.Size = new System.Drawing.Size(630, 291);
			this.tabProxy.TabIndex = 1;
			this.tabProxy.Text = "Proxy";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
			this.label12.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label12.Location = new System.Drawing.Point(387, 34);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(223, 43);
			this.label12.TabIndex = 44;
			this.label12.Text = "     Note: UDP, SSH and SSL connections will not be available if you use a proxy." +
    "";
			// 
			// lblProxyAuthentication
			// 
			this.lblProxyAuthentication.BackColor = System.Drawing.Color.Transparent;
			this.lblProxyAuthentication.ForeColor = System.Drawing.Color.Black;
			this.lblProxyAuthentication.Location = new System.Drawing.Point(161, 20);
			this.lblProxyAuthentication.Name = "lblProxyAuthentication";
			this.lblProxyAuthentication.Size = new System.Drawing.Size(100, 20);
			this.lblProxyAuthentication.TabIndex = 43;
			this.lblProxyAuthentication.Text = "Authentication:";
			this.lblProxyAuthentication.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cboProxyAuthentication
			// 
			this.cboProxyAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboProxyAuthentication.FormattingEnabled = true;
			this.cboProxyAuthentication.Items.AddRange(new object[] {
            "None",
            "Basic",
            "NTLM"});
			this.cboProxyAuthentication.Location = new System.Drawing.Point(268, 16);
			this.cboProxyAuthentication.Name = "cboProxyAuthentication";
			this.cboProxyAuthentication.Size = new System.Drawing.Size(63, 21);
			this.cboProxyAuthentication.TabIndex = 42;
			this.cboProxyAuthentication.SelectedIndexChanged += new System.EventHandler(this.cboProxyAuthentication_SelectedIndexChanged);
			// 
			// txtProxyPassword
			// 
			this.txtProxyPassword.Location = new System.Drawing.Point(268, 69);
			this.txtProxyPassword.Name = "txtProxyPassword";
			this.txtProxyPassword.Size = new System.Drawing.Size(93, 20);
			this.txtProxyPassword.TabIndex = 41;
			// 
			// lblProxyPassword
			// 
			this.lblProxyPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblProxyPassword.ForeColor = System.Drawing.Color.Black;
			this.lblProxyPassword.Location = new System.Drawing.Point(161, 72);
			this.lblProxyPassword.Name = "lblProxyPassword";
			this.lblProxyPassword.Size = new System.Drawing.Size(100, 20);
			this.lblProxyPassword.TabIndex = 40;
			this.lblProxyPassword.Text = "Password:";
			this.lblProxyPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtProxyLogin
			// 
			this.txtProxyLogin.Location = new System.Drawing.Point(268, 43);
			this.txtProxyLogin.Name = "txtProxyLogin";
			this.txtProxyLogin.Size = new System.Drawing.Size(93, 20);
			this.txtProxyLogin.TabIndex = 39;
			// 
			// lblProxyLogin
			// 
			this.lblProxyLogin.BackColor = System.Drawing.Color.Transparent;
			this.lblProxyLogin.ForeColor = System.Drawing.Color.Black;
			this.lblProxyLogin.Location = new System.Drawing.Point(161, 46);
			this.lblProxyLogin.Name = "lblProxyLogin";
			this.lblProxyLogin.Size = new System.Drawing.Size(100, 20);
			this.lblProxyLogin.TabIndex = 38;
			this.lblProxyLogin.Text = "Login:";
			this.lblProxyLogin.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblProxyType
			// 
			this.lblProxyType.BackColor = System.Drawing.Color.Transparent;
			this.lblProxyType.ForeColor = System.Drawing.Color.Black;
			this.lblProxyType.Location = new System.Drawing.Point(11, 20);
			this.lblProxyType.Name = "lblProxyType";
			this.lblProxyType.Size = new System.Drawing.Size(45, 20);
			this.lblProxyType.TabIndex = 37;
			this.lblProxyType.Text = "Type:";
			this.lblProxyType.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cboProxyMode
			// 
			this.cboProxyMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboProxyMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cboProxyMode.FormattingEnabled = true;
			this.cboProxyMode.Items.AddRange(new object[] {
            "None",
            "Detect",
            "Http",
            "Socks"});
			this.cboProxyMode.Location = new System.Drawing.Point(60, 16);
			this.cboProxyMode.Name = "cboProxyMode";
			this.cboProxyMode.Size = new System.Drawing.Size(63, 21);
			this.cboProxyMode.TabIndex = 36;
			this.cboProxyMode.SelectedIndexChanged += new System.EventHandler(this.cboProxyMode_SelectedIndexChanged);
			// 
			// txtProxyPort
			// 
			this.txtProxyPort.Location = new System.Drawing.Point(60, 69);
			this.txtProxyPort.Name = "txtProxyPort";
			this.txtProxyPort.Size = new System.Drawing.Size(38, 20);
			this.txtProxyPort.TabIndex = 35;
			// 
			// lblProxyPort
			// 
			this.lblProxyPort.BackColor = System.Drawing.Color.Transparent;
			this.lblProxyPort.ForeColor = System.Drawing.Color.Black;
			this.lblProxyPort.Location = new System.Drawing.Point(11, 72);
			this.lblProxyPort.Name = "lblProxyPort";
			this.lblProxyPort.Size = new System.Drawing.Size(45, 20);
			this.lblProxyPort.TabIndex = 34;
			this.lblProxyPort.Text = "Port:";
			this.lblProxyPort.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtProxyHost
			// 
			this.txtProxyHost.Location = new System.Drawing.Point(60, 43);
			this.txtProxyHost.Name = "txtProxyHost";
			this.txtProxyHost.Size = new System.Drawing.Size(93, 20);
			this.txtProxyHost.TabIndex = 33;
			// 
			// lblProxyHost
			// 
			this.lblProxyHost.BackColor = System.Drawing.Color.Transparent;
			this.lblProxyHost.ForeColor = System.Drawing.Color.Black;
			this.lblProxyHost.Location = new System.Drawing.Point(11, 46);
			this.lblProxyHost.Name = "lblProxyHost";
			this.lblProxyHost.Size = new System.Drawing.Size(45, 20);
			this.lblProxyHost.TabIndex = 32;
			this.lblProxyHost.Text = "Host:";
			this.lblProxyHost.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tabRoutes
			// 
			this.tabRoutes.BackColor = System.Drawing.Color.White;
			this.tabRoutes.Controls.Add(this.cmdRouteEdit);
			this.tabRoutes.Controls.Add(this.cmdRouteRemove);
			this.tabRoutes.Controls.Add(this.cmdRouteAdd);
			this.tabRoutes.Controls.Add(this.label6);
			this.tabRoutes.Controls.Add(this.cboRoutesOtherwise);
			this.tabRoutes.Controls.Add(this.lblRoutesOtherwise);
			this.tabRoutes.Controls.Add(this.lstRoutes);
			this.tabRoutes.Location = new System.Drawing.Point(4, 24);
			this.tabRoutes.Name = "tabRoutes";
			this.tabRoutes.Size = new System.Drawing.Size(630, 291);
			this.tabRoutes.TabIndex = 5;
			this.tabRoutes.Text = "Routes";
			// 
			// cmdRouteEdit
			// 
			this.cmdRouteEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdRouteEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdRouteEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdRouteEdit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdRouteEdit.FlatAppearance.BorderSize = 0;
			this.cmdRouteEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdRouteEdit.Image = global::AirVPN.Lib.Forms.Properties.Resources.edit_16;
			this.cmdRouteEdit.Location = new System.Drawing.Point(589, 99);
			this.cmdRouteEdit.Name = "cmdRouteEdit";
			this.cmdRouteEdit.Size = new System.Drawing.Size(30, 30);
			this.cmdRouteEdit.TabIndex = 41;
			this.cmdRouteEdit.UseVisualStyleBackColor = true;
			this.cmdRouteEdit.Click += new System.EventHandler(this.cmdRouteEdit_Click);
			// 
			// cmdRouteRemove
			// 
			this.cmdRouteRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdRouteRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdRouteRemove.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdRouteRemove.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdRouteRemove.FlatAppearance.BorderSize = 0;
			this.cmdRouteRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdRouteRemove.Image = global::AirVPN.Lib.Forms.Properties.Resources.delete_16;
			this.cmdRouteRemove.Location = new System.Drawing.Point(589, 65);
			this.cmdRouteRemove.Name = "cmdRouteRemove";
			this.cmdRouteRemove.Size = new System.Drawing.Size(30, 30);
			this.cmdRouteRemove.TabIndex = 40;
			this.cmdRouteRemove.UseVisualStyleBackColor = true;
			this.cmdRouteRemove.Click += new System.EventHandler(this.cmdRouteRemove_Click);
			// 
			// cmdRouteAdd
			// 
			this.cmdRouteAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdRouteAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdRouteAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdRouteAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.cmdRouteAdd.FlatAppearance.BorderSize = 0;
			this.cmdRouteAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdRouteAdd.Image = global::AirVPN.Lib.Forms.Properties.Resources.add_16;
			this.cmdRouteAdd.Location = new System.Drawing.Point(589, 31);
			this.cmdRouteAdd.Name = "cmdRouteAdd";
			this.cmdRouteAdd.Size = new System.Drawing.Size(30, 30);
			this.cmdRouteAdd.TabIndex = 39;
			this.cmdRouteAdd.UseVisualStyleBackColor = true;
			this.cmdRouteAdd.Click += new System.EventHandler(this.cmdRouteAdd_Click);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(4, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(615, 18);
			this.label6.TabIndex = 3;
			this.label6.Text = "Network routing rules about what destination must be in the VPN tunnel or not.";
			// 
			// cboRoutesOtherwise
			// 
			this.cboRoutesOtherwise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cboRoutesOtherwise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboRoutesOtherwise.FormattingEnabled = true;
			this.cboRoutesOtherwise.Location = new System.Drawing.Point(429, 260);
			this.cboRoutesOtherwise.Name = "cboRoutesOtherwise";
			this.cboRoutesOtherwise.Size = new System.Drawing.Size(154, 21);
			this.cboRoutesOtherwise.TabIndex = 2;
			// 
			// lblRoutesOtherwise
			// 
			this.lblRoutesOtherwise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRoutesOtherwise.BackColor = System.Drawing.Color.Transparent;
			this.lblRoutesOtherwise.ForeColor = System.Drawing.Color.Black;
			this.lblRoutesOtherwise.Location = new System.Drawing.Point(264, 263);
			this.lblRoutesOtherwise.Name = "lblRoutesOtherwise";
			this.lblRoutesOtherwise.Size = new System.Drawing.Size(162, 15);
			this.lblRoutesOtherwise.TabIndex = 1;
			this.lblRoutesOtherwise.Text = "Not specified routes go: ";
			this.lblRoutesOtherwise.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lstRoutes
			// 
			this.lstRoutes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstRoutes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRoutesIp,
            this.colRoutesMask,
            this.colRoutesAction});
			this.lstRoutes.ContextMenuStrip = this.mnuRoutes;
			this.lstRoutes.FullRowSelect = true;
			this.lstRoutes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstRoutes.HideSelection = false;
			this.lstRoutes.Location = new System.Drawing.Point(6, 31);
			this.lstRoutes.MultiSelect = false;
			this.lstRoutes.Name = "lstRoutes";
			this.lstRoutes.OwnerDraw = true;
			this.lstRoutes.Size = new System.Drawing.Size(577, 223);
			this.lstRoutes.SmallImageList = this.imgRoutes;
			this.lstRoutes.TabIndex = 0;
			this.lstRoutes.UseCompatibleStateImageBehavior = false;
			this.lstRoutes.View = System.Windows.Forms.View.Details;
			this.lstRoutes.SelectedIndexChanged += new System.EventHandler(this.lstRoutes_SelectedIndexChanged);
			this.lstRoutes.DoubleClick += new System.EventHandler(this.lstRoutes_DoubleClick);
			// 
			// colRoutesIp
			// 
			this.colRoutesIp.Text = "IP / Host";
			this.colRoutesIp.Width = 100;
			// 
			// colRoutesMask
			// 
			this.colRoutesMask.Text = "Net Mask";
			this.colRoutesMask.Width = 100;
			// 
			// colRoutesAction
			// 
			this.colRoutesAction.Text = "Action";
			this.colRoutesAction.Width = 200;
			// 
			// tabAdvanced
			// 
			this.tabAdvanced.BackColor = System.Drawing.Color.White;
			this.tabAdvanced.Controls.Add(this.tabAdvancedMain);
			this.tabAdvanced.Location = new System.Drawing.Point(4, 24);
			this.tabAdvanced.Name = "tabAdvanced";
			this.tabAdvanced.Size = new System.Drawing.Size(630, 291);
			this.tabAdvanced.TabIndex = 2;
			this.tabAdvanced.Text = "Advanced";
			// 
			// tabAdvancedMain
			// 
			this.tabAdvancedMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabAdvancedMain.Controls.Add(tabPage1);
			this.tabAdvancedMain.Controls.Add(this.tabPage4);
			this.tabAdvancedMain.Controls.Add(tabPage2);
			this.tabAdvancedMain.Controls.Add(tabPage3);
			this.tabAdvancedMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabAdvancedMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabAdvancedMain.ItemSize = new System.Drawing.Size(150, 20);
			this.tabAdvancedMain.Location = new System.Drawing.Point(0, 0);
			this.tabAdvancedMain.Name = "tabAdvancedMain";
			this.tabAdvancedMain.SelectedIndex = 0;
			this.tabAdvancedMain.Size = new System.Drawing.Size(630, 291);
			this.tabAdvancedMain.TabIndex = 56;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.TxtLoggingPathComputed);
			this.tabPage4.Controls.Add(this.lblLoggingHelp);
			this.tabPage4.Controls.Add(this.TxtLoggingPath);
			this.tabPage4.Controls.Add(this.label8);
			this.tabPage4.Controls.Add(this.chkLoggingEnabled);
			this.tabPage4.Location = new System.Drawing.Point(4, 24);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(622, 263);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Logging";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// TxtLoggingPathComputed
			// 
			this.TxtLoggingPathComputed.BackColor = System.Drawing.Color.Transparent;
			this.TxtLoggingPathComputed.ForeColor = System.Drawing.Color.Black;
			this.TxtLoggingPathComputed.Location = new System.Drawing.Point(70, 83);
			this.TxtLoggingPathComputed.Name = "TxtLoggingPathComputed";
			this.TxtLoggingPathComputed.Size = new System.Drawing.Size(548, 98);
			this.TxtLoggingPathComputed.TabIndex = 62;
			this.TxtLoggingPathComputed.Text = "Current Computed Path";
			this.TxtLoggingPathComputed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblLoggingHelp
			// 
			this.lblLoggingHelp.BackColor = System.Drawing.Color.Transparent;
			this.lblLoggingHelp.ForeColor = System.Drawing.Color.Black;
			this.lblLoggingHelp.Location = new System.Drawing.Point(13, 181);
			this.lblLoggingHelp.Name = "lblLoggingHelp";
			this.lblLoggingHelp.Size = new System.Drawing.Size(596, 67);
			this.lblLoggingHelp.TabIndex = 61;
			this.lblLoggingHelp.Text = resources.GetString("lblLoggingHelp.Text");
			this.lblLoggingHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// TxtLoggingPath
			// 
			this.TxtLoggingPath.Location = new System.Drawing.Point(70, 60);
			this.TxtLoggingPath.Name = "TxtLoggingPath";
			this.TxtLoggingPath.Size = new System.Drawing.Size(539, 20);
			this.TxtLoggingPath.TabIndex = 61;
			this.TxtLoggingPath.TextChanged += new System.EventHandler(this.TxtLoggingPath_TextChanged);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(13, 63);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 18);
			this.label8.TabIndex = 60;
			this.label8.Text = "Path:";
			// 
			// chkLoggingEnabled
			// 
			this.chkLoggingEnabled.AutoSize = true;
			this.chkLoggingEnabled.BackColor = System.Drawing.Color.Transparent;
			this.chkLoggingEnabled.ForeColor = System.Drawing.Color.Black;
			this.chkLoggingEnabled.Location = new System.Drawing.Point(16, 20);
			this.chkLoggingEnabled.Name = "chkLoggingEnabled";
			this.chkLoggingEnabled.Size = new System.Drawing.Size(136, 17);
			this.chkLoggingEnabled.TabIndex = 55;
			this.chkLoggingEnabled.Text = "Logging on file enabled";
			this.chkLoggingEnabled.UseVisualStyleBackColor = false;
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 366);
			this.Controls.Add(this.pnlCommands);
			this.Controls.Add(this.tabSettings);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(650, 400);
			this.Name = "Settings";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			this.pnlAdvancedGeneralWindowsOnly.ResumeLayout(false);
			this.pnlAdvancedGeneralWindowsOnly.PerformLayout();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			tabPage3.ResumeLayout(false);
			this.mnuRoutes.ResumeLayout(false);
			this.pnlCommands.ResumeLayout(false);
			this.tabSettings.ResumeLayout(false);
			this.tabGeneral.ResumeLayout(false);
			this.tabGeneral.PerformLayout();
			this.pnlGeneralWindowsOnly.ResumeLayout(false);
			this.pnlGeneralWindowsOnly.PerformLayout();
			this.tabMode.ResumeLayout(false);
			this.tabMode.PerformLayout();
			this.tabProxy.ResumeLayout(false);
			this.tabProxy.PerformLayout();
			this.tabRoutes.ResumeLayout(false);
			this.tabAdvanced.ResumeLayout(false);
			this.tabAdvancedMain.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private Skin.ColumnHeader colLogDate;
        private Skin.ColumnHeader colLogMessage;
        private Skin.ToolTip myToolTip;
        private System.Windows.Forms.OpenFileDialog openExeDialog;
        private Skin.CheckBox chkSystemStart;
        private Skin.CheckBox chkAutoStart;
        private Skin.Label lblProxyType;
        private Skin.ComboBox cboProxyMode;
        private Skin.TextBox txtProxyPort;
        private Skin.Label lblProxyPort;
        private Skin.TextBox txtProxyHost;
        private Skin.Label lblProxyHost;
        private Skin.Label lblProxyAuthentication;
        private Skin.ComboBox cboProxyAuthentication;
        private Skin.TextBox txtProxyPassword;
        private Skin.Label lblProxyPassword;
        private Skin.TextBox txtProxyLogin;
		private Skin.Label lblProxyLogin;
        private Skin.Button cmdTos;
        private Skin.Label label6;
        private Skin.ComboBox cboRoutesOtherwise;
        private Skin.Label lblRoutesOtherwise;
        private Skin.ListView lstRoutes;
        private Skin.ColumnHeader colRoutesIp;
        private Skin.ColumnHeader colRoutesMask;
        private Skin.ColumnHeader colRoutesAction;
        private System.Windows.Forms.ImageList imgRoutes;
        private Skin.CheckBox chkMinimizeTray;
        private Skin.LinkLabel lnkModeMore;
        private Skin.RadioButton optModeSSH53;
        private Skin.RadioButton optModeSSH80;
        private Skin.RadioButton optModeSSH22Alt;
        private Skin.RadioButton optModeSSH22;
        private Skin.RadioButton optModeSSL443;
        private Skin.Label lblModeSSH;
        private Skin.Label lblModeSSL;
        private Skin.RadioButton optModeTCP2018Alt;
        private Skin.RadioButton optModeUDP2018Alt;
        private Skin.RadioButton optModeUDP53Alt;
        private Skin.RadioButton optModeUDP80Alt;
        private Skin.RadioButton optModeUDP443Alt;
        private Skin.Label label5;
        private Skin.RadioButton optModeTCP443;
        private Skin.RadioButton optModeUDP443;
        private Skin.RadioButton optModeTCP2018;
        private Skin.RadioButton optModeUDP2018;
        private Skin.RadioButton optModeTCP53;
        private Skin.RadioButton optModeUDP53;
        private Skin.RadioButton optModeTCP80;
        private Skin.RadioButton optModeUDP80;
        private Skin.Label label11;
        private Skin.Label label12;
        private Skin.Button cmdRouteEdit;
        private Skin.Button cmdRouteRemove;
        private Skin.Button cmdRouteAdd;
        private Skin.Panel pnlCommands;
        private Skin.Button cmdCancel;
        private Skin.Button cmdOk;
        private System.Windows.Forms.ContextMenuStrip mnuRoutes;
        private System.Windows.Forms.ToolStripMenuItem mnuRoutesAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuRoutesRemove;
		private System.Windows.Forms.ToolStripMenuItem mnuRoutesEdit;
        private Skin.CheckBox chkGeneralStartLast;
        private Skin.TabControl tabSettings;
        private Skin.TabPage tabGeneral;
        private Skin.TabPage tabMode;
        private Skin.TabPage tabProxy;
        private Skin.TabPage tabAdvanced;
        private Skin.TabPage tabRoutes;
        private Skin.TabControl tabAdvancedMain;
        private Skin.CheckBox chkAdvancedWindowsForceDns;
        private Skin.Button cmdExeBrowse;
        private Skin.TextBox txtExePath;
        private Skin.Label label4;
        private Skin.CheckBox chkAdvancedCheckRoute;
        private Skin.CheckBox chkAdvancedCheckDns;
        private Skin.CheckBox chkAdvancedWindowsTapUp;
        private Skin.CheckBox chkExpert;
        private Skin.CheckBox chkAdvancedOpenVpnDirectivesDefaultSkip;
        private Skin.TextBox txtAdvancedOpenVpnDirectivesDefault;
        private Skin.TextBox txtAdvancedOpenVpnDirectivesCustom;
        private Skin.Button cmdAdvancedEventsEdit;
        private Skin.Button cmdAdvancedEventsClear;
        private Skin.ListView lstAdvancedEvents;
        private Skin.Label label1;
        private Skin.Label label3;
        private Skin.Label label2;
        private Skin.ColumnHeader columnHeader3;
        private Skin.ColumnHeader columnHeader4;
        private Skin.Label lblGeneralTheme;
		private Skin.ComboBox cboGeneralTheme;
		private Skin.CheckBox chkAdvancedWindowsDhcpSwitch;
		private Skin.Button cmdAdvancedUninstallDriver;
		private Skin.CheckBox chkAdvancedPingerAlways;
		private Skin.CheckBox chkAdvancedPingerEnabled;
		private Skin.LinkLabel lnkAdvancedDocs;
		private System.Windows.Forms.GroupBox pnlGeneralWindowsOnly;
		private System.Windows.Forms.GroupBox pnlAdvancedGeneralWindowsOnly;
		private Skin.ComboBox cboDnsSwitchMode;
		private Skin.Label label7;
		private Skin.CheckBox chkAdvancedNetworkLocking;
		private Skin.TabPage tabPage4;
		private Skin.Label TxtLoggingPathComputed;
		private Skin.Label lblLoggingHelp;
		private Skin.TextBox TxtLoggingPath;
		private Skin.Label label8;
		private Skin.CheckBox chkLoggingEnabled;

    }
}