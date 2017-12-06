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