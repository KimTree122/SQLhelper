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
    public partial class Helper : MetroForm
    {
        public Helper()
        {
            InitializeComponent();
        }
        private SQLStringCheck ssc;
        private string DataBaseName ;
        private string lblBaseName = "数据表:";
        private string lblNameCount = "字段数:";

        private string sql = "select   DocCode, DocDate, Doctype, Formid, BinCode, BoxCode, Sourcesite, SourceSiteName, DestSite, DestSiteName, Hrcode,HrName, actHrcode, actHrname, ActionType, ActBinCode, DocStatus, EnterName, EnterDate, ModifyName, ModifyDate, PostName, PostDate, FinishTime, blClosed, RefCode, RefFormid FROM  WM_CaseBoxActionDoc";


        private void Helper_Load(object sender, EventArgs e)
        {
            ssc = new SQLStringCheck();
            InitData();
            rtxb_import.Text = sql;

        }

        private void InitData()
        {
            lbl_basename.Text = lblBaseName;
            lbl_namecount.Text = lblNameCount;
            rtxb_import.Text = "";
            rtxb_output.Text = "";
            rtxb_parm.Text = "";
            clb_item.Items.Clear();
        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            if (rbtn_add.Checked) InsertData();
            else UpdataData();
        }

        private void UpdataData()
        {
            string newsql = "UPDATE  " + DataBaseName + " SET  ";

            int checkcount = 0;

            for (int i = 0; i < clb_item.Items.Count; i++)
            {
                if (clb_item.GetItemChecked(i))
                {
                    string cstr = "{" + checkcount + "}";
                    string s = string.Format(clb_item.Items[i].ToString() + " = '{0}' ,", cstr);
                    newsql += s;
                    checkcount++;
                }
            }
            newsql += "over";
            newsql = newsql.Replace(",over", "  where ");

            rtxb_output.Text = newsql;
        }

        private void InsertData()
        {
            string newsql = "INSERT INTO WM_CaseBoxActionDoc(";

            for (int i = 0; i < clb_item.Items.Count; i++)
            {
                if ( clb_item.GetItemChecked(i) )
                {
                    newsql += clb_item.Items[i].ToString() + ",";
                }
            }
            newsql += "over";
            newsql = newsql.Replace(",over", ") VALUES (");

            int checkcount = 0;
            for (int i = 0; i < clb_item.Items.Count; i++)
            {
                if (clb_item.GetItemChecked(i))
                {
                    newsql +="'{"+checkcount+"}',";
                    checkcount++;
                }
            }
            newsql += "over";
            newsql = newsql.Replace(",over", ")");

            rtxb_output.Text = newsql;

        }



        private void allcheck_CheckedChanged(object sender, EventArgs e)
        {  
            for (int i = 0; i < clb_item.Items.Count; i++)
            {
                clb_item.SetItemChecked(i, allcheck.Checked);
            }
        }

        private void rtxb_import_TextChanged(object sender, EventArgs e)
        {
            string importsql = rtxb_import.Text;
            bool c = ssc.Checklegal(importsql);
            if (!c)
            {
                MetroMessageBox.Show(this, "数据格式不符合.\r\n 请载入类似:select ... from BaseName 语句", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }  


            //DataBaseName = ssc.GetDataBaseName(importsql);


            //List<string> strlst = ssc.SplitSQL(importsql);

            clb_item.Items.Clear();

            //foreach (string s in strlst)
            //{
            //    clb_item.Items.Add(s, true);
            //}
            allcheck.Checked = true;
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            InitData();

           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
