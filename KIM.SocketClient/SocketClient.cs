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

        private SocketClientServer sockClientServer;
        private delegate void Lv_Recive(ListView lv, string message);
        private delegate void RTxb_Recive(RichTextBox t, string msg);

        private void SocketClient_Load(object sender, EventArgs e)
        {
            sockClientServer = new SocketClientServer(MessageSwich);
            txb_ip.Text = sockClientServer.GetLocalIpv4Adress().ToString();
        }

        private void MessageSwich(SendType st, string msg)
        {
            switch (st)
            {
                case SendType.error:
                    AddThread(rtb_recive , msg + "\r\n");
                    break;
                case SendType.stauts:
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
            if (txb.InvokeRequired)
            {
                RTxb_Recive ms = new RTxb_Recive(AddThread);
                this.Invoke(ms, new object[] { txb, str });
            }
            else
            {
                txb.Text += str;
            }
        }

        private void AddClient(ListView lv, string client)
        {
            if (lv.InvokeRequired)
            {
                Lv_Recive ms = new Lv_Recive(AddClient);
                this.Invoke(ms, new object[] { lv, client });
            }
            else
            {
                string[] s = client.Split(',');
                string itcount = lv.Items.Count + 1 + "";

                ListViewItem lvi = new ListViewItem(itcount);

                lvi.ImageIndex = 1;

                System.Windows.Forms.ListViewItem.ListViewSubItem lvsiip = new ListViewItem.ListViewSubItem();
                lvsiip.Text = s[0];
                System.Windows.Forms.ListViewItem.ListViewSubItem lvsiport = new ListViewItem.ListViewSubItem();
                lvsiport.Text = s[1];

                lvi.SubItems.Add(lvsiip);
                lvi.SubItems.Add(lvsiport);


                lv.Items.Add(lvi);
            }
        }

        private void tbtn_conn_Click(object sender, EventArgs e)
        {
            int port = int.Parse(nud.Value.ToString());
            sockClientServer.ConncetToServer(txb_ip.Text,port);
        }

        private void mbtn_sendmsg_Click(object sender, EventArgs e)
        {
            sockClientServer.ClientSendMsg(rtb_send.Text, 0);
        }


    }
}
