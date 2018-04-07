using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace KIM.SocketServer.AsynSocket
{
    public class Session
    {
        public Socket SockeClient { get; set; }
        public byte[] buffer { get; set; }
        public string IP { get; set; }
        public bool isWeb { get; set; }
    }
}
