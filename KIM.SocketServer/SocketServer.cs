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
        private delegate void Lv_Recive(ListView lv, string message);
        private delegate void RTxb_Recive(RichTextBox t , string msg);




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
            if (lv.InvokeRequired)
            {
                Lv_Recive ms = new Lv_Recive(AddClient);
                this.Invoke(ms,new object[]{lv, client});
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

        private void AddThread(RichTextBox txb ,string str)
        {
            if (txb.InvokeRequired)
            {
                RTxb_Recive ms = new RTxb_Recive(AddThread);
                this.Invoke(ms, new object[] {txb, str });
            }
            else
            {
               txb.Text += str;
            }
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

    }
}
