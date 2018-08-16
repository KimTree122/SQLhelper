using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsyncSocketHelper
{
    public interface ISocketFront
    {
        void InitSocket();
        void StartSocket(string IP, int port);
        void SocketMsgRecieve(SendType sendType, string msg);
        void ClientRemove(string IP);
        void ClientAdd(string IP);
        void SendMsg(string IP, string msg);
        void SendFile(string IP, string path);
        void SetFileDictory();
    }
}
