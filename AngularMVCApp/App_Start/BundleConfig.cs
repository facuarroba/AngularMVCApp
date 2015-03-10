using System.Web;
using System.Web.Optimization;

namespace AngularMVCApp
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/AngularMVCApp")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .IncludeDirectory("~/Scripts/Factories","*.js")
                .Include("~/Scripts/AngularMVCApp.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
