using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyThread
{
    public partial class Form1 : Form
    {
        public delegate void ThreadStart();
        public delegate void ThreadStart2(string str);
        public delegate void ParameterizedThreadStart(object obj);
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadTest3();
        }

        private void ThreadTest3() 
        {
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
        }

        private void delThread2()
        {
            ThreadStart2 s = new ThreadStart2(threadGo2);
            this.BeginInvoke(s);
        }

        private void ThreadTest2() 
        {
            Thread t = new Thread(delegate() { ThreadGo(); });
            t.Start();
            label2.Text = "Hello,World!";
        }

        private void ThreadTest1()
        {
            Thread t = new Thread(delThread);
            t.Start();
            label2.Text = "Hello,World!";
        }


        private void delThread()
        {
            ThreadStart s = new ThreadStart(ThreadGo);
            this.BeginInvoke(s);
        }

        private void ThreadGo()
        {
            label1.Text = "Hello,Thread!";
        }

        private void threadGo2(string str) 
        {
            label1.Text = str;
        }


    }
}
