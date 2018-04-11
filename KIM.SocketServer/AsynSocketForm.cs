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

        private AsyncServer asyncServer;
        private List<string> socketItems = new List<string>();


        private void AsynSocketForm_Load(object sender, EventArgs e)
        {
            InitSocket();
        }

        private void InitSocket()
        {
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
                case SendType.addSocket:
                    AddClient(lv_client, msg);
                    break;
                case SendType.message:
                    AddThread(rtb_dataswich, msg + "\r\n");
                    break;
                case SendType.removeSocket:
                    RemoveClient(lv_client, msg);
                    break;
                case SendType.file:
                    break;
                default:
                    break;
            }
        }

        private void RemoveClient(ListView lv, string msg)
        {
            lv.Invoke(new Action(() => {
                string[] ips = msg.Split(':');
                foreach (ListViewItem lvi in lv.Items)
                {
                    if (lvi.SubItems[1].Text == ips[0] & lvi.SubItems[2].Text == ips[1])
                    {
                        lv.Items.Remove(lvi);
                    }
                }
                for (int i = 0; i < lv.Items.Count; i++)
                {
                    lv.Items[i].Text = i + 1 + "";
                }
            }));
           
        }

        private void AddClient(ListView lv, string client)
        {

            lv.Invoke(new Action(() =>
            {
                string[] s = client.Split(':');
                string itcount = lv.Items.Count + 1 + "";

                ListViewItem lvi = new ListViewItem(itcount);

                lvi.ImageIndex = lv.Items.Count % 2;

                ListViewItem.ListViewSubItem lvsiip = new ListViewItem.ListViewSubItem();
                lvsiip.Text = s[0];
                ListViewItem.ListViewSubItem lvsiport = new ListViewItem.ListViewSubItem();
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
             asyncServer.Start(txb_ip.Text, port);
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
