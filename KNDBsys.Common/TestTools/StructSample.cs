using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNDBsys.Common.TestTools
{
    public  struct StructSample
    {
        public int X;
        public int Y;
        
        public  StructSample(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static StructSample operator +(StructSample s1, StructSample s2)
        {

            return new StructSample(s1.X + s2.X, s1.Y + s2.Y);
        }

        public static implicit operator int(StructSample ss)
        {
            return (int)(ss.X + ss.Y);
        }

        public override string ToString()
        {
            return ($"({X},{Y})");
        }
    }

    public  class StructTest
    {
        

        public void MyTest()
        {
            StructSample ss1 = new StructSample(1, 2);
            StructSample ss2 = new StructSample(2, 3);


            int count = ss1 + ss2;
        }

        

    }

}
