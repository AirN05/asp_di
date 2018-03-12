using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using static WebApplication1.MvcApplication;
using ConsoleApplication1;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [Import] public ILogger logger { get; set; }
        public ActionResult Index()
        {
          try
            {
                var path = AppDomain.CurrentDomain.BaseDirectory + "/../../ConsoleApplication1/ConsoleApplication1/bin/Debug/ConsoleApplication1.exe";
                var catalog = new AggregateCatalog();
                catalog.Catalogs.Add(new DirectoryCatalog(path));
                var container = new CompositionContainer(catalog);
                container.ComposeParts(this, new Logger());
            }
            catch (Exception e)
            {
            }
            
            logger.Log("Hello");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}