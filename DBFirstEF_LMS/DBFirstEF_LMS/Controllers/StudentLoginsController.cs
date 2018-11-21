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
    public class StudentLoginsController : Controller
    {
        private LMSDBEntities1 db = new LMSDBEntities1();

        // GET: StudentLogins
        public ActionResult Index()
        {
            var studentLogins = db.StudentLogins.Include(s => s.Student);
            return View(studentLogins.ToList());
        }

        // GET: StudentLogins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentLogin studentLogin = db.StudentLogins.Find(id);
            if (studentLogin == null)
            {
                return HttpNotFound();
            }
            return View(studentLogin);
        }

        // GET: StudentLogins/Create
        public ActionResult Create()
        {
            ViewBag.student_id = new SelectList(db.Students, "StudentID", "StudentID");
            return View();
        }

        // POST: StudentLogins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "student_id,student_pwd")] StudentLogin studentLogin)
        {
            if (ModelState.IsValid)
            {
                db.StudentLogins.Add(studentLogin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.student_id = new SelectList(db.Students, "StudentID", "Fname", studentLogin.student_id);
            return View(studentLogin);
        }

        // GET: StudentLogins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentLogin studentLogin = db.StudentLogins.Find(id);
            if (studentLogin == null)
            {
                return HttpNotFound();
            }
            ViewBag.student_id = new SelectList(db.Students, "StudentID", "Fname", studentLogin.student_id);
            return View(studentLogin);
        }

        // POST: StudentLogins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "student_id,student_pwd")] StudentLogin studentLogin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentLogin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.student_id = new SelectList(db.Students, "StudentID", "Fname", studentLogin.student_id);
            return View(studentLogin);
        }

        // GET: StudentLogins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentLogin studentLogin = db.StudentLogins.Find(id);
            if (studentLogin == null)
            {
                return HttpNotFound();
            }
            return View(studentLogin);
        }

        // POST: StudentLogins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentLogin studentLogin = db.StudentLogins.Find(id);
            db.StudentLogins.Remove(studentLogin);
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
        public ActionResult Login(string studentID, string studentPass)
        {
            string u = studentID;
            string p = studentPass;

            if (studentID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentLogin studentLogin = db.StudentLogins.Find(Convert.ToInt32(studentID));

            if (studentLogin == null)
            {
                ViewBag.LoginSuccess = "Please Retry, please type again.";
            }
            else
            {
                if (studentPass == studentLogin.student_pwd)
                {
                    ViewBag.LoginSuccess = "Success";
                    System.Web.HttpContext.Current.Session["loginSessionVar"] = studentID;
                    return RedirectToAction("Index", "StudentPortal", null);
                }
                else
                {
                    ViewBag.LoginSuccess = "Failed";
                }
            }


            return View();
        }

    }
}
