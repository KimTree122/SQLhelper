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
    public partial class Mytest : Form
    {
        public Mytest()
        {
            InitializeComponent();
        }

        private int[] ilist = new int[] { 3, 2, 4 };
        private int target = 6;

        private void Mytest_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ilist.Count(); i++)
            {
                int fn = ilist[i];
                for (int j = 0; j < ilist.Count(); j++)
                {
                    int sn = ilist[j];
                    if (fn == sn) continue;
                 
                    if ((fn + sn) == target)
                    {
                        MessageBox.Show("yi" + i + "er" + j);
                    }
                }
            }
        }
    }
}
