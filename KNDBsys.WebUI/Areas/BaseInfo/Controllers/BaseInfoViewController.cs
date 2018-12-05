using CS.BLL.BaseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KNDBsys.WebUI.Areas.BaseInfo.Controllers
{
    public class BaseInfoViewController : Controller
    {
        // GET: BaseInfo/BaseInfoView
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AuthManage()
        {
            return View();
        }

        public string GetAllAuth(int userid)
        {
            AuthorityService auser = new AuthorityService();
            var authorities = auser.GetAuthorities(userid);

            return "";
        }
    }
}