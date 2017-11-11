using ORMsample.Model;
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
 
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Testsum3();
        }

        private void Testsum3()
        {
            Solution s = new Solution();
            string str = s.GetHint2(input_1.Text, input_2.Text);
            output_1.Text = str;
        }

        private void TestSum2()
        {
            ListNode l1 = new ListNode(4);
            ListNode l2 = new ListNode(6);
            Solution s = new Solution();
            ListNode l3 = s.AddTwoNumbers(l1, l2);
        }

        private void ORMtest()
        {
            DataAccess acc = new DataAccess();
            UserInfo info = new UserInfo();
            info.UserName = "TestUser";
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
