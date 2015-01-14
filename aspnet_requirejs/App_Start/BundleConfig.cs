using System.Web;
using System.Web.Optimization;

namespace aspnet_requirejs
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/requirejs").Include("~/Scripts/lib/require.js"));

            bundles.Add(new ScriptBundle("~/bundles/requirejs_config")
                .Include("~/Scripts/requirejs_config.js"));

#if DEBUG
            bundles.Add(new ScriptBundle("~/bundles/app")
                .Include("~/Scripts/app/app.js"));
#else
            bundles.Add(new ScriptBundle("~/bundles/app")
                .Include("~/Scripts/app.min.js"));
#endif

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

#if DEBUG
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}
