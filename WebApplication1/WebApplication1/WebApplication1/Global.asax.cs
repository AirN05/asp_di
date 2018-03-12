using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition;
using System.Reflection;
using System.IO;
using ConsoleApplication1;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {

        public static AggregateCatalog catalog { get; set; }

        protected void Application_Start()
        {
            //var path = AppDomain.CurrentDomain.BaseDirectory+ "/../../ConsoleApplication1/ConsoleApplication1/bin/Debug/ConsoleApplication1.exe";
            //catalog = new AggregateCatalog();
            //catalog.Catalogs.Add(new DirectoryCatalog(path));


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
