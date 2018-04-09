using KIM.SocketServer.AsynSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace KIM.SocketServer.SocketClass
{
    public class AsyncServer
    {
        public delegate void DelSocketMsg(SendType msgtye, string msg);

        private DelSocketMsg delSocketMsg;

        private Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();
        private Dictionary<string, Session> SessionPool = new Dictionary<string, Session>();

        public const int SendBufferSize = 2 * 1024;
        public const int ReceiveBufferSize = 8 * 1024;

        public AsyncServer(DelSocketMsg dsm)
        {
            delSocketMsg = dsm;
        }

        public void start(string ip, int port)
        {
            Socket sockeServer = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            sockeServer.Bind(new IPEndPoint(IPAddress.Parse(ip) ,port));
            sockeServer.Listen(20);
            sockeServer.BeginAccept(new AsyncCallback(Accept),sockeServer);
            delSocketMsg(SendType.message, "服务已启动");
        }

        private void Accept(IAsyncResult ar)
        {
            Socket socketServer = (Socket)ar.AsyncState;
            Socket socketClient = socketServer.EndAccept(ar);
            byte[] buffer = new byte[4096];
            try
            {
                socketClient.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(Recieve), socketClient);
                Session session = new Session();
                session.SockeClient = socketClient;

                session.IP = socketClient.RemoteEndPoint.ToString();
                session.buffer = buffer;
                lock (SessionPool)
                {
                    if (SessionPool.ContainsKey(session.IP))
                    {
                        SessionPool.Remove(session.IP);
                    }
                    SessionPool.Add(session.IP,session);
                }
                socketServer.BeginAccept(new AsyncCallback(Accept), socketServer);
                string msg = string.Format("客户端：{0} 已连接",session.IP);

                delSocketMsg(SendType.message,msg);
                delSocketMsg(SendType.addSocket,session.IP);
            }
            catch (Exception e)
            {
                delSocketMsg(SendType.error, "错误：" + e.Message);
            }


        }

        private void Recieve(IAsyncResult ar)
        {
            Socket socketClient = (Socket)ar.AsyncState;
            string IP = socketClient.RemoteEndPoint.ToString();
            if (socketClient == null || !SessionPool.ContainsKey(IP)) return;
            try
            {
                int length = socketClient.EndReceive(ar);
                byte[] buffer = SessionPool[IP].buffer;
                if (length > 0) 
                {
                     socketClient.BeginReceive(buffer,0,buffer.Length,SocketFlags.None ,new AsyncCallback(Recieve),socketClient);
                    //传输字符串,以后扩展文件、命令字节替换数据(分包、粘包处理)
                    //string msg = Encoding.UTF8.GetString(buffer, 0, length);
                     string msg = Encoding.Default.GetString(buffer,0,length);

                    delSocketMsg(SendType.message, IP+"发送:"+msg);
                }
                else
                {
                    delSocketMsg(SendType.message, IP + "连接失效");
                    delSocketMsg(SendType.removeSocket, IP );
                }
               
            }
            catch (Exception e)
            {
                if (socketClient != null) socketClient.Disconnect(true);
                SessionPool.Remove(IP);
                delSocketMsg(SendType.message, IP + "连接失效:" + e.Message);
                delSocketMsg(SendType.removeSocket, IP);
            }
        }

        public void Send(List<string> IPlist,string msg)
        {
           
            byte[] msgBuffer = Encoding.UTF8.GetBytes(msg);
            foreach (var IP in IPlist)
            {
                if (SessionPool.ContainsKey(IP))
                {
                    Socket socketClient = SessionPool[IP].SockeClient;
                
                    if (socketClient != null)
                    {
                        socketClient.Send(msgBuffer);
                        delSocketMsg(SendType.message, "服务端向 " + IP + " " + msg);
                    }
                }
            }
           
        }

        public string GetLocalIpv4Adress()
        {
            IPAddress localIPv4 = null;
            IPAddress[] ipAddressList = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in ipAddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIPv4 = ip;
                }
            }
            return localIPv4.ToString();
        }

    }
}
