using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DBFirstEF_LMS.Models;

namespace DBFirstEF_LMS.Controllers
{
    public class StaffLoginsController : Controller
    {
        private LMSDBEntities1 db = new LMSDBEntities1();

        // GET: StaffLogins
        public ActionResult Index()
        {
            var staffLogins = db.StaffLogins.Include(s => s.Staff);
            return View(staffLogins.ToList());
        }

        // GET: StaffLogins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffLogin staffLogin = db.StaffLogins.Find(id);
            if (staffLogin == null)
            {
                return HttpNotFound();
            }
            return View(staffLogin);
        }

        // GET: StaffLogins/Create
        public ActionResult Create()
        {
            ViewBag.staff_id = new SelectList(db.Staffs, "staff_id", "first_name");
            return View();
        }

        // POST: StaffLogins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "staff_id,staff_pwd")] StaffLogin staffLogin)
        {
            if (ModelState.IsValid)
            {
                db.StaffLogins.Add(staffLogin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.staff_id = new SelectList(db.Staffs, "staff_id", "first_name", staffLogin.staff_id);
            return View(staffLogin);
        }

        // GET: StaffLogins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffLogin staffLogin = db.StaffLogins.Find(id);
            if (staffLogin == null)
            {
                return HttpNotFound();
            }
            ViewBag.staff_id = new SelectList(db.Staffs, "staff_id", "first_name", staffLogin.staff_id);
            return View(staffLogin);
        }

        // POST: StaffLogins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "staff_id,staff_pwd")] StaffLogin staffLogin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staffLogin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.staff_id = new SelectList(db.Staffs, "staff_id", "first_name", staffLogin.staff_id);
            return View(staffLogin);
        }

        // GET: StaffLogins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffLogin staffLogin = db.StaffLogins.Find(id);
            if (staffLogin == null)
            {
                return HttpNotFound();
            }
            return View(staffLogin);
        }

        // POST: StaffLogins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StaffLogin staffLogin = db.StaffLogins.Find(id);
            db.StaffLogins.Remove(staffLogin);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string staffID, string staffPass)
        {
            string u = staffID;
            string p = staffPass;

            if (staffID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffLogin staffLogin = db.StaffLogins.Find(Convert.ToInt32(staffID));
            Staff staff = db.Staffs.Find(Convert.ToInt32(staffID));
            StudentLogin studentLogin = db.StudentLogins.Find(Convert.ToInt32(staffID));
     
            if (studentLogin != null)
            {
                ViewBag.Message = "Please log in using the Student Login page.";
                return View();
            }
            else
            {
                if (staffLogin == null)
                {
                    ViewBag.LoginSuccess = "Please Retry, please type again.";
                }
                else
                {
                    if (staff.access_level == 1)
                    {
                        if (staffPass == staffLogin.staff_pwd)
                        {
                            ViewBag.LoginSuccess = "Success";
                            System.Web.HttpContext.Current.Session["sv_staffLogin"] = Convert.ToInt32(staffID);
                            return RedirectToAction("Index", "StaffPortal", null);
                        }
                        else
                        {
                            ViewBag.LoginSuccess = "Failed";

                        }
                    }
                    else
                    {
                        if (staffPass == staffLogin.staff_pwd)
                        {
                            ViewBag.LoginSuccess = "Success";
                            System.Web.HttpContext.Current.Session["sv_staffLogin"] = Convert.ToInt32(staffID);
                            return RedirectToAction("Index", "TeacherPortal", null);
                        }
                        else
                        {
                            ViewBag.LoginSuccess = "Failed";

                        }
                    }
                }

            }

            return View();
        }
    }
}
