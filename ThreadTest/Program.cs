using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    public delegate string MyDelegate(object data);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate mydelegate = new
            MyDelegate(TestdelMethod);
            IAsyncResult res = mydelegate.BeginInvoke("Thread param", TestCallBack,"callback param");
            string resstr = mydelegate.EndInvoke(res);
            Console.WriteLine(resstr);
            Console.ReadKey();

        }

        public static void TestCallBack(IAsyncResult data)
        {
            Console.WriteLine(data.AsyncState);
        }

        public static string TestdelMethod(object data)
        {
            string str = data as string;
            return str;
        }

        private static void TaskThread()
        {
            Task<int> t = new Task<int>(m => SumInt((int)m), 999);
            //t.Wait(2000);
            t.Start();

            Task cwt = t.ContinueWith(task => Console.WriteLine("输出：{0}",t.Result));

            //Console.WriteLine(t.Result);
            Console.ReadKey();
        }

        private static int SumInt(int n)
        {
            int sum = 0;
            for (; n > 0; --n)
                checked{ sum += n;}
            return sum;
        }

        private static void ThreadPoolTest()
        {
            ThreadPool.QueueUserWorkItem(TestMethod);
            Console.ReadKey();
        }

        private static void BaseThread()
        {
            Thread t1 = new Thread(new ThreadStart(TestMethod));
            Thread t2 = new Thread(new ParameterizedThreadStart(TestMethod));
            t1.IsBackground = true;
            t2.IsBackground = true;
            t1.Start();
            t2.Start("参数1");
            Console.ReadKey();
        }

        public static void TestMethod()
        {
            Console.WriteLine("不带参数的线程函数");
        }

        public static void TestMethod(object data)
        {
            string str = data as string;
            Console.WriteLine("带参数的线程函数，参数为：{0}",str);
        }

        public static int IntSum(int num)
        {
            if (num < 1 || num > 18) return 0;

            int mul = 1;
            for (int i = num; i <= 1; i--)
            {
                mul += mul * i;
            }

            return 0;
        }

    }
}
