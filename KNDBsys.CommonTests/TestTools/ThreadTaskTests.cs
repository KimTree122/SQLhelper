using Microsoft.VisualStudio.TestTools.UnitTesting;
using KNDBsys.Common.TestTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNDBsys.Common.TestTools.Tests
{
    [TestClass()]
    public class ThreadTaskTests
    {
        [TestMethod()]
        public void ThreadTestTest()
        {
            ThreadTask threadTask = new ThreadTask();
            string str = threadTask.ThreadTest();

            Assert.AreEqual(str, "1234test");
        }

        [TestMethod()]
        public void AlgorithmTest()
        {
            ThreadTask task = new ThreadTask();
            List<int> org = new List<int>();
            org.Add(2);
            org.Add(3);
            org.Add(7);
            org.Add(1);
            org.Add(4);

            string str = task.Algorithm(org);


            Assert.AreEqual("12347",str);
        }
    }
}