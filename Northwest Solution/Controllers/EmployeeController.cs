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

        public ActionResult Details(int? i)
        {
            if (i == 1)
            {
                ViewBag.WasApproved = true;
            }

            return View();
        }

        public ActionResult Approval()
        {
            return View();
        }

        public ActionResult CreateWO()
        {
            List<SelectListItem> tests = new List<SelectListItem>();
            tests.Add(new SelectListItem { Text = "Biochemical Pharmacology (BP)", Value = "0" });
            tests.Add(new SelectListItem { Text = "DiscoveryScreen® (DS)", Value = "1" });
            tests.Add(new SelectListItem { Text = "ImmunoScreen® (IS)", Value = "2" });
            tests.Add(new SelectListItem { Text = "ProfilingScreen® (PF)", Value = "3" });
            tests.Add(new SelectListItem { Text = "DiscoveryScreen® (DS)", Value = "4" });
            tests.Add(new SelectListItem { Text = "ImmunoScreen® (IS)", Value = "5" });
            ViewBag.tests = tests;
            ViewBag.AddTests = false;
            return View();
        }

        public ActionResult thankYOU()
        {
            return View();
        }

        public ActionResult EditWO()
        {
            return View();
        }

        public ActionResult Invoice()
        {
            return View();
        }
    }
}