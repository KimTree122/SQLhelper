using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartMent
{
    public partial class Form1 : Form
    {
        private TreeNode ChoiceTn;
        private List<TreeNode> tnLs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitData();
            LoadData();
        }

        private void LoadData()
        {
            List<Auth> authls = GetAuthList();
            tnLs = new List<TreeNode>();
            //ShowDataTree(authls);
            CreatTNls("0", authls);
            TreeViewShow();
        }

        private void TreeViewShow()
        {
            treeView.Nodes.Clear();
            foreach (TreeNode tn in tnLs)
            {
                treeView.Nodes.Add(tn);
            }
            treeView.ExpandAll();

        }

        private void ShowDataTree(List<Auth> authls)
        {
            List<TreeNode> TNls = new List<TreeNode>();
            foreach (Auth au in authls)
            {
                if (au.ParentID == "0")
                {
                    TreeNode ftn = new TreeNode(au.AuthName);
                    ftn.Tag = au.ID;
                    ftn.Name = au.AuthName;
                    TreeNode stn = GetSonTreeNode(authls, au);
                    if (stn.Text != "")
                    {
                        ftn.Nodes.Add(stn);
                    }
                   
                    TNls.Add(ftn);
                }
               
            }

            foreach (TreeNode t in TNls)
            {
                treeView.Nodes.Add(t);
            }
            treeView.ExpandAll();
        }

        private TreeNode GetSonTreeNode(List<Auth> authls, Auth au)
        {
            TreeNode stn = new TreeNode();
            foreach (Auth a in authls)
            {
                if (a.ParentID == au.ID)
                {
                    stn.Text = a.AuthName;
                    stn.Name = a.AuthName;
                    stn.Tag = a.ID;
                    TreeNode t = GetSonTreeNode(authls, a);
                    stn.Nodes.Add(t);
                }
            }
            return stn;

        }


        public void CreatTNls(string fid, List<Auth> authls)
        {
            foreach (Auth a in authls)
            {
                if (a.ParentID == fid)
                {
                    TreeNode tn = new TreeNode();
                    tn.Text = a.AuthName;
                    tn.Tag = a;
                    //tn.ImageIndex = 0;
                    tnLs.Add(tn);
                    AddSonTN(tn, authls);
                }
            }
        }

        public void AddSonTN( TreeNode tn , List<Auth> authls)
        {
            Auth fa =(Auth) tn.Tag ;

            foreach (Auth a in authls)
            {
                if (a.ParentID == fa.ID)
                {
                    TreeNode stn = new TreeNode();
                    stn.Text = a.AuthName;
                    stn.Tag = a;
                    tn.Nodes.Add(stn);
                    //tn.ImageIndex = 1;
                    AddSonTN(stn,authls);
                }
            }
        }


        private static List<Auth> GetAuthList()
        {
            string sql = string.Format("SELECT * FROM dbo.Authority ORDER BY ID, Aorder");
            DataTable dt = ADO.ExecuteDataTable(sql);
            return DataChange.DTToList<Auth>(dt);
        }

        private  void InitData()
        {
            DataTable dttype = new DataTable();
            dttype.Columns.Add("authid");
            dttype.Columns.Add("authname");
            dttype.Rows.Add("1", "功能权限");
            dttype.Rows.Add("2", "控制权限");
            dttype.Rows.Add("3", "部门权限");
            dttype.Rows.Add("4", "管理权限");
            cmb_type.DataSource = dttype;
            cmb_type.DisplayMember = "authname";
            cmb_type.ValueMember = "authid";


            //Image im = Image.FromFile(Application.StartupPath + "/Image/ic_begintran.png");
            Image im2 = Image.FromFile(Application.StartupPath + "/Image/ic_distribution.png");
            treeView.ImageList = new ImageList();
            //treeView.ImageList.Images.Add(im);
            treeView.ImageList.Images.Add(im2);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string authname = txb_name.Text;
            string authtype = cmb_type.Text;
            string authtypeid = cmb_type.SelectedValue.ToString();
            string order = txb_order.Text;
            Auth a =(Auth) ChoiceTn.Tag;

            string sql = string.Format("INSERT INTO  Authority  ( AuthName , ParentID , AuthTypeID , AuthTypeName , Aorder ) VALUES (@AuthName,@ParentID,@AuthTypeID,@AuthTypeName,@Aorder)");
            int count = ADO.ExecuteNonQuery(sql
                , new SqlParameter("@AuthName",authname)
                , new SqlParameter("@ParentID", ChoiceTn == null ? "" : a.ID)
                , new SqlParameter("@AuthTypeID", authtypeid)
                , new SqlParameter("@AuthTypeName", authtype)
                , new SqlParameter("@Aorder", order));
            if (count > 0)
            {
                MessageBox.Show("新增成功");
                LoadData();
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ChoiceTn = treeView.SelectedNode;

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
