using System.Web.Optimization;

namespace Bacon.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            AddFoundationBundles(bundles);
        }

        static void AddFoundationBundles(BundleCollection bundles)
        {
             bundles.Add(new ScriptBundle("~/bundles/zepto").Include(
                "~/Scripts/zepto.js"));

            bundles.Add(new StyleBundle("~/Content/foundation/css").Include(
                "~/Content/foundation/foundation.css",
                "~/Content/foundation/foundation.mvc.css",
                "~/Content/foundation/app.css"));

            bundles.Add(new ScriptBundle("~/bundles/foundation").Include(
                "~/Scripts/foundation/foundation.js",
                "~/Scripts/foundation/foundation.*",
                "~/Scripts/foundation/app.js"));
        }
    }
}