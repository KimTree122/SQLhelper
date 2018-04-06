using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace KIM.SocketClient.SocketClass
{
    public class SocketClientServer
    {
        public delegate void delMessage(SendType msgtype, string msg);

        private delMessage delsendMessage;

        private string filePath = null;
        private string fileName = null;

        public SocketClientServer(delMessage delmsg)
        {
            delsendMessage = delmsg;
        }

        private Socket socketClient = null;
        private Thread threadClient = null;

        public const int SendBufferSize = 2 * 1024;
        public const int ReceiveBufferSize = 8 * 1024;

        public void ConncetToServer(string Ipaddress,int port)
        {
            socketClient = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

            IPAddress serverIPAddress = IPAddress.Parse(Ipaddress);
            IPEndPoint endpoint = new IPEndPoint(serverIPAddress, port);

            socketClient.Connect(endpoint);

            threadClient = new Thread(RecMsg);
            threadClient.IsBackground = true;
            threadClient.Start();
            delsendMessage(SendType.message, "已连接服务器");

        }

        private void RecMsg()
        {
            while (true)
            {
                string strRecMsg = null;
                int length = 0;
                byte[] buffer = new byte[SendBufferSize];
                try
                {
                    length = socketClient.Receive(buffer);
                }
                catch(SocketException ex)
                {
                    delsendMessage(SendType.error,ex.Message+"\r\n");
                }
                catch (Exception ex)
                {
                    delsendMessage(SendType.error, ex.Message+"\r\n");
                    break;
                }
                strRecMsg = Encoding.UTF8.GetString(buffer,0,length);
                delsendMessage(SendType.message,strRecMsg+"\r\n");
            }
        }

        public void ClientSendMsg(string sendMsg, byte symbol)
        {
            byte[] arrClientMsg = Encoding.UTF8.GetBytes(sendMsg);
            byte[] arrClientSendMsg = new byte[arrClientMsg.Length + 1];
            arrClientSendMsg[0] = symbol;
            Buffer.BlockCopy(arrClientMsg, 0, arrClientSendMsg, 1, arrClientMsg.Length);
            socketClient.Send(arrClientSendMsg);
            delsendMessage(SendType.message,"已发送：" + sendMsg+"\r\n");

        }

        private void sendFile(string fileFullPath) 
        {
            if (string.IsNullOrWhiteSpace(fileFullPath)) return;

            long fileLength = new FileInfo(fileFullPath).Length;
            string totalMsg = string.Format("{0}-{1}",fileName,filePath);
            ClientSendMsg(totalMsg, 2);

            byte[] buffer = new byte[SendBufferSize];
            using (FileStream fs = new FileStream(fileFullPath,FileMode.Open,FileAccess.Read))
            {
                int readLength = 0;
                bool firstRead = true;
                long sentFileLength = 0;
                while ((readLength = fs.Read(buffer,0,buffer.Length)) > 0 && sentFileLength < fileLength)
                {
                    sentFileLength += readLength;
                    if (firstRead)
                    {
                        byte[] firstBuffer = new byte[readLength + 1];
                        firstBuffer[0] = 1;
                        Buffer.BlockCopy(buffer,0,firstBuffer,1,readLength);
                        socketClient.Send(firstBuffer, 0, readLength + 1, SocketFlags.None);
                        firstRead = false;
                        continue;
                    }
                    socketClient.Send(buffer,0,readLength,SocketFlags.None);
                }
                fs.Close();
            }
            delsendMessage(SendType.file, "发送文件");

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
