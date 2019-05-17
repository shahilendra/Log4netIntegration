using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Log4netIntegration.Controllers
{
    public class HomeController : Controller
    {
        log4net.ILog logger = log4net.LogManager.GetLogger(typeof(HomeController));  //Declaring Log4Net 
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            try
            {
                int x, y, z;
                x = 5; y = 0;
                z = x / y;
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }
            return View();
        }
    }
}
