namespace SQLhelper
{
    partial class SQLHelp
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtxb_import = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_basename = new System.Windows.Forms.Label();
            this.lbl_basecount = new System.Windows.Forms.Label();
            this.btn_create = new MetroFramework.Controls.MetroTile();
            this.btn_input = new MetroFramework.Controls.MetroTile();
            this.btn_clean = new MetroFramework.Controls.MetroTile();
            this.allcheck = new MetroFramework.Controls.MetroCheckBox();
            this.txb_obj = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroTab = new MetroFramework.Controls.MetroTabControl();
            this.mTP1 = new MetroFramework.Controls.MetroTabPage();
            this.rtxb_add_normal = new System.Windows.Forms.RichTextBox();
            this.rtxb_add_param = new System.Windows.Forms.RichTextBox();
            this.mTP2 = new MetroFramework.Controls.MetroTabPage();
            this.rtxb_update_normal = new System.Windows.Forms.RichTextBox();
            this.rtxb_update_param = new System.Windows.Forms.RichTextBox();
            this.mTP3 = new MetroFramework.Controls.MetroTabPage();
            this.rtxb_c_con = new System.Windows.Forms.RichTextBox();
            this.mTP4 = new MetroFramework.Controls.MetroTabPage();
            this.rtxb_j_con = new System.Windows.Forms.RichTextBox();
            this.mTP5 = new MetroFramework.Controls.MetroTabPage();
            this.rtxb_object = new System.Windows.Forms.RichTextBox();
            this.clb_item = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.metroTab.SuspendLayout();
            this.mTP1.SuspendLayout();
            this.mTP2.SuspendLayout();
            this.mTP3.SuspendLayout();
            this.mTP4.SuspendLayout();
            this.mTP5.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(27, 80);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtxb_import);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(947, 493);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // rtxb_import
            // 
            this.rtxb_import.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxb_import.Location = new System.Drawing.Point(0, 192);
            this.rtxb_import.Name = "rtxb_import";
            this.rtxb_import.Size = new System.Drawing.Size(295, 301);
            this.rtxb_import.TabIndex = 1;
            this.rtxb_import.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btn_create);
            this.groupBox1.Controls.Add(this.btn_input);
            this.groupBox1.Controls.Add(this.btn_clean);
            this.groupBox1.Controls.Add(this.allcheck);
            this.groupBox1.Controls.Add(this.txb_obj);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_basename);
            this.panel1.Controls.Add(this.lbl_basecount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 51);
            this.panel1.TabIndex = 12;
            // 
            // lbl_basename
            // 
            this.lbl_basename.AutoSize = true;
            this.lbl_basename.Location = new System.Drawing.Point(3, 17);
            this.lbl_basename.Name = "lbl_basename";
            this.lbl_basename.Size = new System.Drawing.Size(72, 16);
            this.lbl_basename.TabIndex = 2;
            this.lbl_basename.Text = "数据表：";
            // 
            // lbl_basecount
            // 
            this.lbl_basecount.AutoSize = true;
            this.lbl_basecount.Location = new System.Drawing.Point(193, 17);
            this.lbl_basecount.Name = "lbl_basecount";
            this.lbl_basecount.Size = new System.Drawing.Size(72, 16);
            this.lbl_basecount.TabIndex = 13;
            this.lbl_basecount.Text = "字段数：";
            // 
            // btn_create
            // 
            this.btn_create.ActiveControl = null;
            this.btn_create.Location = new System.Drawing.Point(206, 81);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(93, 51);
            this.btn_create.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btn_create.TabIndex = 11;
            this.btn_create.Text = "生成";
            this.btn_create.UseSelectable = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_input
            // 
            this.btn_input.ActiveControl = null;
            this.btn_input.Location = new System.Drawing.Point(106, 81);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(93, 51);
            this.btn_input.TabIndex = 10;
            this.btn_input.Text = "验证";
            this.btn_input.UseSelectable = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.ActiveControl = null;
            this.btn_clean.Location = new System.Drawing.Point(7, 81);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(93, 51);
            this.btn_clean.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_clean.TabIndex = 9;
            this.btn_clean.Text = "清空";
            this.btn_clean.UseSelectable = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // allcheck
            // 
            this.allcheck.AutoSize = true;
            this.allcheck.Location = new System.Drawing.Point(225, 35);
            this.allcheck.Name = "allcheck";
            this.allcheck.Size = new System.Drawing.Size(49, 15);
            this.allcheck.TabIndex = 8;
            this.allcheck.Text = "全选";
            this.allcheck.UseSelectable = true;
            this.allcheck.CheckedChanged += new System.EventHandler(this.allcheck_CheckedChanged);
            // 
            // txb_obj
            // 
            // 
            // 
            // 
            this.txb_obj.CustomButton.Image = null;
            this.txb_obj.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txb_obj.CustomButton.Name = "";
            this.txb_obj.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_obj.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_obj.CustomButton.TabIndex = 1;
            this.txb_obj.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_obj.CustomButton.UseSelectable = true;
            this.txb_obj.CustomButton.Visible = false;
            this.txb_obj.Lines = new string[0];
            this.txb_obj.Location = new System.Drawing.Point(79, 31);
            this.txb_obj.MaxLength = 32767;
            this.txb_obj.Name = "txb_obj";
            this.txb_obj.PasswordChar = '\0';
            this.txb_obj.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_obj.SelectedText = "";
            this.txb_obj.SelectionLength = 0;
            this.txb_obj.SelectionStart = 0;
            this.txb_obj.Size = new System.Drawing.Size(120, 23);
            this.txb_obj.TabIndex = 2;
            this.txb_obj.UseSelectable = true;
            this.txb_obj.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_obj.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "类缩写：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroTab);
            this.groupBox2.Controls.Add(this.clb_item);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 493);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "导出数据";
            // 
            // metroTab
            // 
            this.metroTab.Controls.Add(this.mTP1);
            this.metroTab.Controls.Add(this.mTP2);
            this.metroTab.Controls.Add(this.mTP3);
            this.metroTab.Controls.Add(this.mTP4);
            this.metroTab.Controls.Add(this.mTP5);
            this.metroTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTab.Location = new System.Drawing.Point(151, 22);
            this.metroTab.Name = "metroTab";
            this.metroTab.SelectedIndex = 0;
            this.metroTab.Size = new System.Drawing.Size(493, 468);
            this.metroTab.TabIndex = 5;
            this.metroTab.UseSelectable = true;
            // 
            // mTP1
            // 
            this.mTP1.Controls.Add(this.rtxb_add_normal);
            this.mTP1.Controls.Add(this.rtxb_add_param);
            this.mTP1.HorizontalScrollbarBarColor = true;
            this.mTP1.HorizontalScrollbarHighlightOnWheel = false;
            this.mTP1.HorizontalScrollbarSize = 4;
            this.mTP1.Location = new System.Drawing.Point(4, 38);
            this.mTP1.Name = "mTP1";
            this.mTP1.Size = new System.Drawing.Size(485, 426);
            this.mTP1.TabIndex = 0;
            this.mTP1.Text = "C#-新增";
            this.mTP1.VerticalScrollbarBarColor = true;
            this.mTP1.VerticalScrollbarHighlightOnWheel = false;
            this.mTP1.VerticalScrollbarSize = 4;
            // 
            // rtxb_add_normal
            // 
            this.rtxb_add_normal.BackColor = System.Drawing.SystemColors.Window;
            this.rtxb_add_normal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxb_add_normal.Location = new System.Drawing.Point(0, 26);
            this.rtxb_add_normal.Name = "rtxb_add_normal";
            this.rtxb_add_normal.Size = new System.Drawing.Size(485, 200);
            this.rtxb_add_normal.TabIndex = 4;
            this.rtxb_add_normal.Text = "";
            // 
            // rtxb_add_param
            // 
            this.rtxb_add_param.BackColor = System.Drawing.SystemColors.Window;
            this.rtxb_add_param.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxb_add_param.Location = new System.Drawing.Point(0, 226);
            this.rtxb_add_param.Name = "rtxb_add_param";
            this.rtxb_add_param.Size = new System.Drawing.Size(485, 200);
            this.rtxb_add_param.TabIndex = 5;
            this.rtxb_add_param.Text = "";
            // 
            // mTP2
            // 
            this.mTP2.Controls.Add(this.rtxb_update_normal);
            this.mTP2.Controls.Add(this.rtxb_update_param);
            this.mTP2.HorizontalScrollbarBarColor = true;
            this.mTP2.HorizontalScrollbarHighlightOnWheel = false;
            this.mTP2.HorizontalScrollbarSize = 4;
            this.mTP2.Location = new System.Drawing.Point(4, 38);
            this.mTP2.Name = "mTP2";
            this.mTP2.Size = new System.Drawing.Size(485, 426);
            this.mTP2.TabIndex = 1;
            this.mTP2.Text = "C#-更新";
            this.mTP2.VerticalScrollbarBarColor = true;
            this.mTP2.VerticalScrollbarHighlightOnWheel = false;
            this.mTP2.VerticalScrollbarSize = 4;
            // 
            // rtxb_update_normal
            // 
            this.rtxb_update_normal.BackColor = System.Drawing.SystemColors.Window;
            this.rtxb_update_normal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxb_update_normal.Location = new System.Drawing.Point(0, 26);
            this.rtxb_update_normal.Name = "rtxb_update_normal";
            this.rtxb_update_normal.Size = new System.Drawing.Size(485, 200);
            this.rtxb_update_normal.TabIndex = 4;
            this.rtxb_update_normal.Text = "";
            // 
            // rtxb_update_param
            // 
            this.rtxb_update_param.BackColor = System.Drawing.SystemColors.Window;
            this.rtxb_update_param.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxb_update_param.Location = new System.Drawing.Point(0, 226);
            this.rtxb_update_param.Name = "rtxb_update_param";
            this.rtxb_update_param.Size = new System.Drawing.Size(485, 200);
            this.rtxb_update_param.TabIndex = 3;
            this.rtxb_update_param.Text = "";
            // 
            // mTP3
            // 
            this.mTP3.Controls.Add(this.rtxb_c_con);
            this.mTP3.HorizontalScrollbarBarColor = true;
            this.mTP3.HorizontalScrollbarHighlightOnWheel = false;
            this.mTP3.HorizontalScrollbarSize = 4;
            this.mTP3.Location = new System.Drawing.Point(4, 38);
            this.mTP3.Name = "mTP3";
            this.mTP3.Size = new System.Drawing.Size(485, 426);
            this.mTP3.TabIndex = 2;
            this.mTP3.Text = "C#-构造器";
            this.mTP3.VerticalScrollbarBarColor = true;
            this.mTP3.VerticalScrollbarHighlightOnWheel = false;
            this.mTP3.VerticalScrollbarSize = 4;
            // 
            // rtxb_c_con
            // 
            this.rtxb_c_con.BackColor = System.Drawing.SystemColors.Window;
            this.rtxb_c_con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxb_c_con.Location = new System.Drawing.Point(0, 26);
            this.rtxb_c_con.Name = "rtxb_c_con";
            this.rtxb_c_con.Size = new System.Drawing.Size(485, 400);
            this.rtxb_c_con.TabIndex = 5;
            this.rtxb_c_con.Text = "";
            // 
            // mTP4
            // 
            this.mTP4.Controls.Add(this.rtxb_j_con);
            this.mTP4.HorizontalScrollbarBarColor = true;
            this.mTP4.HorizontalScrollbarHighlightOnWheel = false;
            this.mTP4.HorizontalScrollbarSize = 4;
            this.mTP4.Location = new System.Drawing.Point(4, 38);
            this.mTP4.Name = "mTP4";
            this.mTP4.Size = new System.Drawing.Size(485, 426);
            this.mTP4.TabIndex = 3;
            this.mTP4.Text = "JAVA-构造器";
            this.mTP4.VerticalScrollbarBarColor = true;
            this.mTP4.VerticalScrollbarHighlightOnWheel = false;
            this.mTP4.VerticalScrollbarSize = 4;
            // 
            // rtxb_j_con
            // 
            this.rtxb_j_con.BackColor = System.Drawing.SystemColors.Window;
            this.rtxb_j_con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxb_j_con.Location = new System.Drawing.Point(0, 26);
            this.rtxb_j_con.Name = "rtxb_j_con";
            this.rtxb_j_con.Size = new System.Drawing.Size(485, 400);
            this.rtxb_j_con.TabIndex = 6;
            this.rtxb_j_con.Text = "";
            // 
            // mTP5
            // 
            this.mTP5.Controls.Add(this.rtxb_object);
            this.mTP5.HorizontalScrollbarBarColor = true;
            this.mTP5.HorizontalScrollbarHighlightOnWheel = false;
            this.mTP5.HorizontalScrollbarSize = 4;
            this.mTP5.Location = new System.Drawing.Point(4, 38);
            this.mTP5.Name = "mTP5";
            this.mTP5.Size = new System.Drawing.Size(485, 426);
            this.mTP5.TabIndex = 4;
            this.mTP5.Text = "类项";
            this.mTP5.VerticalScrollbarBarColor = true;
            this.mTP5.VerticalScrollbarHighlightOnWheel = false;
            this.mTP5.VerticalScrollbarSize = 4;
            // 
            // rtxb_object
            // 
            this.rtxb_object.BackColor = System.Drawing.SystemColors.Window;
            this.rtxb_object.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxb_object.Location = new System.Drawing.Point(0, 26);
            this.rtxb_object.Name = "rtxb_object";
            this.rtxb_object.Size = new System.Drawing.Size(485, 400);
            this.rtxb_object.TabIndex = 6;
            this.rtxb_object.Text = "";
            // 
            // clb_item
            // 
            this.clb_item.Dock = System.Windows.Forms.DockStyle.Left;
            this.clb_item.FormattingEnabled = true;
            this.clb_item.Location = new System.Drawing.Point(3, 22);
            this.clb_item.Name = "clb_item";
            this.clb_item.Size = new System.Drawing.Size(148, 468);
            this.clb_item.TabIndex = 2;
            this.clb_item.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clb_item_MouseUp);
            // 
            // SQLHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::SQLhelper.Properties.Resources.sqlhelp;
            this.ClientSize = new System.Drawing.Size(1001, 600);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SQLHelp";
            this.Padding = new System.Windows.Forms.Padding(27, 80, 27, 27);
            this.Text = "SQLHelp";
            this.Load += new System.EventHandler(this.SQLHelp_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.metroTab.ResumeLayout(false);
            this.mTP1.ResumeLayout(false);
            this.mTP2.ResumeLayout(false);
            this.mTP3.ResumeLayout(false);
            this.mTP4.ResumeLayout(false);
            this.mTP5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtxb_import;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxb_add_normal;
        private System.Windows.Forms.RichTextBox rtxb_update_param;
        private System.Windows.Forms.CheckedListBox clb_item;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txb_obj;
        private MetroFramework.Controls.MetroTile btn_create;
        private MetroFramework.Controls.MetroTile btn_input;
        private MetroFramework.Controls.MetroTile btn_clean;
        private MetroFramework.Controls.MetroCheckBox allcheck;
        private MetroFramework.Controls.MetroTabControl metroTab;
        private MetroFramework.Controls.MetroTabPage mTP1;
        private MetroFramework.Controls.MetroTabPage mTP2;
        private MetroFramework.Controls.MetroTabPage mTP3;
        private MetroFramework.Controls.MetroTabPage mTP4;
        private MetroFramework.Controls.MetroTabPage mTP5;
        private System.Windows.Forms.RichTextBox rtxb_add_param;
        private System.Windows.Forms.RichTextBox rtxb_update_normal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_basecount;
        private System.Windows.Forms.Label lbl_basename;
        private System.Windows.Forms.RichTextBox rtxb_c_con;
        private System.Windows.Forms.RichTextBox rtxb_j_con;
        private System.Windows.Forms.RichTextBox rtxb_object;

    }
}