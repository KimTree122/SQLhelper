namespace KIM.SocketServer
{
    partial class AsynSocketForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_client = new System.Windows.Forms.ListView();
            this.NO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_conn = new DevComponents.DotNetBar.PanelEx();
            this.txb_ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtn_end = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbtn_start = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.rtb_dataswich = new System.Windows.Forms.RichTextBox();
            this.gp_send = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rtxb_send = new System.Windows.Forms.RichTextBox();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.mbtn_clean = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.lbl_client = new System.Windows.Forms.Label();
            this.tbtn_send = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.tbtn_allsend = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.groupBox1.SuspendLayout();
            this.panel_conn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.gp_send.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_client);
            this.groupBox1.Controls.Add(this.panel_conn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(288, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接列表";
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
            this.lv_client.Location = new System.Drawing.Point(4, 199);
            this.lv_client.Name = "lv_client";
            this.lv_client.Size = new System.Drawing.Size(280, 332);
            this.lv_client.TabIndex = 9;
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
            // panel_conn
            // 
            this.panel_conn.CanvasColor = System.Drawing.SystemColors.Control;
            this.panel_conn.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panel_conn.Controls.Add(this.txb_ip);
            this.panel_conn.Controls.Add(this.label2);
            this.panel_conn.Controls.Add(this.tbtn_end);
            this.panel_conn.Controls.Add(this.nud);
            this.panel_conn.Controls.Add(this.label1);
            this.panel_conn.Controls.Add(this.tbtn_start);
            this.panel_conn.DisabledBackColor = System.Drawing.Color.Empty;
            this.panel_conn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_conn.Location = new System.Drawing.Point(4, 23);
            this.panel_conn.Margin = new System.Windows.Forms.Padding(4);
            this.panel_conn.Name = "panel_conn";
            this.panel_conn.Size = new System.Drawing.Size(280, 176);
            this.panel_conn.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_conn.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panel_conn.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panel_conn.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_conn.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panel_conn.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panel_conn.Style.GradientAngle = 90;
            this.panel_conn.TabIndex = 4;
            // 
            // txb_ip
            // 
            this.txb_ip.Location = new System.Drawing.Point(88, 18);
            this.txb_ip.Name = "txb_ip";
            this.txb_ip.Size = new System.Drawing.Size(164, 26);
            this.txb_ip.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "地址:";
            // 
            // tbtn_end
            // 
            this.tbtn_end.Image = null;
            this.tbtn_end.Location = new System.Drawing.Point(144, 104);
            this.tbtn_end.Margin = new System.Windows.Forms.Padding(4);
            this.tbtn_end.Name = "tbtn_end";
            this.tbtn_end.Size = new System.Drawing.Size(108, 44);
            this.tbtn_end.Style = MetroFramework.MetroColorStyle.Orange;
            this.tbtn_end.TabIndex = 3;
            this.tbtn_end.Text = "服务停止";
            this.tbtn_end.UseSelectable = true;
            this.tbtn_end.UseVisualStyleBackColor = true;
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(88, 59);
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
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口：";
            // 
            // tbtn_start
            // 
            this.tbtn_start.Image = null;
            this.tbtn_start.Location = new System.Drawing.Point(28, 104);
            this.tbtn_start.Margin = new System.Windows.Forms.Padding(4);
            this.tbtn_start.Name = "tbtn_start";
            this.tbtn_start.Size = new System.Drawing.Size(108, 44);
            this.tbtn_start.TabIndex = 0;
            this.tbtn_start.Text = "服务启动";
            this.tbtn_start.UseSelectable = true;
            this.tbtn_start.UseVisualStyleBackColor = true;
            this.tbtn_start.Click += new System.EventHandler(this.tbtn_start_Click);
            // 
            // rtb_dataswich
            // 
            this.rtb_dataswich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_dataswich.Location = new System.Drawing.Point(288, 0);
            this.rtb_dataswich.Name = "rtb_dataswich";
            this.rtb_dataswich.Size = new System.Drawing.Size(484, 300);
            this.rtb_dataswich.TabIndex = 32;
            this.rtb_dataswich.Text = "";
            // 
            // gp_send
            // 
            this.gp_send.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp_send.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp_send.Controls.Add(this.rtxb_send);
            this.gp_send.Controls.Add(this.panelEx1);
            this.gp_send.DisabledBackColor = System.Drawing.Color.Empty;
            this.gp_send.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gp_send.Location = new System.Drawing.Point(288, 300);
            this.gp_send.Name = "gp_send";
            this.gp_send.Size = new System.Drawing.Size(484, 235);
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
            this.gp_send.TabIndex = 31;
            this.gp_send.Text = "消息发送";
            // 
            // rtxb_send
            // 
            this.rtxb_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxb_send.Location = new System.Drawing.Point(0, 0);
            this.rtxb_send.Name = "rtxb_send";
            this.rtxb_send.Size = new System.Drawing.Size(478, 98);
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
            this.panelEx1.Size = new System.Drawing.Size(478, 108);
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
            // AsynSocketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 535);
            this.Controls.Add(this.rtb_dataswich);
            this.Controls.Add(this.gp_send);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AsynSocketForm";
            this.Text = "AsynSocket";
            this.Load += new System.EventHandler(this.AsynSocketForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel_conn.ResumeLayout(false);
            this.panel_conn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.gp_send.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.PanelEx panel_conn;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton tbtn_end;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton tbtn_start;
        private System.Windows.Forms.ListView lv_client;
        private System.Windows.Forms.ColumnHeader NO;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader Port;
        private System.Windows.Forms.RichTextBox rtb_dataswich;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_send;
        private System.Windows.Forms.RichTextBox rtxb_send;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton mbtn_clean;
        private System.Windows.Forms.Label lbl_client;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton tbtn_send;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton tbtn_allsend;
        private System.Windows.Forms.TextBox txb_ip;
        private System.Windows.Forms.Label label2;
    }
}