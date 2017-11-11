using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThread.ThreadClass
{
    public class ThreadSafe
    {
        static object locker = new object();
        static int x;
        static void Increment() { lock (locker) x++; }
        static void Assign() { lock (locker) x = 123; }
    }
}
