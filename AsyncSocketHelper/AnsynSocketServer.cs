using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace AsyncSocketHelper
{
    public class AnsynSocketServer : IAsyncSocketServer
    {
        public delegate void DelSocketMsg(SendType send, string msg);

        private DelSocketMsg delSocketMsg;

        private Dictionary<string, Session> SessionPool = new Dictionary<string, Session>();
        private Dictionary<string, FileByte> DownLoad = new Dictionary<string, FileByte>();


        public AnsynSocketServer(DelSocketMsg delSocket)
        {
            delSocketMsg = delSocket;
        }

        public void StartServer(string ip, int port)
        {
            try
            {
                Socket socketServer = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
                socketServer.Bind(new IPEndPoint(IPAddress.Parse(ip),port));
                socketServer.Listen(20);
                socketServer.BeginAccept(new AsyncCallback(AcceptClient),socketServer);
                delSocketMsg(SendType.message, "服务端启动成功");
            }
            catch (Exception e)
            {
                delSocketMsg(SendType.error, "错误:"+e+"port:"+port);
            }
        }

        public void AcceptClient(IAsyncResult async)
        {
            Socket socket = (Socket)async.AsyncState;
            Socket socketclient = socket.EndAccept(async);
            byte[] buffer = new byte[1024*10];
            try
            {
                socketclient.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None
                    , new AsyncCallback(Recieve), socketclient);

                Session session = new Session
                {
                    IP = socketclient.RemoteEndPoint.ToString(),
                    socket = socketclient,
                    buffer = buffer
                };
                lock (SessionPool)
                {
                    if (SessionPool.ContainsKey(session.IP)) SessionPool.Remove(session.IP);
                    SessionPool.Add(session.IP,session);
                }

                socket.BeginAccept(new AsyncCallback(AcceptClient),socket);
                string msg = string.Format("客户端:{0} 已连接",session.IP);
                delSocketMsg(SendType.message,msg);
                delSocketMsg(SendType.addSocket,session.IP);
            }
            catch (Exception e)
            {
                delSocketMsg(SendType.error,"出错："+e.Message);
            }
        }

        public void Recieve(IAsyncResult async)
        {
            Socket socket = (Socket)async.AsyncState;
            string IP = socket.RemoteEndPoint.ToString();
            if (socket == null || !SessionPool.ContainsKey(IP)) return;
            try
            {
                int length = socket.EndReceive(async);

                byte[] buffer = SessionPool[IP].buffer;
                if (length > 0)
                {
                    ReciveDataSwich(buffer,length,IP);
                    socket.BeginReceive(buffer,0,buffer.Length,SocketFlags.None,
                        new AsyncCallback(Recieve),socket);
                }

            }
            catch (Exception e)
            {
                if (socket != null) socket.Disconnect(true);
                SessionPool.Remove(IP);
                delSocketMsg(SendType.message, "连接失效:"+IP + e.Message);
                delSocketMsg(SendType.removeSocket,IP);
            }
        }

        private void ReciveDataSwich(byte[] buffer, int length, string IP)
        {
            int bytetype = buffer[0];
            switch (bytetype)
            {
                case 0:
                    break;
                default:
                    break;
            }

        }

        public void SendFile(string IP, string path)
        {

            Socket sendSocket = SendSocket(IP);
            if (sendSocket == null) return;
            
            sendSocket.BeginSend(null, SocketFlags.None, asy => {
                int length = sendSocket.EndSend(asy); 
            }, null);

        }

        public void SendMsg(string IP, string msg)
        {
            throw new NotImplementedException();
        }

        public Socket SendSocket(string IP)
        {
            if (SessionPool.ContainsKey(IP))
            {
                Socket socket = SessionPool[IP].socket;
                if (socket != null) return socket;
            }
            return null;
        }

    }
}
