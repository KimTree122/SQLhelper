using AsyncSocketHelper;
using DepartMent.Socket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartMent
{
    public partial class SocketTest : Form,ISocketFront
    {
        public SocketTest()
        {
            InitializeComponent();
        }

        //private SocketServer socketServer;

        private void SocketTest_Load(object sender, EventArgs e)
        {
           
        }

        public void InitSocket()
        {
            throw new NotImplementedException();
        }

        public void SocketMsgRecieve(SendType sendType, string msg)
        {
            throw new NotImplementedException();
        }

        public void ClientRemove(string IP)
        {
            throw new NotImplementedException();
        }

        public void ClientAdd(string IP)
        {
            throw new NotImplementedException();
        }

        public void StartSocket(string IP, int port)
        {
            throw new NotImplementedException();
        }

        public void SendMsg(string IP, string msg)
        {
            throw new NotImplementedException();
        }

        public void SendFile(string IP, string path)
        {
            throw new NotImplementedException();
        }

        public void SetFileDictory()
        {
            throw new NotImplementedException();
        }
    }
}
