using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AsyncSocketHelper
{
    public class SwitchData
    {
        public string ReciveMsg(byte[] buffer,int length)
        {
            return Encoding.UTF8.GetString(buffer, 1, length - 1);
        }

        public void ReciveFile(byte[] filebuffer, string path)
        {
            string fileName = Path.GetFileName(path);
            string extension = Path.GetExtension(path);
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {

            }
        }

        public byte[] SendMsg(string msg)
        {
            return Encoding.UTF8.GetBytes(msg);
        }

        public List<byte[]> SendFile(string path)
        {
            return BaseTools.ReadFilebyte(path);
        }
    }
}
