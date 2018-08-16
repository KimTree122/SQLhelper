using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsyncSocketHelper
{
    public interface IAsyncSocketServer
    {
        void StartServer(string ip, int port);
        void AcceptClient(IAsyncResult async);
        void Recieve(IAsyncResult async);
        void SendFile(string IP, string path);
        void SendMsg(string IP, string msg);
    }
}
