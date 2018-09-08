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
        public ActionResult Index()
        {
            return View();
        }

        public string SearchData(string keyword)
        {
            List<string> strls = new List<string>();
            strls.Add("AABB");
            strls.Add("BBCC");
            strls.Add("CCDD");
            strls.Add("DDAA");
            strls.Add("GGEE");

            List<string> ls = new List<string>();
            foreach (var str in strls)
            {
                if (str.ToLower().Contains(keyword.ToLower()))
                {
                    ls.Add(str);
                }
            }

            string strreturn = JsonConvert.SerializeObject(ls);

            return strreturn;
        }

    }
}