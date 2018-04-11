namespace KIM.SocketClient
{
    partial class SocketClient
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
            this.dockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            this.panel_conn = new DevComponents.DotNetBar.PanelEx();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_ip = new MetroFramework.Controls.MetroTextBox();
            this.tbtn_disconn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbtn_conn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.rtb_recive = new System.Windows.Forms.RichTextBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.mbtn_sendmsg = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.rtb_send = new System.Windows.Forms.RichTextBox();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.lbl_path = new System.Windows.Forms.LinkLabel();
            this.mbtn_filesend = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.txb_filepath = new MetroFramework.Controls.MetroTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.panel_conn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockContainerItem1
            // 
            this.dockContainerItem1.Name = "dockContainerItem1";
            this.dockContainerItem1.Text = "dockContainerItem1";
            // 
            // panel_conn
            // 
            this.panel_conn.CanvasColor = System.Drawing.SystemColors.Control;
            this.panel_conn.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panel_conn.Controls.Add(this.label2);
            this.panel_conn.Controls.Add(this.txb_ip);
            this.panel_conn.Controls.Add(this.tbtn_disconn);
            this.panel_conn.Controls.Add(this.nud);
            this.panel_conn.Controls.Add(this.label1);
            this.panel_conn.Controls.Add(this.tbtn_conn);
            this.panel_conn.DisabledBackColor = System.Drawing.Color.Empty;
            this.panel_conn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_conn.Location = new System.Drawing.Point(0, 0);
            this.panel_conn.Margin = new System.Windows.Forms.Padding(4);
            this.panel_conn.Name = "panel_conn";
            this.panel_conn.Size = new System.Drawing.Size(281, 126);
            this.panel_conn.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_conn.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panel_conn.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panel_conn.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_conn.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panel_conn.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panel_conn.Style.GradientAngle = 90;
            this.panel_conn.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "地址：";
            // 
            // txb_ip
            // 
            // 
            // 
            // 
            this.txb_ip.CustomButton.Image = null;
            this.txb_ip.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txb_ip.CustomButton.Name = "";
            this.txb_ip.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_ip.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_ip.CustomButton.TabIndex = 1;
            this.txb_ip.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_ip.CustomButton.UseSelectable = true;
            this.txb_ip.CustomButton.Visible = false;
            this.txb_ip.Lines = new string[0];
            this.txb_ip.Location = new System.Drawing.Point(88, 13);
            this.txb_ip.MaxLength = 32767;
            this.txb_ip.Name = "txb_ip";
            this.txb_ip.PasswordChar = '\0';
            this.txb_ip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_ip.SelectedText = "";
            this.txb_ip.SelectionLength = 0;
            this.txb_ip.SelectionStart = 0;
            this.txb_ip.Size = new System.Drawing.Size(164, 23);
            this.txb_ip.TabIndex = 4;
            this.txb_ip.UseSelectable = true;
            this.txb_ip.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_ip.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbtn_disconn
            // 
            this.tbtn_disconn.Image = null;
            this.tbtn_disconn.Location = new System.Drawing.Point(144, 85);
            this.tbtn_disconn.Margin = new System.Windows.Forms.Padding(4);
            this.tbtn_disconn.Name = "tbtn_disconn";
            this.tbtn_disconn.Size = new System.Drawing.Size(108, 30);
            this.tbtn_disconn.Style = MetroFramework.MetroColorStyle.Orange;
            this.tbtn_disconn.TabIndex = 3;
            this.tbtn_disconn.Text = "停止";
            this.tbtn_disconn.UseSelectable = true;
            this.tbtn_disconn.UseVisualStyleBackColor = true;
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(88, 47);
            this.nud.Maximum = new decimal(new int[] {
            90000,
            0,
            0,
            0});
            this.nud.Minimum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(164, 26);
            this.nud.TabIndex = 2;
            this.nud.Value = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口：";
            // 
            // tbtn_conn
            // 
            this.tbtn_conn.Image = null;
            this.tbtn_conn.Location = new System.Drawing.Point(28, 85);
            this.tbtn_conn.Margin = new System.Windows.Forms.Padding(4);
            this.tbtn_conn.Name = "tbtn_conn";
            this.tbtn_conn.Size = new System.Drawing.Size(108, 30);
            this.tbtn_conn.TabIndex = 0;
            this.tbtn_conn.Text = "连接";
            this.tbtn_conn.UseSelectable = true;
            this.tbtn_conn.UseVisualStyleBackColor = true;
            this.tbtn_conn.Click += new System.EventHandler(this.tbtn_conn_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.rtb_recive);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(308, 80);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(425, 353);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 8;
            // 
            // rtb_recive
            // 
            this.rtb_recive.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtb_recive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_recive.Location = new System.Drawing.Point(0, 0);
            this.rtb_recive.Name = "rtb_recive";
            this.rtb_recive.Size = new System.Drawing.Size(425, 188);
            this.rtb_recive.TabIndex = 1;
            this.rtb_recive.Text = "";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.mbtn_sendmsg);
            this.groupPanel1.Controls.Add(this.rtb_send);
            this.groupPanel1.Controls.Add(this.panelEx2);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel1.Location = new System.Drawing.Point(0, 188);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(425, 165);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "消息";
            // 
            // mbtn_sendmsg
            // 
            this.mbtn_sendmsg.Image = null;
            this.mbtn_sendmsg.Location = new System.Drawing.Point(329, 69);
            this.mbtn_sendmsg.Margin = new System.Windows.Forms.Padding(4);
            this.mbtn_sendmsg.Name = "mbtn_sendmsg";
            this.mbtn_sendmsg.Size = new System.Drawing.Size(78, 63);
            this.mbtn_sendmsg.Style = MetroFramework.MetroColorStyle.Green;
            this.mbtn_sendmsg.TabIndex = 12;
            this.mbtn_sendmsg.Text = "发送";
            this.mbtn_sendmsg.UseSelectable = true;
            this.mbtn_sendmsg.UseVisualStyleBackColor = true;
            this.mbtn_sendmsg.Click += new System.EventHandler(this.mbtn_sendmsg_Click);
            // 
            // rtb_send
            // 
            this.rtb_send.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtb_send.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtb_send.Location = new System.Drawing.Point(0, 62);
            this.rtb_send.Name = "rtb_send";
            this.rtb_send.Size = new System.Drawing.Size(322, 74);
            this.rtb_send.TabIndex = 11;
            this.rtb_send.Text = "";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.lbl_path);
            this.panelEx2.Controls.Add(this.mbtn_filesend);
            this.panelEx2.Controls.Add(this.txb_filepath);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(419, 62);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 7;
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(3, 23);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(88, 16);
            this.lbl_path.TabIndex = 7;
            this.lbl_path.TabStop = true;
            this.lbl_path.Text = "文件路径：";
            this.lbl_path.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_path_LinkClicked);
            // 
            // mbtn_filesend
            // 
            this.mbtn_filesend.Image = null;
            this.mbtn_filesend.Location = new System.Drawing.Point(329, 16);
            this.mbtn_filesend.Margin = new System.Windows.Forms.Padding(4);
            this.mbtn_filesend.Name = "mbtn_filesend";
            this.mbtn_filesend.Size = new System.Drawing.Size(78, 30);
            this.mbtn_filesend.Style = MetroFramework.MetroColorStyle.Lime;
            this.mbtn_filesend.TabIndex = 6;
            this.mbtn_filesend.Text = "传输";
            this.mbtn_filesend.UseSelectable = true;
            this.mbtn_filesend.UseVisualStyleBackColor = true;
            this.mbtn_filesend.Click += new System.EventHandler(this.mbtn_filesend_Click);
            // 
            // txb_filepath
            // 
            // 
            // 
            // 
            this.txb_filepath.CustomButton.Image = null;
            this.txb_filepath.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txb_filepath.CustomButton.Name = "";
            this.txb_filepath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_filepath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_filepath.CustomButton.TabIndex = 1;
            this.txb_filepath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_filepath.CustomButton.UseSelectable = true;
            this.txb_filepath.CustomButton.Visible = false;
            this.txb_filepath.Lines = new string[0];
            this.txb_filepath.Location = new System.Drawing.Point(97, 20);
            this.txb_filepath.MaxLength = 32767;
            this.txb_filepath.Name = "txb_filepath";
            this.txb_filepath.PasswordChar = '\0';
            this.txb_filepath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_filepath.SelectedText = "";
            this.txb_filepath.SelectionLength = 0;
            this.txb_filepath.SelectionStart = 0;
            this.txb_filepath.Size = new System.Drawing.Size(225, 23);
            this.txb_filepath.TabIndex = 5;
            this.txb_filepath.UseSelectable = true;
            this.txb_filepath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_filepath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 126);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(281, 227);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.listView1);
            this.panelEx3.Controls.Add(this.panel_conn);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx3.Location = new System.Drawing.Point(27, 80);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(281, 353);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 12;
            // 
            // SocketClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 460);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.panelEx3);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SocketClient";
            this.Padding = new System.Windows.Forms.Padding(27, 80, 27, 27);
            this.Text = "Client";
            this.Load += new System.EventHandler(this.SocketClient_Load);
            this.panel_conn.ResumeLayout(false);
            this.panel_conn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.panelEx3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
        private DevComponents.DotNetBar.PanelEx panel_conn;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton tbtn_disconn;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton tbtn_conn;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txb_ip;
        private System.Windows.Forms.ListView listView1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.RichTextBox rtb_recive;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtn_sendmsg;
        private System.Windows.Forms.RichTextBox rtb_send;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.LinkLabel lbl_path;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtn_filesend;
        private MetroFramework.Controls.MetroTextBox txb_filepath;
        private DevComponents.DotNetBar.PanelEx panelEx3;
    }
}

