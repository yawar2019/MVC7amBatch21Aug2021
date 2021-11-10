using MVC7amBatch21Aug2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC7amBatch21Aug2021.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        EmployeeEntities db = new EmployeeEntities();


        public ActionResult Login()
        {
           

            return View();
        }

        [HttpPost]
        public ActionResult Login(UserDetail det)
        {
            UserDetail emp = db.UserDetails.Where(x => x.UserName == det.UserName && 
                             x.Password == det.Password).SingleOrDefault();
            if (emp != null)
            {
                FormsAuthentication.SetAuthCookie(det.UserName, false);
                return RedirectToAction("DashBoard");
            }


            return View();
        }

        [Authorize]
        public ActionResult DashBoard()
        {
            return View();
        }

        [Authorize(Roles="Admin")]
        public ActionResult Aboutus()
        {
            return View();
        }

        [Authorize(Roles="Manager")]
        public ActionResult ContacUs()
        {
            return View();
        }

    }

   
}