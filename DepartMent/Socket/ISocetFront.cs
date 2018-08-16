using AsyncSocketHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartMent.Socket
{
    public interface ISocetFront
    {
        void ShowData(SendType sendType, string msg);
    }
}
