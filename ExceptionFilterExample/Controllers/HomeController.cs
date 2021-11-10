using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionFilterExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //[HandleError(View ="Error1")]
        public ActionResult Contact(string id)
        {
            try
            {
                int number = 10;
                int a = number / Convert.ToInt32(id);
                return Content(a.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        [OutputCache(Duration =50,Location =System.Web.UI.OutputCacheLocation.Client)]
        public ActionResult GetCacheResult()
        {
            return View();
        }
    }
}