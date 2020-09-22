using System.Web;
using System.Web.Optimization;

namespace WellBeingCampaign
{
    public class BundleConfig
    {     
        //Bundle.BundleTable.Bundles.Add(bundle);

        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                      "~/js/scripts.js",
                      "~/js/gmap.js",
                      "~/js/filter.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/styles.css"
                      ));
           
        }
    }
}
