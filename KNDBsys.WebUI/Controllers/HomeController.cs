using KNDBsys.BLL.BaseInfo;
using KNDBsys.Common.VerifyMoudle;
using KNDBsys.Model.BaseInfo;
using KNDBsys.ViewModel.MainView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KNDBsys.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public Verify_Code verify = new Verify_Code();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MainView()
        {
            User_Ser userInfoSer = new User_Ser();

            object id = Session["U@id"];
            if (id == null)
            {
                //return View("Error");
                id = "1";
            }
            Mainmenu mainmenu = userInfoSer.Mainmenu(id.ToString());
            return View(mainmenu);
        }

        public string GetAuthoriy(int userid,string port)
        {
            Authority_Ser authorityData = new Authority_Ser();
            string str = authorityData.GetUserAuthority(userid, port);
            return str;
        }

        public ActionResult Login()
        {
            return View();
        }

        public string CheckAccount(string userid, string pwd, string vcode)
        {
            if (Session["v$code"] == null)
            {
                return "验证码失效";
            }

            if (Session["v$code"].ToString() != vcode)
            {
                Session["v$code"] = null;
                return "验证码错误";
            }
            User_Ser userInfoSer = new User_Ser();
            UserInfo user = userInfoSer.CheckUserAccount(userid,pwd);

            if (user != null)
            {
                Session["U@id"] = user.id;
                return "ok";
            }
            else
            {
                Session["v$code"] = null;
                return "账号密码错误";
            }
        }

        public ActionResult VerifyCode()
        {
            string code = verify.RandCode();
            Session["v$code"] = null;
            Session["v$code"] = code.ToLower();
            return File(verify.CreateImage(code), @"image/jpeg");
        }


    }
}