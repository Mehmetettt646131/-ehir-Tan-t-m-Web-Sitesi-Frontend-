using System.Globalization;
using System.Threading;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace KendimDeneme
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest()
        {
            var cultureInfo = new CultureInfo("tr-TR");

            if (Request.Cookies["lang"] != null)
            {
                var lang = Request.Cookies["lang"].Value;
                cultureInfo = new CultureInfo(lang);
            }

            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }
    }
}
