using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace KNDBsys.Common.StreamHelper
{
    public class StreamHelper
    {
        /// <summary>
        /// 1、将 Stream 转成 byte[]
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static byte[] StreamToBytes(Stream stream)
        {
            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            // 设置当前流的位置为流的开始
            stream.Seek(0, SeekOrigin.Begin);
            return bytes;
        }

        /// <summary>
        /// 2、将 byte[] 转成 Stream
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static Stream BytesToStream(byte[] bytes)
        {
            Stream stream = new MemoryStream(bytes);
            return stream;
        }

        // <summary> 
        /// 3、字节流转换成图片 
        /// </summary> 
        /// <param name="byt">要转换的字节流</param> 
        /// <returns>转换得到的Image对象</returns> 
        public static Image BytToImg(byte[] byt)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byt);
                Image img = Image.FromStream(ms);
                return img;
            }
            catch (Exception ex)
            {
                //LogHelper.WriteError("StreamHelper.BytToImg 异常", ex);
                return null;
            }
        }

        /// <summary>
        /// 5、把图片Url转化成Image对象
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <returns></returns>
        public static Image Url2Img(string imageUrl)
        {
            try
            {
                if (string.IsNullOrEmpty(imageUrl))
                {
                    return null;
                }

                WebRequest webreq = WebRequest.Create(imageUrl);
                WebResponse webres = webreq.GetResponse();
                Stream stream = webres.GetResponseStream();
                Image image;
                image = Image.FromStream(stream);
                stream.Close();

                return image;
            }
            catch (Exception ex)
            {
                //LogHelper.WriteError("StreamHelper.Url2Img 异常", ex);
            }

            return null;
        }

        /// <summary>
        /// 6、把本地图片路径转成Image对象
        /// </summary>
        /// <param name="imagePath"></param>
        /// <returns></returns>
        public static Image ImagePath2Img(string imagePath)
        {
            try
            {
                if (string.IsNullOrEmpty(imagePath))
                {
                    return null;
                }

                byte[] bytes = ImageToBytes(imagePath);
                Image image = BytToImg(bytes);
                return image;
            }
            catch (Exception )
            {
                return null;
            }
        }



        public static byte[] ImageToBytes(string path)
        {

            Image image = Image.FromFile(path);

            ImageFormat format = image.RawFormat;
            using (MemoryStream ms = new MemoryStream())
            {
                if (format.Equals(ImageFormat.Jpeg))
                {
                    image.Save(ms, ImageFormat.Jpeg);
                }
                else if (format.Equals(ImageFormat.Png))
                {
                    image.Save(ms, ImageFormat.Png);
                }
                else if (format.Equals(ImageFormat.Bmp))
                {
                    image.Save(ms, ImageFormat.Bmp);
                }
                else if (format.Equals(ImageFormat.Gif))
                {
                    image.Save(ms, ImageFormat.Gif);
                }
                else if (format.Equals(ImageFormat.Icon))
                {
                    image.Save(ms, ImageFormat.Icon);
                }
                byte[] buffer = new byte[ms.Length];
                //Image.Save()会改变MemoryStream的Position，需要重新Seek到Begin
                ms.Seek(0, SeekOrigin.Begin);
                ms.Read(buffer, 0, buffer.Length);
                return buffer;
            }
        }
    }
}
