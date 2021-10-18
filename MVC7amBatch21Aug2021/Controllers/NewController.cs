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

        public ViewResult TestView()
        {
            return View("../Views/Justice/Injustice.cshtml");
        }

        public RedirectResult TestResult()
        {
            return Redirect("http://www.google.com");
        }
        public RedirectResult TestResult2()
        {   
            return Redirect("index");
        }

        public ViewResult PartialViewExample()
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
        public FileResult getFile()
        {
            return File("~/Web.config","text");

        }

        public FileResult getFile2(int? id,string Name)
        {
            return File("~/ActionResult.pdf", "application/pdf");

        }

        public FileResult getFile3()
        {
            return File("~/ActionResult.pdf", "application/pdf","ActionResult.pdf");

        }

        public JsonResult getJsonData()
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

            return Json(listObj, JsonRequestBehavior.AllowGet);
        }

        public  RedirectToRouteResult RedirecttoOtherUrl()
        {
            return RedirectToRoute("Default123");
        }

        public RedirectToRouteResult RedirecttoAnotherUrl()
        {

            return RedirectToAction("getFile2","New",new {id=123,Name="jeevan" });
        }

        public RedirectToRouteResult RedirecttoAnotherUrl2()
        {
            EmployeeModel emp = new Models.EmployeeModel();
           emp.EmpId = 3;
           emp.EmpName = "Amrita";
           emp.EmpSalary = 30000;
            return RedirectToAction("justice", "justice", emp);
        }

        public ContentResult MyContent(int? id)
        {
            if(id==1)
            {
                return Content("Hello World");
            }
            else if(id==2)
            {
                return Content("<p style=color:red>Hello World</p>");
            }
            else
            {
                return Content("<script>alert('To Much Cold')</script>");
            }
        }

        public ActionResult HtmlhelperExample()
        {
            CountryEntities db = new Models.CountryEntities();
            ViewBag.states = new SelectList(db.States.ToList(), "Id", "StateName",2);
            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpName = "Jakie shroff";

            List<Skill> listskill = new List<Models.Skill>()
            {
                new Skill {SkillId=1,SkillName="MVC",isActive=true },
                new Skill {SkillId=2,SkillName="C#",isActive=false },
                new Skill {SkillId=3,SkillName="Sql",isActive=false }
            };

            ViewBag.listskill = listskill;

            return View(emp);
        }
        [HttpPost]
        public ActionResult HtmlhelperExample(string Gender,bool Course,string ExtraCr,int[] SkillId,int StateId)
        {
            CountryEntities db = new Models.CountryEntities();
            ViewBag.states = new SelectList(db.States.ToList(), "Id", "StateName", 2);

            State state = db.States.Where(s => s.Id == StateId).SingleOrDefault();
            ViewBag.stateName = state.Id + "," + state.StateName;

            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpName = "Jakie shroff";
            ////////////////////////////////////////////////
            ViewBag.SelectedGender = "you have selected "+Gender;
            ///////////////////////////////////////////////////
            ViewBag.SelectedCourse = "you have selected " + Course;
            ///////////////
            List<Skill> listskill = new List<Models.Skill>()
            {
                new Skill {SkillId=1,SkillName="MVC",isActive=true },
                new Skill {SkillId=2,SkillName="C#",isActive=false },
                new Skill {SkillId=3,SkillName="Sql",isActive=false }
            };

            ViewBag.listskill = listskill;
            ViewBag.SelectedSkill = listskill.Where(i => SkillId.ToArray().Contains(i.SkillId));

            return View(emp);
        }
    }
}


//Conventional based Routing
//Attribute based Routing