using MVC7amBatch21Aug2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 

namespace MVC7amBatch21Aug2021.Controllers
{
    public class NewController : Controller
    {
        // GET: New hari

        public string Index()
        {
            return "Hello World";
        }
        public int Index2()
        {
            return 1211;
        }

        public string Index3(int id)
        {
            return "Hello World:" +id;
        }

        public string Index4(int? id, string Name)//?Name=jiva
        {
            return "Hello World My id :" + id + " and My Name is " + Name;
        }

        [ActionName("Test")]
        public string Index4(int? id, string Name, string Designation)//?Name=jiva&&Designation=clerk
        {
            return "Hello World My id :" + id + " and My Name is " + Name + " Designation is " + Designation;
        }



        [Route("pistahouse/cake")]
        [Route("pistahouse/juice")]
        public int Index6()
        {
            return 1211;
        }

        public ActionResult SendData()
        {
            ViewBag.Name = "Sahoo";
            return View();
        }
        public ActionResult SendData2()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Abhishek";
            obj.EmpSalary = 10000;

            ViewBag.info= obj;
            return View();
        }

        public ActionResult SendData3()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Abhishek";
            obj.EmpSalary = 10000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Komal";
            obj1.EmpSalary = 20000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Amrita";
            obj2.EmpSalary = 30000;

            listObj.Add(obj);//abhishek
            listObj.Add(obj1);//komal
            listObj.Add(obj2);//amrita

            ViewBag.info = listObj;
           


            return View();
        }

        public ActionResult SendData4()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Abhishek";
            obj.EmpSalary = 10000;

           // object model = obj;
            return View(obj);
        }

        public ActionResult SendData5()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Abhishek";
            obj.EmpSalary = 10000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Komal";
            obj1.EmpSalary = 20000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Amrita";
            obj2.EmpSalary = 30000;

            listObj.Add(obj);//abhishek
            listObj.Add(obj1);//komal
            listObj.Add(obj2);//amrita

             
            return View(listObj);
        }
    }
}


//Conventional based Routing
//Attribute based Routing