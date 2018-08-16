using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsyncSocketHelper
{
    public interface IAsyncSocketClient
    {
        void ConnectServer(string ip,int port);
        void SendMsg(string msg);
        void SendFile(string path);
        void Recieve();
        
    }
}
