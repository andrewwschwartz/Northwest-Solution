using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwest_Solution.Controllers
{
    public class EmployeeController : Controller
    {
        
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tab()
        {
            return View();
        }

        public ActionResult CreateEmployee()
        {
            return View();
        }

        public ActionResult ViewWO()
        {

            List<SelectListItem> tests = new List<SelectListItem>();
            tests.Add(new SelectListItem { Text = "Tylenol Tech", Value = "0" });
            tests.Add(new SelectListItem { Text = "McDonalds Inc", Value = "1" });
            tests.Add(new SelectListItem { Text = "Science LLC", Value = "2" });
            tests.Add(new SelectListItem { Text = "MicroMedicines Corp", Value = "3" });
            tests.Add(new SelectListItem { Text = "Healthly Drugs", Value = "4" });

            ViewBag.tests = tests;

            return View();
        }

        public ActionResult CreateWO()
        {
            return View();
        }

        public ActionResult EditWO()
        {
            return View();
        }
    }
}