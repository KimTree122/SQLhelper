using MetroFramework;
using MetroFramework.Forms;
using SQLhelper.BLL;
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
    public partial class SQLHelp : MetroForm
    {
        public SQLHelp()
        {
            InitializeComponent();
        }

        private SQLStringCheck ssc;
        private DataBaseField dbf;
        private InsertSQL insql;
        private UpdateSQL updatesql;
        private ObjectConstructor ocon;

        private string SQLstr;
        private string BaseName;
        private List<string> allfeild;

        private string basename = "数据表:";
        private string basecount = "字段数:";
        

        private void SQLHelp_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            ssc = new SQLStringCheck();
            dbf = new DataBaseField();
            insql = new InsertSQL();
            updatesql = new UpdateSQL();
            ocon = new ObjectConstructor();

            IntiData();
        }

        private void IntiData()
        {
            txb_obj.Text = "";
            allcheck.Checked = false;
            lbl_basename.Text = basename;
            lbl_basecount.Text = basecount;

            rtxb_import.Text = "";

            rtxb_add_param.Text = "";
            rtxb_add_normal.Text = "";
            rtxb_update_param.Text = "";
            rtxb_update_param.Text = "";

            rtxb_c_con.Text = "";
            rtxb_j_con.Text = "";
            rtxb_object.Text = "";

            SQLstr = "";
            BaseName = "";

            clb_item.Items.Clear();
            mTP1.Focus();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            IntiData();
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            SQLstr = rtxb_import.Text.Trim();

            if(!CheckFormat()) return;

            if (CheckBaseName() == "") return;

            allfeild = GetBaseFeild();

        }


        private List<string> GetBaseFeild()
        {
            List<string> strlst = dbf.SplitSQL(SQLstr);
            clb_item.Items.Clear();

            foreach (string s in strlst)
            {
                clb_item.Items.Add(s, true);
            }

            lbl_basecount.Text = basecount + strlst.Count();

            allcheck.Checked = true;
            return strlst;
        }

        private string CheckBaseName()
        {
            BaseName = ssc.GetBaseDataName(SQLstr);
            if (basename == "")
            {
                MetroMessageBox.Show(this, "未发现数据表名，请确认输入。"
                    , "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtxb_add_normal.Text = "";
                rtxb_update_param.Text = "";
            }
            else
            {
                lbl_basename.Text =basename + BaseName  ;
            }
            return basename;
        }

        private bool CheckFormat()
        {
             bool c = ssc.Checklegal(SQLstr);
            if (!c)
            {
                MetroMessageBox.Show(this, "SQL语句格式不符合.\r\n请输入符合:select ... from BaseName 的语句"
                    , "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return c;
        }

        private List<string> GetChoiceList()
        {
            List<string> strlst = new List<string>();
            for (int i = 0; i < clb_item.Items.Count; i++)
            {
                if (clb_item.GetItemChecked(i))
                {
                    strlst.Add(clb_item.Items[i].ToString());
                }
            }
            if (strlst.Count == 0)
            {
                rtxb_add_normal.Text = "";
                rtxb_add_param.Text = "";
                rtxb_c_con.Text = "";
                rtxb_j_con.Text = "";
                rtxb_object.Text = "";
                rtxb_update_normal.Text = "";
                rtxb_update_param.Text = "";
            }
            return strlst;

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            CreatSql();
        }

        private void CreatSql()
        {
            List<string> strlst = GetChoiceList();

            if (strlst == null || allfeild == null) return;

            if (allfeild.Count == 0) return;
            if (strlst.Count == 0) return;


            rtxb_add_normal.Text = insql.CreatNormalSQL(strlst, BaseName);
            rtxb_add_param.Text = insql.CreatParamSQL(strlst, BaseName);

            rtxb_update_normal.Text = updatesql.CreatNormalSQL(strlst, BaseName);
            rtxb_update_param.Text = updatesql.CreatParamSQL(strlst, BaseName);

            rtxb_c_con.Text = ocon.CreatCSharpConstructor(allfeild,false);
            rtxb_c_con2.Text = ocon.CreatCSharpConstructor(allfeild,true);

            rtxb_j_con.Text = ocon.CreatJavaConstructor(allfeild,false);
            rtxb_j_con2.Text = ocon.CreatJavaConstructor(allfeild, true);


            if (txb_obj.Text.Trim().Length > 0)
            {
                rtxb_object.Text = ocon.ObjectList(strlst, txb_obj.Text.Trim());
            }
            else
            {
                rtxb_object.Text = "";
            }
        }

        private void allcheck_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_item.Items.Count; i++)
            {
                clb_item.SetItemChecked(i, allcheck.Checked);
            }
        }

        private void clb_item_MouseUp(object sender, MouseEventArgs e)
        {
            CreatSql(); 
        }

       
    } 
}

