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
            asynSocketClient.AsynSend(rtb_send.Text);
        }


    }
}
