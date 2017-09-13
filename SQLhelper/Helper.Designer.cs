namespace SQLhelper
{
    partial class Helper
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtxb_import = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_type = new MetroFramework.Controls.MetroComboBox();
            this.rbtn_modi = new System.Windows.Forms.RadioButton();
            this.rbtn_add = new System.Windows.Forms.RadioButton();
            this.rtxb_output = new System.Windows.Forms.RichTextBox();
            this.rtxb_parm = new System.Windows.Forms.RichTextBox();
            this.clb_item = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_creat = new MetroFramework.Controls.MetroTile();
            this.lbl_basename = new MetroFramework.Controls.MetroLabel();
            this.lbl_namecount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.allcheck = new MetroFramework.Controls.MetroCheckBox();
            this.txb_newob = new MetroFramework.Controls.MetroTextBox();
            this.btn_clean = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.rtxb_output);
            this.splitContainer1.Panel2.Controls.Add(this.rtxb_parm);
            this.splitContainer1.Panel2.Controls.Add(this.clb_item);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(890, 513);
            this.splitContainer1.SplitterDistance = 384;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // rtxb_import
            // 
            this.rtxb_import.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxb_import.Location = new System.Drawing.Point(0, 202);
            this.rtxb_import.Name = "rtxb_import";
            this.rtxb_import.Size = new System.Drawing.Size(384, 311);
            this.rtxb_import.TabIndex = 1;
            this.rtxb_import.Text = "";
            this.rtxb_import.TextChanged += new System.EventHandler(this.rtxb_import_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.btn_clean);
            this.groupBox1.Controls.Add(this.txb_newob);
            this.groupBox1.Controls.Add(this.allcheck);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.cmb_type);
            this.groupBox1.Controls.Add(this.btn_creat);
            this.groupBox1.Controls.Add(this.rbtn_modi);
            this.groupBox1.Controls.Add(this.rbtn_add);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(384, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.ItemHeight = 23;
            this.cmb_type.Location = new System.Drawing.Point(64, 75);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(97, 29);
            this.cmb_type.TabIndex = 3;
            this.cmb_type.UseSelectable = true;
            // 
            // rbtn_modi
            // 
            this.rbtn_modi.AutoSize = true;
            this.rbtn_modi.Location = new System.Drawing.Point(237, 85);
            this.rbtn_modi.Name = "rbtn_modi";
            this.rbtn_modi.Size = new System.Drawing.Size(42, 20);
            this.rbtn_modi.TabIndex = 1;
            this.rbtn_modi.Text = "改";
            this.rbtn_modi.UseVisualStyleBackColor = true;
            // 
            // rbtn_add
            // 
            this.rbtn_add.AutoSize = true;
            this.rbtn_add.Checked = true;
            this.rbtn_add.Location = new System.Drawing.Point(237, 26);
            this.rbtn_add.Name = "rbtn_add";
            this.rbtn_add.Size = new System.Drawing.Size(42, 20);
            this.rbtn_add.TabIndex = 0;
            this.rbtn_add.TabStop = true;
            this.rbtn_add.Text = "增";
            this.rbtn_add.UseVisualStyleBackColor = true;
            // 
            // rtxb_output
            // 
            this.rtxb_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxb_output.Location = new System.Drawing.Point(143, 76);
            this.rtxb_output.Name = "rtxb_output";
            this.rtxb_output.Size = new System.Drawing.Size(358, 302);
            this.rtxb_output.TabIndex = 2;
            this.rtxb_output.Text = "";
            // 
            // rtxb_parm
            // 
            this.rtxb_parm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxb_parm.Location = new System.Drawing.Point(143, 378);
            this.rtxb_parm.Name = "rtxb_parm";
            this.rtxb_parm.Size = new System.Drawing.Size(358, 135);
            this.rtxb_parm.TabIndex = 3;
            this.rtxb_parm.Text = "";
            // 
            // clb_item
            // 
            this.clb_item.Dock = System.Windows.Forms.DockStyle.Left;
            this.clb_item.FormattingEnabled = true;
            this.clb_item.Location = new System.Drawing.Point(0, 76);
            this.clb_item.Name = "clb_item";
            this.clb_item.Size = new System.Drawing.Size(143, 437);
            this.clb_item.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_namecount);
            this.groupBox2.Controls.Add(this.lbl_basename);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 76);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "明细";
            // 
            // btn_creat
            // 
            this.btn_creat.ActiveControl = null;
            this.btn_creat.Location = new System.Drawing.Point(237, 130);
            this.btn_creat.Name = "btn_creat";
            this.btn_creat.Size = new System.Drawing.Size(140, 51);
            this.btn_creat.TabIndex = 2;
            this.btn_creat.Text = "生成";
            this.btn_creat.UseSelectable = true;
            this.btn_creat.Click += new System.EventHandler(this.btn_creat_Click);
            // 
            // lbl_basename
            // 
            this.lbl_basename.AutoSize = true;
            this.lbl_basename.Location = new System.Drawing.Point(143, 29);
            this.lbl_basename.Name = "lbl_basename";
            this.lbl_basename.Size = new System.Drawing.Size(65, 19);
            this.lbl_basename.TabIndex = 9;
            this.lbl_basename.Text = "数据表：";
            // 
            // lbl_namecount
            // 
            this.lbl_namecount.AutoSize = true;
            this.lbl_namecount.Location = new System.Drawing.Point(6, 32);
            this.lbl_namecount.Name = "lbl_namecount";
            this.lbl_namecount.Size = new System.Drawing.Size(54, 19);
            this.lbl_namecount.TabIndex = 10;
            this.lbl_namecount.Text = "字段数:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "类型";
            // 
            // allcheck
            // 
            this.allcheck.AutoSize = true;
            this.allcheck.Location = new System.Drawing.Point(315, 29);
            this.allcheck.Name = "allcheck";
            this.allcheck.Size = new System.Drawing.Size(49, 15);
            this.allcheck.TabIndex = 5;
            this.allcheck.Text = "全选";
            this.allcheck.UseSelectable = true;
            this.allcheck.CheckedChanged += new System.EventHandler(this.allcheck_CheckedChanged);
            // 
            // txb_newob
            // 
            // 
            // 
            // 
            this.txb_newob.CustomButton.Image = null;
            this.txb_newob.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txb_newob.CustomButton.Name = "";
            this.txb_newob.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_newob.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_newob.CustomButton.TabIndex = 1;
            this.txb_newob.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_newob.CustomButton.UseSelectable = true;
            this.txb_newob.CustomButton.Visible = false;
            this.txb_newob.Lines = new string[0];
            this.txb_newob.Location = new System.Drawing.Point(64, 29);
            this.txb_newob.MaxLength = 32767;
            this.txb_newob.Name = "txb_newob";
            this.txb_newob.PasswordChar = '\0';
            this.txb_newob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_newob.SelectedText = "";
            this.txb_newob.SelectionLength = 0;
            this.txb_newob.SelectionStart = 0;
            this.txb_newob.Size = new System.Drawing.Size(97, 23);
            this.txb_newob.TabIndex = 6;
            this.txb_newob.UseSelectable = true;
            this.txb_newob.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_newob.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_clean
            // 
            this.btn_clean.ActiveControl = null;
            this.btn_clean.Location = new System.Drawing.Point(21, 130);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(140, 51);
            this.btn_clean.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_clean.TabIndex = 7;
            this.btn_clean.Text = "清空";
            this.btn_clean.UseSelectable = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 32);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "实体类";
            // 
            // Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 620);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Helper";
            this.Padding = new System.Windows.Forms.Padding(27, 80, 27, 27);
            this.Text = "SQLHelper";
            this.Load += new System.EventHandler(this.Helper_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtxb_import;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cmb_type;
        private System.Windows.Forms.RadioButton rbtn_modi;
        private System.Windows.Forms.RadioButton rbtn_add;
        private System.Windows.Forms.RichTextBox rtxb_output;
        private System.Windows.Forms.CheckedListBox clb_item;
        private System.Windows.Forms.RichTextBox rtxb_parm;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btn_clean;
        private MetroFramework.Controls.MetroTextBox txb_newob;
        private MetroFramework.Controls.MetroCheckBox allcheck;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btn_creat;
        private MetroFramework.Controls.MetroLabel lbl_namecount;
        private MetroFramework.Controls.MetroLabel lbl_basename;
    }
}

