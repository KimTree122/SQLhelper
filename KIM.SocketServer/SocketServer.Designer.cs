namespace KIM.SocketServer
{
    partial class SocketServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocketServer));
            this.dockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            this.dockContainerItem2 = new DevComponents.DotNetBar.DockContainerItem();
            this.dNBM = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSite4 = new DevComponents.DotNetBar.DockSite();
            this.dockSite1 = new DevComponents.DotNetBar.DockSite();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.panelDockContainer2 = new DevComponents.DotNetBar.PanelDockContainer();
            this.lv_connhis = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.panelDockContainer1 = new DevComponents.DotNetBar.PanelDockContainer();
            this.lv_client = new System.Windows.Forms.ListView();
            this.NO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel_conn = new DevComponents.DotNetBar.PanelEx();
            this.tbtn_end = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbtn_start = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.ClientConn = new DevComponents.DotNetBar.DockContainerItem();
            this.ConnHis = new DevComponents.DotNetBar.DockContainerItem();
            this.dockSite2 = new DevComponents.DotNetBar.DockSite();
            this.dockSite8 = new DevComponents.DotNetBar.DockSite();
            this.dockSite5 = new DevComponents.DotNetBar.DockSite();
            this.dockSite6 = new DevComponents.DotNetBar.DockSite();
            this.dockSite7 = new DevComponents.DotNetBar.DockSite();
            this.dockSite3 = new DevComponents.DotNetBar.DockSite();
            this.gp_send = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rtxb_send = new System.Windows.Forms.RichTextBox();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.mbtn_clean = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.lbl_client = new System.Windows.Forms.Label();
            this.tbtn_send = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.tbtn_allsend = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.rtb_dataswich = new System.Windows.Forms.RichTextBox();
            this.dockSite1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            this.panelDockContainer2.SuspendLayout();
            this.panelDockContainer1.SuspendLayout();
            this.panel_conn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.gp_send.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockContainerItem1
            // 
            this.dockContainerItem1.Name = "dockContainerItem1";
            this.dockContainerItem1.Text = "dockContainerItem1";
            // 
            // dockContainerItem2
            // 
            this.dockContainerItem2.Name = "dockContainerItem2";
            this.dockContainerItem2.Text = "dockContainerItem2";
            // 
            // dNBM
            // 
            this.dNBM.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.dNBM.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.dNBM.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.dNBM.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.dNBM.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.dNBM.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.dNBM.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.dNBM.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.dNBM.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.dNBM.BottomDockSite = this.dockSite4;
            this.dNBM.EnableFullSizeDock = false;
            this.dNBM.LeftDockSite = this.dockSite1;
            this.dNBM.ParentForm = this;
            this.dNBM.RightDockSite = this.dockSite2;
            this.dNBM.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.dNBM.ToolbarBottomDockSite = this.dockSite8;
            this.dNBM.ToolbarLeftDockSite = this.dockSite5;
            this.dNBM.ToolbarRightDockSite = this.dockSite6;
            this.dNBM.ToolbarTopDockSite = this.dockSite7;
            this.dNBM.TopDockSite = this.dockSite3;
            // 
            // dockSite4
            // 
            this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite4.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite4.Location = new System.Drawing.Point(27, 647);
            this.dockSite4.Margin = new System.Windows.Forms.Padding(4);
            this.dockSite4.Name = "dockSite4";
            this.dockSite4.Size = new System.Drawing.Size(767, 0);
            this.dockSite4.TabIndex = 23;
            this.dockSite4.TabStop = false;
            // 
            // dockSite1
            // 
            this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite1.Controls.Add(this.bar1);
            this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.bar1, 286, 567)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.dockSite1.Location = new System.Drawing.Point(27, 80);
            this.dockSite1.Margin = new System.Windows.Forms.Padding(4);
            this.dockSite1.Name = "dockSite1";
            this.dockSite1.Size = new System.Drawing.Size(289, 567);
            this.dockSite1.TabIndex = 20;
            this.dockSite1.TabStop = false;
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.bar1.AutoSyncBarCaption = true;
            this.bar1.CloseSingleTab = true;
            this.bar1.Controls.Add(this.panelDockContainer1);
            this.bar1.Controls.Add(this.panelDockContainer2);
            this.bar1.Font = new System.Drawing.Font("宋体", 12F);
            this.bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ClientConn,
            this.ConnHis});
            this.bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Margin = new System.Windows.Forms.Padding(4);
            this.bar1.Name = "bar1";
            this.bar1.SelectedDockTab = 0;
            this.bar1.Size = new System.Drawing.Size(286, 567);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "客户连接";
            // 
            // panelDockContainer2
            // 
            this.panelDockContainer2.Controls.Add(this.lv_connhis);
            this.panelDockContainer2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelDockContainer2.Location = new System.Drawing.Point(3, 24);
            this.panelDockContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.panelDockContainer2.Name = "panelDockContainer2";
            this.panelDockContainer2.Size = new System.Drawing.Size(280, 515);
            this.panelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer2.Style.GradientAngle = 90;
            this.panelDockContainer2.TabIndex = 5;
            // 
            // lv_connhis
            // 
            // 
            // 
            // 
            this.lv_connhis.Border.Class = "ListViewBorder";
            this.lv_connhis.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lv_connhis.DisabledBackColor = System.Drawing.Color.Empty;
            this.lv_connhis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_connhis.Location = new System.Drawing.Point(0, 0);
            this.lv_connhis.Margin = new System.Windows.Forms.Padding(4);
            this.lv_connhis.Name = "lv_connhis";
            this.lv_connhis.Size = new System.Drawing.Size(280, 515);
            this.lv_connhis.TabIndex = 5;
            this.lv_connhis.UseCompatibleStateImageBehavior = false;
            // 
            // panelDockContainer1
            // 
            this.panelDockContainer1.Controls.Add(this.lv_client);
            this.panelDockContainer1.Controls.Add(this.panel_conn);
            this.panelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelDockContainer1.Location = new System.Drawing.Point(3, 24);
            this.panelDockContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.panelDockContainer1.Name = "panelDockContainer1";
            this.panelDockContainer1.Size = new System.Drawing.Size(280, 515);
            this.panelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer1.Style.GradientAngle = 90;
            this.panelDockContainer1.TabIndex = 0;
            // 
            // lv_client
            // 
            this.lv_client.CheckBoxes = true;
            this.lv_client.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NO,
            this.IP,
            this.Port});
            this.lv_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_client.FullRowSelect = true;
            this.lv_client.Location = new System.Drawing.Point(0, 126);
            this.lv_client.Name = "lv_client";
            this.lv_client.Size = new System.Drawing.Size(280, 389);
            this.lv_client.SmallImageList = this.imageList;
            this.lv_client.TabIndex = 8;
            this.lv_client.UseCompatibleStateImageBehavior = false;
            this.lv_client.View = System.Windows.Forms.View.Details;
            // 
            // NO
            // 
            this.NO.Text = "NO";
            this.NO.Width = 70;
            // 
            // IP
            // 
            this.IP.Text = "IP";
            this.IP.Width = 151;
            // 
            // Port
            // 
            this.Port.Text = "Port";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "user_female.png");
            this.imageList.Images.SetKeyName(1, "user_male.png");
            // 
            // panel_conn
            // 
            this.panel_conn.CanvasColor = System.Drawing.SystemColors.Control;
            this.panel_conn.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panel_conn.Controls.Add(this.tbtn_end);
            this.panel_conn.Controls.Add(this.nud);
            this.panel_conn.Controls.Add(this.label1);
            this.panel_conn.Controls.Add(this.tbtn_start);
            this.panel_conn.DisabledBackColor = System.Drawing.Color.Empty;
            this.panel_conn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_conn.Location = new System.Drawing.Point(0, 0);
            this.panel_conn.Margin = new System.Windows.Forms.Padding(4);
            this.panel_conn.Name = "panel_conn";
            this.panel_conn.Size = new System.Drawing.Size(280, 126);
            this.panel_conn.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_conn.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panel_conn.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panel_conn.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_conn.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panel_conn.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panel_conn.Style.GradientAngle = 90;
            this.panel_conn.TabIndex = 0;
            // 
            // tbtn_end
            // 
            this.tbtn_end.Image = null;
            this.tbtn_end.Location = new System.Drawing.Point(144, 60);
            this.tbtn_end.Margin = new System.Windows.Forms.Padding(4);
            this.tbtn_end.Name = "tbtn_end";
            this.tbtn_end.Size = new System.Drawing.Size(108, 44);
            this.tbtn_end.Style = MetroFramework.MetroColorStyle.Orange;
            this.tbtn_end.TabIndex = 3;
            this.tbtn_end.Text = "服务停止";
            this.tbtn_end.UseSelectable = true;
            this.tbtn_end.UseVisualStyleBackColor = true;
            this.tbtn_end.Click += new System.EventHandler(this.tbtn_end_Click);
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(88, 15);
            this.nud.Maximum = new decimal(new int[] {
            90000,
            0,
            0,
            0});
            this.nud.Minimum = new decimal(new int[] {
            60001,
            0,
            0,
            0});
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(164, 26);
            this.nud.TabIndex = 2;
            this.nud.Value = new decimal(new int[] {
            60001,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口：";
            // 
            // tbtn_start
            // 
            this.tbtn_start.Image = null;
            this.tbtn_start.Location = new System.Drawing.Point(28, 60);
            this.tbtn_start.Margin = new System.Windows.Forms.Padding(4);
            this.tbtn_start.Name = "tbtn_start";
            this.tbtn_start.Size = new System.Drawing.Size(108, 44);
            this.tbtn_start.TabIndex = 0;
            this.tbtn_start.Text = "服务启动";
            this.tbtn_start.UseSelectable = true;
            this.tbtn_start.UseVisualStyleBackColor = true;
            this.tbtn_start.Click += new System.EventHandler(this.tbtn_start_Click);
            // 
            // ClientConn
            // 
            this.ClientConn.Control = this.panelDockContainer1;
            this.ClientConn.Name = "ClientConn";
            this.ClientConn.Text = "客户连接";
            // 
            // ConnHis
            // 
            this.ConnHis.Control = this.panelDockContainer2;
            this.ConnHis.Name = "ConnHis";
            this.ConnHis.Text = "连接历史";
            // 
            // dockSite2
            // 
            this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite2.Location = new System.Drawing.Point(794, 80);
            this.dockSite2.Margin = new System.Windows.Forms.Padding(4);
            this.dockSite2.Name = "dockSite2";
            this.dockSite2.Size = new System.Drawing.Size(0, 567);
            this.dockSite2.TabIndex = 21;
            this.dockSite2.TabStop = false;
            // 
            // dockSite8
            // 
            this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite8.Location = new System.Drawing.Point(27, 647);
            this.dockSite8.Margin = new System.Windows.Forms.Padding(4);
            this.dockSite8.Name = "dockSite8";
            this.dockSite8.Size = new System.Drawing.Size(767, 0);
            this.dockSite8.TabIndex = 27;
            this.dockSite8.TabStop = false;
            // 
            // dockSite5
            // 
            this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite5.Location = new System.Drawing.Point(27, 80);
            this.dockSite5.Margin = new System.Windows.Forms.Padding(4);
            this.dockSite5.Name = "dockSite5";
            this.dockSite5.Size = new System.Drawing.Size(0, 567);
            this.dockSite5.TabIndex = 24;
            this.dockSite5.TabStop = false;
            // 
            // dockSite6
            // 
            this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite6.Location = new System.Drawing.Point(794, 80);
            this.dockSite6.Margin = new System.Windows.Forms.Padding(4);
            this.dockSite6.Name = "dockSite6";
            this.dockSite6.Size = new System.Drawing.Size(0, 567);
            this.dockSite6.TabIndex = 25;
            this.dockSite6.TabStop = false;
            // 
            // dockSite7
            // 
            this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite7.Location = new System.Drawing.Point(27, 80);
            this.dockSite7.Margin = new System.Windows.Forms.Padding(4);
            this.dockSite7.Name = "dockSite7";
            this.dockSite7.Size = new System.Drawing.Size(767, 0);
            this.dockSite7.TabIndex = 26;
            this.dockSite7.TabStop = false;
            // 
            // dockSite3
            // 
            this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite3.Location = new System.Drawing.Point(27, 80);
            this.dockSite3.Margin = new System.Windows.Forms.Padding(4);
            this.dockSite3.Name = "dockSite3";
            this.dockSite3.Size = new System.Drawing.Size(767, 0);
            this.dockSite3.TabIndex = 22;
            this.dockSite3.TabStop = false;
            // 
            // gp_send
            // 
            this.gp_send.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp_send.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp_send.Controls.Add(this.rtxb_send);
            this.gp_send.Controls.Add(this.panelEx1);
            this.gp_send.DisabledBackColor = System.Drawing.Color.Empty;
            this.gp_send.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gp_send.Location = new System.Drawing.Point(316, 412);
            this.gp_send.Name = "gp_send";
            this.gp_send.Size = new System.Drawing.Size(478, 235);
            // 
            // 
            // 
            this.gp_send.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_send.Style.BackColorGradientAngle = 90;
            this.gp_send.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_send.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_send.Style.BorderBottomWidth = 1;
            this.gp_send.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_send.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_send.Style.BorderLeftWidth = 1;
            this.gp_send.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_send.Style.BorderRightWidth = 1;
            this.gp_send.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_send.Style.BorderTopWidth = 1;
            this.gp_send.Style.CornerDiameter = 4;
            this.gp_send.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_send.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp_send.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_send.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp_send.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp_send.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp_send.TabIndex = 29;
            this.gp_send.Text = "消息发送";
            // 
            // rtxb_send
            // 
            this.rtxb_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxb_send.Location = new System.Drawing.Point(0, 0);
            this.rtxb_send.Name = "rtxb_send";
            this.rtxb_send.Size = new System.Drawing.Size(472, 98);
            this.rtxb_send.TabIndex = 31;
            this.rtxb_send.Text = "";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.mbtn_clean);
            this.panelEx1.Controls.Add(this.lbl_client);
            this.panelEx1.Controls.Add(this.tbtn_send);
            this.panelEx1.Controls.Add(this.tbtn_allsend);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 98);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(472, 108);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // mbtn_clean
            // 
            this.mbtn_clean.Image = null;
            this.mbtn_clean.Location = new System.Drawing.Point(335, 52);
            this.mbtn_clean.Margin = new System.Windows.Forms.Padding(4);
            this.mbtn_clean.Name = "mbtn_clean";
            this.mbtn_clean.Size = new System.Drawing.Size(108, 44);
            this.mbtn_clean.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mbtn_clean.TabIndex = 7;
            this.mbtn_clean.Text = "清空";
            this.mbtn_clean.UseSelectable = true;
            this.mbtn_clean.UseVisualStyleBackColor = true;
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Location = new System.Drawing.Point(18, 19);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(56, 16);
            this.lbl_client.TabIndex = 6;
            this.lbl_client.Text = "未选中";
            // 
            // tbtn_send
            // 
            this.tbtn_send.Image = null;
            this.tbtn_send.Location = new System.Drawing.Point(21, 52);
            this.tbtn_send.Margin = new System.Windows.Forms.Padding(4);
            this.tbtn_send.Name = "tbtn_send";
            this.tbtn_send.Size = new System.Drawing.Size(108, 44);
            this.tbtn_send.Style = MetroFramework.MetroColorStyle.Green;
            this.tbtn_send.TabIndex = 5;
            this.tbtn_send.Text = "发送";
            this.tbtn_send.UseSelectable = true;
            this.tbtn_send.UseVisualStyleBackColor = true;
            this.tbtn_send.Click += new System.EventHandler(this.tbtn_send_Click);
            // 
            // tbtn_allsend
            // 
            this.tbtn_allsend.Image = null;
            this.tbtn_allsend.Location = new System.Drawing.Point(178, 52);
            this.tbtn_allsend.Margin = new System.Windows.Forms.Padding(4);
            this.tbtn_allsend.Name = "tbtn_allsend";
            this.tbtn_allsend.Size = new System.Drawing.Size(108, 44);
            this.tbtn_allsend.Style = MetroFramework.MetroColorStyle.Orange;
            this.tbtn_allsend.TabIndex = 4;
            this.tbtn_allsend.Text = "群发";
            this.tbtn_allsend.UseSelectable = true;
            this.tbtn_allsend.UseVisualStyleBackColor = true;
            // 
            // rtb_dataswich
            // 
            this.rtb_dataswich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_dataswich.Location = new System.Drawing.Point(316, 80);
            this.rtb_dataswich.Name = "rtb_dataswich";
            this.rtb_dataswich.Size = new System.Drawing.Size(478, 332);
            this.rtb_dataswich.TabIndex = 30;
            this.rtb_dataswich.Text = "";
            // 
            // SocketServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 674);
            this.Controls.Add(this.rtb_dataswich);
            this.Controls.Add(this.gp_send);
            this.Controls.Add(this.dockSite2);
            this.Controls.Add(this.dockSite1);
            this.Controls.Add(this.dockSite3);
            this.Controls.Add(this.dockSite4);
            this.Controls.Add(this.dockSite5);
            this.Controls.Add(this.dockSite6);
            this.Controls.Add(this.dockSite7);
            this.Controls.Add(this.dockSite8);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SocketServer";
            this.Padding = new System.Windows.Forms.Padding(27, 80, 27, 27);
            this.Text = "Server";
            this.Load += new System.EventHandler(this.SocketServer_Load);
            this.dockSite1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            this.panelDockContainer2.ResumeLayout(false);
            this.panelDockContainer1.ResumeLayout(false);
            this.panel_conn.ResumeLayout(false);
            this.panel_conn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.gp_send.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem2;
        private DevComponents.DotNetBar.DotNetBarManager dNBM;
        private DevComponents.DotNetBar.DockSite dockSite4;
        private DevComponents.DotNetBar.DockSite dockSite1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer2;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer1;
        private DevComponents.DotNetBar.DockContainerItem ClientConn;
        private DevComponents.DotNetBar.DockContainerItem ConnHis;
        private DevComponents.DotNetBar.DockSite dockSite2;
        private DevComponents.DotNetBar.DockSite dockSite3;
        private DevComponents.DotNetBar.DockSite dockSite5;
        private DevComponents.DotNetBar.DockSite dockSite6;
        private DevComponents.DotNetBar.DockSite dockSite7;
        private DevComponents.DotNetBar.DockSite dockSite8;
        private DevComponents.DotNetBar.PanelEx panel_conn;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton tbtn_end;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton tbtn_start;
        private DevComponents.DotNetBar.Controls.ListViewEx lv_connhis;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_send;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton tbtn_send;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton tbtn_allsend;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView lv_client;
        private System.Windows.Forms.ColumnHeader NO;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader Port;
        private System.Windows.Forms.RichTextBox rtb_dataswich;
        private System.Windows.Forms.RichTextBox rtxb_send;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtn_clean;




    }
}

