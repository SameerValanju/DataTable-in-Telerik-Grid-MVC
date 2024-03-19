using System.Web;
using System.Web.Optimization;

namespace telerik_demo_grid_by_datatable
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new StyleBundle("~/bundles/kendoCSS").Include("~/Content/kendo/2022.3.913/kendo.bootstrap-main.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/kendoJS").Include("~/Scripts/kendo/2022.3.913/jszip.min.js",
                "~/Scripts/kendo/2022.3.913/kendo.all.min.js",
                "~/Scripts/kendo/2022.3.913/kendo.aspnetmvc.min.js"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
