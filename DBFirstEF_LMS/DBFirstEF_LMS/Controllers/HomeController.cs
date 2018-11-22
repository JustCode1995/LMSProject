using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBFirstEF_LMS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Logout()
        {
            var ses = Session;
            foreach(var cs in ses)
            {
                Session[cs.ToString()] = null;
            }

            return View("Index");
        }


    }
}