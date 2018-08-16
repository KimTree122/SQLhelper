using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace AsyncSocketHelper
{
    public class Session
    {
        public string IP { get; set; }
        public Socket socket { get; set; }
        public byte[] buffer { get; set; }
    }
}
