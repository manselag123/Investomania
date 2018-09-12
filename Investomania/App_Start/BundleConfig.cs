using System.Web;
using System.Web.Optimization;

namespace Investomania
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/ckeditor").Include(
                       "~/Scripts/ckeditor/ckeditor.js*")); 

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            //  english bootstrap css ==============================
            bundles.Add(new StyleBundle("~/English/css").Include(
                      "~/Sitestyle/FrontEnd/css/language/english/bootstrap.min.css",
                     "~/Sitestyle/FrontEnd/css/language/english/custom.css"));

            //  arabic bootstrap css =================================
            bundles.Add(new StyleBundle("~/Arabic/css").Include(
                      "~/Sitestyle/FrontEnd/css/language/arabic/bootstrap-rtl.min.css",
                     "~/Sitestyle/FrontEnd/css/language/arabic/custom-rtl.css"));


            //  style css ==============================
            bundles.Add(new StyleBundle("~/style/css").Include(
                      "~/Sitestyle/FrontEnd/css/style.css"
                      ));

            //  font css =================================
            bundles.Add(new StyleBundle("~/font/css").Include(
                      "~/Sitestyle/FrontEnd/css/font.css"
                      ));


            //  style css ==============================
            bundles.Add(new StyleBundle("~/reaponsive/css").Include(
                      "~/Sitestyle/FrontEnd/css/reaponsive.css"
                      ));

            // owl carousel css ==============================
            bundles.Add(new StyleBundle("~/carousel/css").Include(
                      "~/Sitestyle/FrontEnd/css/owl.carousel.min.css"
                      ));

            // magazine css ==============================
            bundles.Add(new StyleBundle("~/magazine/css").Include(
                      "~/Sitestyle/FrontEnd/css/magazine.css"
                      ));
            // awesome css ==============================
            bundles.Add(new StyleBundle("~/awesome/css").Include(
                      "~/Sitestyle/FrontEnd/css/font-awesome.min.css"
                      ));

            //  bootstrap Script =================================
            bundles.Add(new ScriptBundle("~/bootstrap/js").Include(
                      "~/Sitestyle/FrontEnd/js/bootstrap.min.js"
                      ));

            //  jquery Script =================================
            bundles.Add(new ScriptBundle("~/jquery-1.12.4/js").Include(
                      "~/Sitestyle/FrontEnd/js/jquery-1.12.4.min.js"
                      ));

            //  ajax Script =================================
            bundles.Add(new ScriptBundle("~/unobtrusive-ajax/js").Include(
                      "~/Sitestyle/FrontEnd/js/jquery.unobtrusive-ajax.min.js"
                      ));

            //  minestyle Script =================================
            bundles.Add(new ScriptBundle("~/jsMine/js").Include(
                      "~/Sitestyle/FrontEnd/js/jsMine.js"
                      ));
            //  animate Script =================================
            bundles.Add(new ScriptBundle("~/animate/js").Include(
                      "~/Sitestyle/FrontEnd/js/animate.js"
                      ));


            //  carousel Script =================================
            //bundles.Add(new ScriptBundle("~/carousel/js").Include(
            //          "~/Sitestyle/FrontEnd/js/owl.carousel.js"
            //          ));


        }
    }
}
