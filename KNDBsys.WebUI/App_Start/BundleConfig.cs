using System.Web;
using System.Web.Optimization;

namespace KNDBsys.WebUI
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js", "~/Scripts/jquery.cookie.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            //easyui_js
            bundles.Add(new ScriptBundle("~/bundles/easyuijs").Include(
                        "~/Scripts/jquery.easyui.min.js", "~/Scripts/jquery.easyui.mobile.js"));
            //easyui_css
            bundles.Add(new StyleBundle("~/Content/easyuicss").Include(
                      "~/Content/themes/default/easyui.css",
                      "~/Content/themes/icon.css", "~/Content/themes/mobile.css"));
            //jqueryui_js
            bundles.Add(new ScriptBundle("~/bundles/jqueryuijs").Include("~/Scripts/jquery-ui.js"));
            //jqueryui_css
            bundles.Add(new StyleBundle("~/Content/jqueryuicss").Include("~/Content/jquery-ui.css"));

            //chart.js
            bundles.Add(new ScriptBundle("~/bundles/chartjs").Include("~/Scripts/chart.js/Chart.bundle.js", "~/Scripts/chart.js/Chart.js", "~/Scripts/chart.js/utils.js"));


            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/AngularJS").Include(
                      "~/Scripts/angular.min.js"));

        }
    }
}
