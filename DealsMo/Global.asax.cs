using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using DealsMo.DataAccess;

namespace DealsMo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Database.Configure();
            log4net.Config.XmlConfigurator.Configure();
        }

        protected void Application_BeginRequest()
        {
            Database.OpenSession();
        }
        protected void Application_EndRequest()
        {
            Database.CloseSesison();
        }
    }
}
