using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace KIM.SocketServer
{
    public class SocketService
    {
        public delegate void delMessage(SendType msgtype, string msg);

        private delMessage delsendMessage;

        public SocketService(delMessage delmsg)
        {
            delsendMessage = delmsg;
        }

        private Thread threadWatch = null;
        private Socket socketWatch = null;

        public const int SendBufferSize = 2 * 1024;
        public const int ReceiveBufferSize = 8 * 1024;

        private Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();
        private Socket socConnection = null;
        private string clientName = null;
        private IPAddress clientIP;
        private int clientPort;

        private string strSrecMsg = null;


        public void StartSocket(int Socketport) 
        {
            socketWatch = new Socket(AddressFamily.InterNetwork,SocketType.Stream,
                ProtocolType.Tcp);
            IPAddress ipAddress = GetLocalIpv4Adress();

            IPEndPoint endPoint = new IPEndPoint(ipAddress, Socketport);
            socketWatch.Bind(endPoint);
            socketWatch.Listen(20);

            threadWatch = new Thread(WatchConnecting);
            threadWatch.IsBackground = true;
            threadWatch.Start();
            delsendMessage(SendType.message, "服务已经启动");
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

        private void WatchConnecting() 
        {
            while (true)
            {
                try
                {
                    socConnection = socketWatch.Accept();
                }
                catch (Exception e )
                {
                    delsendMessage(SendType.error, e.Message.ToString());
                    break;
                }

                IPEndPoint ipEndPoint = socConnection.RemoteEndPoint as IPEndPoint;
                clientIP = ipEndPoint.Address;
                clientPort = ipEndPoint.Port;

                clientName = "IP:"+clientIP+"Port:"+clientPort;
                dicSocket.Add(clientName,socConnection);

                ParameterizedThreadStart pts = new
                 ParameterizedThreadStart(ServerRecMsg);
                Thread thread = new Thread(pts);
                thread.Start(socConnection);
                delsendMessage(SendType.stauts, clientIP + "," + clientPort);

            }
        }


        public void SeverSendMsg(List<string> clientNames, string sendMsg)
        {
            byte[] arrSendMsg = Encoding.UTF8.GetBytes(sendMsg);

            foreach (string cN in clientNames)
            {
                dicSocket[cN].Send(arrSendMsg);
                delsendMessage(SendType.message, "服务端发送数据");
            }
        }

        public void DisConnectSocket()
        {
            socketWatch.Dispose();
            //socketWatch.Disconnect(true);
        }


        private void ServerRecMsg(object socketClientPara)
        {
            Socket socketServer = socketClientPara as Socket;
            long fileLength = 0;
            while (true)
            {
                int firstRecived = 0;
                byte[] buffer = new byte[ReceiveBufferSize];
                try
                {
                    if (socketServer != null) firstRecived = socketServer.Receive(buffer);

                    if (firstRecived > 0)
                    {
                        string smsg = Encoding.UTF8.GetString(buffer, 0, firstRecived);

                        if (buffer[0] == 0)
                        {
                            strSrecMsg = Encoding.UTF8.GetString(buffer, 1, firstRecived - 1);
                            delsendMessage(SendType.message, strSrecMsg);
                        }

                        if (buffer[0] == 2)
                        {
                            string fileNameWithLength = Encoding.UTF8.GetString(buffer,1,firstRecived -1);

                            strSrecMsg = fileNameWithLength.Split('-').First();
                            fileLength = Convert.ToInt64(fileNameWithLength.Split('-').Last());
                        }
                        if (buffer[0] == 1)
                        {
                            string fileNameSuffix = strSrecMsg.Substring(strSrecMsg.LastIndexOf('.'));

                            string savePath = "";
                            int received = 0;
                            long receivedTotalFilelength = 0;
                            bool firstWrite = true;
                            using (FileStream fs = new FileStream(savePath,FileMode.Create,FileAccess.Write))
                            {
                                while (receivedTotalFilelength < fileLength)
                                {
                                    if (firstWrite)
                                    {
                                        fs.Write(buffer, 1, firstRecived - 1);
                                        fs.Flush();

                                        receivedTotalFilelength += firstRecived - 1;
                                        firstWrite = false;
                                        continue;
                                    }
                                    received = socketServer.Receive(buffer);
                                    fs.Write(buffer,0,received);
                                    fs.Flush();

                                    receivedTotalFilelength += received;
                                }
                                fs.Close();
                            }

                            delsendMessage(SendType.message, savePath);
                        }
                    }

                }
                catch (Exception e)
                {

                    delsendMessage(0, e.Message);
                    break;
                }

            }

        }

    }
}
