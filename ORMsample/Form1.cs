using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORMsample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess acc = new DataAccess();
            UserInfo info = new UserInfo();
            info.UserName = "TestUser" ;     
            info.UserDec = "http://www.apace.com.cn"; 
            info.UserEMail = "G_Jack@126.com";
            info.UserTel = "9988996";
            info.RegIpAddres = "testip";
            info.Guid = "08298B95-8DA0-4B3E-97A2-5DA84BA010BF";


            //测试新增
            //acc.AddOnlyObject(info);
            //测试更新
            acc.UpdateOnlyObject(info);
            ////测试删除
            //acc.DelOnlyObject(info);
        }
    }
}
