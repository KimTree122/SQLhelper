using KIM.SocketClient.AsynSocket;
using KIM.SocketClient.SocketClass;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KIM.SocketClient
{
    public partial class SocketClient : MetroForm
    {
        public SocketClient()
        {
            InitializeComponent();
        }

        private AsynSocketClient asynSocketClient;

        private void SocketClient_Load(object sender, EventArgs e)
        {
            asynSocketClient = new AsynSocketClient(MessageSwich);
            txb_ip.Text = asynSocketClient.GetLocalIpv4Adress().ToString();
        }

        private void MessageSwich(SendType st, string msg)
        {
            switch (st)
            {
                case SendType.error:
                    AddThread(rtb_recive , msg + "\r\n");
                    break;
                case SendType.addSocket:
                    //AddClient(lv_client, msg);
                    break;
                case SendType.message:
                    AddThread(rtb_recive, msg + "\r\n");
                    break;
                case SendType.file:
                    break;
                default:
                    break;
            }
        }

        private void AddThread(RichTextBox txb, string str)
        {
            txb.Invoke(new Action(() => {
                txb.Text = str + "\r\n" + txb.Text;
            }));
        }

        private void AddClient(ListView lv, string client)
        {
           
        }

        private void tbtn_conn_Click(object sender, EventArgs e)
        {
            int port = int.Parse(nud.Value.ToString());
            asynSocketClient.AsynConncet(txb_ip.Text, port);
        }

        private void mbtn_sendmsg_Click(object sender, EventArgs e)
        {
            //asynSocketClient.AsynSend(rtb_send.Text, 1);
            FileByte fileByte = new FileByte();
            string path = "C:\\gitweb\\abc.rar";
            fileByte.WriteFile(path, bytelist);


        }

        private void lbl_path_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\360极速浏览器下载";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txb_filepath.Text = ofd.FileName;
            }
        }

        private List<byte[]> bytelist = new List<byte[]>();

        private void mbtn_filesend_Click(object sender, EventArgs e)
        {
            //asynSocketClient.AsynSend(rtb_send.Text, 1, null);
            //asynSocketClient.AsynSend("发送文件", 3, txb_filepath.Text);
            //asynSocketClient.AsynSend(txb_filepath.Text, 2);
            FileByte fileByte = new FileByte();
            bytelist = fileByte.ReadFilebyte(txb_filepath.Text);
            int div = bytelist.Count;
            rtb_send.Text = div + "";

        }
    }
}
