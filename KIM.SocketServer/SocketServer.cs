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
    public partial class SocketServer : Form
    {
        public SocketServer()
        {
            InitializeComponent();
        }

        private void SocketServer_Load(object sender, EventArgs e)
        {
            InitSocket();
        }

        private void InitSocket()
        {
           
        }

       
    }
}
