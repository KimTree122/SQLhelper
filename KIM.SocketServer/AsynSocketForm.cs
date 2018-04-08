using KIM.SocketServer.AsynSocket;
using KIM.SocketServer.SocketClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KIM.SocketServer
{
    public partial class AsynSocketForm : Form
    {
        public AsynSocketForm()
        {
            InitializeComponent();
        }

        private AsyncTCPServer asyncTCPSocket;
        private AsyncSocket asyncSocket;
        private AsyncServer asyncServer;

        private void AsynSocketForm_Load(object sender, EventArgs e)
        {
            InitSocket();
        }

        private void InitSocket()
        {
            //asyncTCPSocket = new AsyncTCPServer(MessageSwich);
            //asyncSocket = new AsyncSocket(MessageSwich);
            asyncServer = new AsyncServer(MessageSwich);
            txb_ip.Text = asyncServer.GetLocalIpv4Adress();

        }

        private void MessageSwich(SendType st, string msg)
        {
            switch (st)
            {
                case SendType.error:
                    AddThread(rtb_dataswich, msg + "\r\n");
                    break;
                case SendType.stauts:
                    AddClient(lv_client, msg);
                    break;
                case SendType.message:
                    AddThread(rtb_dataswich, msg + "\r\n");
                    break;
                case SendType.file:
                    break;
                default:
                    break;
            }
        }

        private void AddClient(ListView lv, string client)
        {

            lv.Invoke(new Action(() =>
            {
                string[] s = client.Split(':');
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
            }));

        }

        private void AddThread(RichTextBox txb, string str)
        {

            txb.Invoke(new Action(() =>
            {
                txb.Text = str+"\r\n"+ txb.Text;
            }));
        }

        private void tbtn_start_Click(object sender, EventArgs e)
        {
             int port =int.Parse( nud.Value.ToString());
             //asyncTCPSocket.Start(port);
             //asyncSocket.start(port);
             asyncServer.start(txb_ip.Text, port);

        }

        private void tbtn_send_Click(object sender, EventArgs e)
        {
            List<string> strlist = new List<string>();
            foreach (ListViewItem item in lv_client.Items)
            {
                if (item.Checked)
                {
                    string ip =  item.SubItems[1].Text + ":" + item.SubItems[2].Text;
                    strlist.Add(ip);
                }
            }
            asyncServer.Send(strlist, rtxb_send.Text);
        }


    }
}
