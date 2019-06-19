using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KNDBsys.WebUI.Areas.PorjectTest.Controllers
{
    public class WebSocketController : Controller
    {
        // GET: PorjectTest/WebSocket
        public ActionResult Index() => View();

        public ActionResult WebSocketTest() => View();

    }
}