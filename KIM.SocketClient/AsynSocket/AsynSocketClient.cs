﻿using KIM.SocketClient.SocketClass;
using System;
using System.Collections.Generic;
using System.IO;
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


        public void AsynSend(string msg , int sendtype)
        {
            if (socket == null || string.IsNullOrWhiteSpace(msg)) return;
            switch (sendtype)
            {
                case 0:
                    break;
                case 1:

                    SendMessage(msg);
                    break;
                case 2:
                    string fileName = Path.GetFileName(msg);
                    SendMessage("发送文件:"+ fileName);
                    byte[] file = SendFile(msg);
                    PriAsynSend(fileName, file);
                    break;

                default:
                    break;
            }

        }

        private void SendMessage(string msg)
        {
            byte[] data = Encoding.UTF8.GetBytes(msg);
            byte[] sendbyte = new byte[data.Length + 1];
            sendbyte[0] = 1;
            Buffer.BlockCopy(data, 0, sendbyte, 1, data.Length);
            PriAsynSend(msg, sendbyte);
        }

        private void PriAsynSend(string msg,  byte[] date)
        {
            try
            {
                socket.BeginSend(date, 0, date.Length, SocketFlags.None, asynResult =>
                {
                    int length = socket.EndSend(asynResult);
                    
                }, null);
                socketShow(SendType.message, "发送成功:" + msg);
            }
            catch (Exception e)
            {
                socketShow(SendType.error, "发送失败" + e.Message);
            }
        }

        public byte[] SendFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                byte[] arrFile = new byte[1024*1024 * 5];
                int length = fs.Read(arrFile, 0, arrFile.Length);    
                byte[] arrFileSend = new byte[length + 1];
                arrFileSend[0] = 2;  
                Buffer.BlockCopy(arrFile, 0, arrFileSend, 1, length);
                return arrFileSend;
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
                    socketShow(SendType.message, Encoding.UTF8.GetString(data,0, length));
                    AsynRecieve();
                }
                catch (Exception e)
                {
                    socketShow(SendType.error, "连接失效:" + e.Message);
                    socket = null;
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
