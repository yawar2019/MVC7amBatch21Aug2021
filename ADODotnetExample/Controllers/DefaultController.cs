﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADODotnetExample.Models;
namespace ADODotnetExample.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.getEmployeeDetails());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int i=db.SaveEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            
              return View();  
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.getEmployeeDetailsById(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            int i = db.UpdateEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.getEmployeeDetailsById(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            int i = db.DeleteEmployee(id);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult ConsumedWcfServiceHostedOnIIS()
        {
            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client("WSHttpBinding_IService1");
            var result=obj.Mul(10, 20);
            ServiceReference1.Service1Client obj1 = new ServiceReference1.Service1Client("NetTcpBinding_IService1");
            var result1 = obj1.Mul(10, 20);
            return Content(result1.ToString());
        }
    }
}