using CS.BLL.BaseInfo;
using KNDBsys.Model.BaseInfo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KNDBsys.WebUI.Areas.PorjectTest.Controllers
{
    public class ViewLayoutController : Controller
    {
        // GET: PorjectTest/ViewLayout

        private AuthorityService authority = new AuthorityService();

        public ActionResult Index()
        {
            return View();
        }

        public string SearchData(string keyword)
        {
            List<string> strls = new List<string>
            {
                "AABB",
                "BBCC",
                "CCDD",
                "DDAA",
                "GGEE"
            };

            List<Authority> authorities = authority.GetAuthorities(1);


            List<string> ls = new List<string>();

            foreach (var au in authorities)
            {
                ls.Add(au.TreeName+","+au.id);
            }

            string strreturn = JsonConvert.SerializeObject(ls);

            return strreturn;
        }

        public ActionResult ChartTest()
        {
            return View();
        }

        public ActionResult AngularView()
        {
            return View();
        }

        public string AngularHttp()
        {
            string str = "CN,EN,JP";
            return str;
        }

        public ActionResult VueTest()
        {
            return View();
        }

    }
}