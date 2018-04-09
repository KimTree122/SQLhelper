using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KIM.SocketServer
{
    public enum SendType
	{
        error = 0,
        message = 1,
        file = 2,
        addSocket = 3,
        removeSocket = 4,
	} 
}
