using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace AsyncSocketHelper
{
    public  class BaseTools 
    {
        public static string GetLocalIpv4Adress()
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

        private static int bufferSize = 2 * 1024 * 1024;

        public static List<byte[]> ReadFilebyte(string path)
        {
            List<byte[]> listbyte = new List<byte[]>();
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                long size = fs.Length;
                byte[] array = new byte[size];
                int length = fs.Read(array, 0, array.Length);
                int divided = length / bufferSize;
                int remainder = length % bufferSize;

                for (int i = 0; i < divided; i++)
                {
                    byte[] inter_byte = new byte[bufferSize];
                    for (int j = 0; j < bufferSize; j++)
                    {
                        inter_byte[j] = array[(bufferSize * i) + j];
                    }
                    listbyte.Add(inter_byte);
                }

                if (remainder > 0)
                {
                    byte[] inter_byte = new byte[remainder];
                    for (int i = 0; i < remainder; i++)
                    {
                        inter_byte[i] = array[(bufferSize * (divided)) + i];
                    }
                    listbyte.Add(inter_byte);
                }
                return listbyte;
            }

        }

        public static void WriteFile(string path, List<byte[]> fileStream)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                int size = 0;
                foreach (byte[] bt in fileStream)
                {
                    size += bt.Length;
                }
                byte[] file = new byte[size];

                foreach (byte[] bt in fileStream)
                {
                    file = file.Concat(bt).ToArray();
                }

                fs.Write(file, 0, size);
            }


        }
    }
}
