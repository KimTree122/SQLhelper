using MetroFramework;
using MetroFramework.Forms;
using SQLhelper.BLL;
using SQLhelper.HelperDAL;
using SQLhelper.IHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQLhelper
{
    public partial class ADOHelper : MetroForm
    {
        private FormHelper formHelper = new FormHelper();
        private List<string> dBNames = new List<string>();
        private List<string> tbColumns = new List<string>();
        private bool columnsFlag;
        private string chooseBaseName;

        private InsertSQL insql = new InsertSQL();
        private UpdateSQL updatesql = new UpdateSQL();
        private ObjectConstructor ocon = new ObjectConstructor();

        public ADOHelper()
        {
            InitializeComponent();
        }

        private void ADOHelper_Load(object sender, EventArgs e)
        {
            InitControl(false);
            InitData();
        }

        private void InitData()
        {
            ConnElement ce = formHelper.ReadAppConfig();
            txb_ip.Text = ce.ip;
            txb_db.Text = ce.db;
            txb_pwd.Text = ce.pwd;
            txb_user.Text = ce.user;
        }

        private void InitControl(bool showflag)
        {
            btn_output.Enabled = showflag;
            panel_dbfind.Enabled = showflag;
        }

        private void ClearData()
        {
            listView.Items.Clear();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            ConnElement ce = new ConnElement { ip = txb_ip.Text.Trim(), db = txb_db.Text.Trim(),
             user = txb_user.Text.Trim(), pwd = txb_pwd.Text.Trim()};
            bool checkConnect = formHelper.InitConnHelper(ce);
            if (!checkConnect)
            {
                InitControl(true);
                dBNames = formHelper.GetDBNameList();
                ShowDBName(dBNames);
            }
            else
            {
                MetroMessageBox.Show(this, "连接失效","提示");
            }
        }

        private void ShowDBName(List<string> tbname)
        {
            ClearData();
           
            foreach (var tableName in tbname)
            {
                listView.Items.Add(tableName);
            }
            listView.CheckBoxes = false;

            //if (listView.Items.Count > 0)
            //{
            //    listView.Items[0].Selected = true;
            //}

        }

        private void ShowColumns(string tableName)
        {
            columnsFlag = true ;
            tbColumns = formHelper.GetTableColumns(tableName);
            listView.Items.Clear();
            foreach (var column in tbColumns)
            {
                listView.Items.Add(column);

            }
            listView.CheckBoxes = true;

            foreach (ListViewItem item in listView.Items)
            {
                item.Checked = true;
            }
        }

        private void btn_dbcomfire_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listView.SelectedItems[0];
            chooseBaseName = lvi.Text;
            ShowColumns(chooseBaseName);
        }

        private void btn_dbrefrash_Click(object sender, EventArgs e)
        {
            ShowDBName(dBNames);
        }

        private void txb_select_TextChanged(object sender, EventArgs e)
        {
            if (columnsFlag) return;
            List<string> findtable = dBNames.Where(q => q.ToLower().Contains(txb_select.Text)).ToList();
            ShowDBName(findtable);
        }

        private void btn_output_Click(object sender, EventArgs e)
        {
            List<string> strlst = GetChoice(false);
            List<string> allfeild = GetChoice(true);

            if (strlst == null || allfeild == null) return;

            if (strlst.Count == 0 || allfeild.Count == 0) return;


            rtxb_add_normal.Text = insql.CreatNormalSQL(strlst, chooseBaseName);
            rtxb_add_param.Text = insql.CreatParamSQL(strlst, chooseBaseName);

            rtxb_update_normal.Text = updatesql.CreatNormalSQL(strlst, chooseBaseName);
            rtxb_update_param.Text = updatesql.CreatParamSQL(strlst, chooseBaseName);

            rtxb_c_con.Text = ocon.CreatCSharpConstructor(allfeild, false);
            rtxb_c_con2.Text = ocon.CreatCSharpConstructor(allfeild, true);

            rtxb_j_con.Text = ocon.CreatJavaConstructor(allfeild, false);
            rtxb_j_con2.Text = ocon.CreatJavaConstructor(allfeild, true);


            if (txb_obj.Text.Trim().Length > 0)
            {
                rtxb_object.Text = ocon.ObjectList(strlst, txb_obj.Text.Trim(), false);
                rtxb_object2.Text = ocon.ObjectList(strlst, txb_obj.Text.Trim(), true);
            }
            else
            {
                rtxb_object.Text = "";
                rtxb_object2.Text = "";
            }
        }

        private List<string> GetChoice(bool all)
        {
            List<string> strlist = new List<string>();
            foreach (ListViewItem lvi in listView.Items)
            {
                if (all)
                {
                    strlist.Add(lvi.Text);
                }
                else
                {
                    if (lvi.Checked)
                    {
                        strlist.Add(lvi.Text);
                    }
                }
            }

            return strlist;
        }


    }
}
