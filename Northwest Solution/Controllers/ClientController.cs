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



    }
}