using System.Web.Mvc;

namespace KNDBsys.WebUI.Areas.PorjectTest
{
    public class PorjectTestAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "PorjectTest";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "PorjectTest_default",
                "PorjectTest/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}