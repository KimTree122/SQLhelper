using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KNDBsys.Common.TestTools
{
    public class ThreadTask
    {
        public string ThreadTest()
        {
            string str = "";
            str += "1";
            var name = Task.Run(()=> {
               
                str += "2";
                return "test";
            });
            name.Wait(5000);
            str += "3";
            str += "4"+name.Result;
            return str;
        }

        public SemaphoreSlim slim = new SemaphoreSlim(10);//线程队列

        public string Algorithm(List<int> orglist)
        {
            for (int i = 0; i < orglist.Count-1; i++)
            {
                int k = i;
                for (int j = k+1 ; j < orglist.Count; j++)
                {
                    if (orglist[j]<orglist[k])
                    {
                        k = j;
                    }
                }

                if (i!=k)
                {
                    int temp = orglist[i];
                    orglist[i] = orglist[k];
                    orglist[k] = temp;
                }
            }
            string str = "";
            for (int i = 0; i < orglist.Count; i++)
            {
                str += orglist[i].ToString();
            }

            return str;
        }

    }

}
