using System.Web;
using System.Web.Optimization;

namespace TTB
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-plugins").Include(
                        "~/Scripts/jquery.slimscroll.js",
                        "~/Scripts/jquery.blockui.min.js",
                        "~/Scripts/jquery.cokie.min.js",
                        "~/Scripts/jquery.uniform.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/twitter-bootstrap-hover-dropdown.js",
                      "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/_bootstrap.min.css",
                      "~/Content/main.css"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                     "~/Scripts/app.js"));

            bundles.Add(new ScriptBundle("~/bundles/login").Include(
                      "~/Scripts/login.js"));

            bundles.Add(new StyleBundle("~/Content/css-global").Include(
                      "~/Content/font-awesome.css",
                      "~/Content/bootstrap.css",
                      "~/Content/Themes/uniformjs/default/css/uniform.default.css"));

            bundles.Add(new StyleBundle("~/Content/css-theme").Include(
                   "~/Content/style-metronic.css",
                   "~/Content/style.css",
                   "~/Content/style-responsive.css",
                   "~/Content/plugins.css",
                   "~/Content/themes/default.css"));

            bundles.Add(new StyleBundle("~/Content/css-selectmetro").Include(
                      "~/Content/select2_metro.css"));

            bundles.Add(new StyleBundle("~/Content/css-login").Include(
                      "~/Content/login.css"));
        }
    }
}
