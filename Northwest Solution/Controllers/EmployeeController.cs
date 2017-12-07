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
            tests.Add(new SelectListItem { Text = "CustomScreen® (CS)", Value = "5" });
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
            List<SelectListItem> assay = new List<SelectListItem>();
            assay.Add(new SelectListItem { Text = "", Value = "0" });
            assay.Add(new SelectListItem { Text = "Biochemical Pharmacology (BP)", Value = "1" });
            assay.Add(new SelectListItem { Text = "DiscoveryScreen® (DS)", Value = "2" });
            assay.Add(new SelectListItem { Text = "ImmunoScreen® (IS)", Value = "3" });
            assay.Add(new SelectListItem { Text = "ProfilingScreen® (PF)", Value = "4" });
            assay.Add(new SelectListItem { Text = "DiscoveryScreen® (DS)", Value = "5" });
            assay.Add(new SelectListItem { Text = "CustomScreen® (CS)", Value = "6" });

            List<SelectListItem> tests = new List<SelectListItem>();
            tests.Add(new SelectListItem { Text = "", Value = "0" });
            tests.Add(new SelectListItem { Text = "121", Value = "1" });
            tests.Add(new SelectListItem { Text = "122", Value = "2" });
            tests.Add(new SelectListItem { Text = "123", Value = "3" });
            tests.Add(new SelectListItem { Text = "124", Value = "4" });
            tests.Add(new SelectListItem { Text = "125", Value = "5" });
            tests.Add(new SelectListItem { Text = "216", Value = "6" });
            tests.Add(new SelectListItem { Text = "227", Value = "7" });
            tests.Add(new SelectListItem { Text = "238", Value = "8" });
            tests.Add(new SelectListItem { Text = "249", Value = "9" });
            tests.Add(new SelectListItem { Text = "250", Value = "10" });

            ViewBag.tests = tests;
            ViewBag.assay = assay;

            return View();
        }

        public ActionResult Invoice()
        {
            return View();
        }

        public ActionResult GetList()
        {
            return View();
        }
    }
}