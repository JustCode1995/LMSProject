using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBFirstEF_LMS.Controllers
{
    public class StudentPortalController : Controller
    {
        // GET: StudentPortal
        public ActionResult Index()
        {
            int? sid = Convert.ToInt32(Session["sv_studentLogin"]);
            if (sid == null || sid == 0)
            {
                return RedirectToAction("Login", "StudentLogins");
            }
            return View();
        }
    }
}