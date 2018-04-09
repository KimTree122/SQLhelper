using KIM.SocketClient.SocketClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace KIM.SocketClient.AsynSocket
{
    public class AsynSocketClient
    {
        public delegate void SocketShow(SendType sendType, string msg);
        private SocketShow socketShow;
        private Socket socket;

        public AsynSocketClient(SocketShow show)
        {
            socketShow = show;
        }


        public void AsynConncet(string IP, int port)
        {
            if (socket != null) return;

            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(IP), port);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.BeginConnect(iPEndPoint, asyncResult =>
            {
                try
                {
                    socket.EndConnect(asyncResult);
                    AsynRecieve();
                    socketShow(SendType.message, "连接成功");
                }
                catch (Exception e)
                {
                    socketShow(SendType.error, "连接失败:" + e.Message);
                    socket = null;
                }
            }, null);
        }

        public void AsynSend(string msg)
        {
            if (socket == null || string.IsNullOrWhiteSpace(msg)) return;

            byte[] date = Encoding.Default.GetBytes(msg);
            try
            {
                socket.BeginSend(date, 0, date.Length, SocketFlags.None, asynResult =>
                {
                    int length = socket.EndSend(asynResult);
                    socketShow(SendType.message, "向服务端发送:" + msg);
                }, null);
            }
            catch (Exception e)
            {
                socketShow(SendType.error, "发送失败" + e.Message);
            }
        }

        public void AsynRecieve()
        {
            byte[] data = new byte[1024];
            socket.BeginReceive(data, 0, data.Length, SocketFlags.None, asyncResult =>
            {
                try
                {
                    int length = socket.EndReceive(asyncResult);
                    socketShow(SendType.message, Encoding.Default.GetString(data,0, length));
                    AsynRecieve();
                }
                catch (Exception e)
                {
                    socketShow(SendType.error, "接收失败" + e.Message);
                }
            }, null);

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
