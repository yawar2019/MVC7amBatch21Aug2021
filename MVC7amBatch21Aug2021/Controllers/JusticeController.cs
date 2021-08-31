using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7amBatch21Aug2021.Controllers
{
    public class JusticeController : Controller
    {
        // GET: Justice
        public ActionResult Injustice()
        {
            ViewBag.Player = "Kohli";

            return View();
        }
    }
}