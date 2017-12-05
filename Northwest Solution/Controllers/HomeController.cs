using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Northwest_Solution.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // GET: Login 
        public ActionResult Login()
        {
            return View();
        }
        //Post for the Login Action Method
        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String user = form["User Name"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(user, "client") && (string.Equals(password, "client")))
            {
                FormsAuthentication.SetAuthCookie(user, rememberMe);

                return RedirectToAction("Index");

            }
            else if (string.Equals(user, "management") && (string.Equals(password, "northwest")))
            {
                FormsAuthentication.SetAuthCookie(user, rememberMe);

                return RedirectToAction("Index");

            }
            else
            {
                return View();
            }
        }

    }
}