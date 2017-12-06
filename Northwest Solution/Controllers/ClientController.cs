using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwest_Solution.Controllers
{
    
    public class ClientController : Controller
    {
        
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetQuote()
        {

            List<SelectListItem> tests = new List<SelectListItem>();
            tests.Add(new SelectListItem { Text = "Biochemical Pharmacology (BP)", Value = "0" });
            tests.Add(new SelectListItem { Text = "DiscoveryScreen® (DS)", Value = "1" });
            tests.Add(new SelectListItem { Text = "ImmunoScreen® (IS)", Value = "2"});
            tests.Add(new SelectListItem { Text = "ProfilingScreen® (PF)", Value = "3" });
            tests.Add(new SelectListItem { Text = "DiscoveryScreen® (DS)", Value = "4" });
            tests.Add(new SelectListItem { Text = "ImmunoScreen® (IS)", Value = "5" });
            ViewBag.tests = tests;
            ViewBag.AddTests = false;

            return View();
        }

        public ActionResult MyOrders(int? i)
        {
            
            if (i == 1)
            {
                ViewBag.WasApproved = true;
            }

            return View();
        }
        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Approval()
        {

            return View();
        }

        public ActionResult History()
        {

            return View();
        }

        public ActionResult HistoryDetails()
        {

            return View();
        }
        public ActionResult QuoteDetails()
        {
            return View();
        }


    }
}