using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace KIM.SocketServer.AsynSocket
{
    public class AsyncTCPServer
    {
        public delegate void delMessage(SendType msgtype, string msg);

        private delMessage delsendMessage;

        public AsyncTCPServer(delMessage dm)
        {
            delsendMessage = dm;
        }


        public void Start( int Port )
        {
            //创建套接字  
            IPEndPoint ipe = new IPEndPoint(GetLocalIpv4Adress(), Port);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //绑定端口和IP  
            socket.Bind(ipe);
            //设置监听  
            socket.Listen(10);
            //连接客户端  
            AsyncAccept(socket);
            delsendMessage(SendType.message,"服务已启动");
        }

        /// <summary>  
        /// 连接到客户端  
        /// </summary>  
        /// <param name="socket"></param>  
        private void AsyncAccept(Socket socket)
        {
            socket.BeginAccept(asyncResult =>
            {
                //获取客户端套接字  
                Socket client = socket.EndAccept(asyncResult);
                string msg = string.Format("客户端{0}请求连接...", client.RemoteEndPoint);
                //Console.WriteLine(string.Format("客户端{0}请求连接...", client.RemoteEndPoint));
                delsendMessage(SendType.message,msg);
                AsyncSend(client, "服务器收到连接请求");
                AsyncSend(client, string.Format("欢迎你{0}", client.RemoteEndPoint));
                AsyncReveive(client);
            }, null);
        }

        /// <summary>  
        /// 接收消息  
        /// </summary>  
        /// <param name="client"></param>  
        private void AsyncReveive(Socket socket)
        {
            byte[] data = new byte[1024];
            while (true)
            {
                try
                {
                    //开始接收消息  
                    socket.BeginReceive(data, 0, data.Length, SocketFlags.None,
                    asyncResult =>
                    {
                        int length = socket.EndReceive(asyncResult);
                        //Console.WriteLine(string.Format("客户端发送消息:{0}", Encoding.UTF8.GetString(data)));

                        string msg = string.Format("客户端发送消息:{0}", Encoding.UTF8.GetString(data));
                        delsendMessage(SendType.message, msg);

                    }, null);
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    delsendMessage(SendType.message, ex.Message);
                    break;
                }
            }
           
        }

        /// <summary>  
        /// 发送消息  
        /// </summary>  
        /// <param name="client"></param>  
        /// <param name="p"></param>  
        private void AsyncSend(Socket client, string p)
        {
            if (client == null || p == string.Empty) return;
            //数据转码  
            byte[] data = new byte[1024];
            data = Encoding.UTF8.GetBytes(p);
            try
            {
                //开始发送消息  
                client.BeginSend(data, 0, data.Length, SocketFlags.None, asyncResult =>
                {
                    //完成消息发送  
                    int length = client.EndSend(asyncResult);
                    //输出消息  
                    //Console.WriteLine(string.Format("服务器发出消息:{0}", p));
                    delsendMessage(SendType.message, "服务器发出消息:"+ p);
                }, null);
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                delsendMessage(SendType.message, e.Message);
            }
        }


        public IPAddress GetLocalIpv4Adress()
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
            return localIPv4;
        }
    } 
}
