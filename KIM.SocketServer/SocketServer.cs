using DevComponents.DotNetBar;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace KIM.SocketServer
{
    public partial class SocketServer : MetroForm
    {

        private SocketService socketService;

        public SocketServer()
        {
            InitializeComponent();
        }

        private void SocketServer_Load(object sender, EventArgs e)
        {
            InitSocket();
            IntiControl();
        }

        private void IntiControl()
        {

        }

        private void InitSocket()
        {
            socketService = new SocketService(MessageSwich);
           
        }

        private void MessageSwich(SendType st, string msg) 
        {
            switch (st)
            {
                case SendType.error:
                    AddThread(rtb_dataswich ,msg + "\r\n");
                    break;
                case SendType.addSocket:
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

            lv.Invoke(new Action(() => {
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
            }));

        }

        private void AddThread(RichTextBox txb ,string str)
        {

            txb.Invoke(new Action(() => {
                txb.Text += str;
            }));
        }


        private void tbtn_start_Click(object sender, EventArgs e)
        {
            int port =int.Parse( nud.Value.ToString());
            socketService.StartSocket(port);
        }

        private void tbtn_end_Click(object sender, EventArgs e)
        {
            socketService.DisConnectSocket();
        }

        private void tbtn_send_Click(object sender, EventArgs e)
        {
            List<string> strlist = new List<string>();
            foreach (ListViewItem item in lv_client.Items)
            {
                if (item.Checked)
                {
                    string ip = "IP:" + item.SubItems[1].Text + "Port:" + item.SubItems[2].Text;
                    strlist.Add(ip);
                }
            }

            socketService.SeverSendMsg(strlist, rtxb_send.Text);
        }

    }
}
