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
    public class RegisteredsController : Controller
    {
        private LMSDBEntities1 db = new LMSDBEntities1();

        // GET: Registereds
        public ActionResult Index()
        {
            var registereds = db.Registereds.Include(r => r.Section).Include(r => r.Student);
            return View(registereds.ToList());
        }

        // GET: Registereds/Details/5
        public ActionResult Details(int sectionid, int studentid)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            Registered registered = db.Registereds.Find(studentid,sectionid);
            if (registered == null)
            {
                return HttpNotFound();
            }
            return View(registered);
        }

        // GET: Registereds/Create
        public ActionResult Create()
        {
            ViewBag.section_id = new SelectList(db.Sections, "section_id", "day_of_week");
            ViewBag.student_id = new SelectList(db.Students, "StudentID", "Fname");
            return View();
        }

        // POST: Registereds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "student_id,section_id,grade")] Registered registered)
        {
            if (ModelState.IsValid)
            {
                db.Registereds.Add(registered);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.section_id = new SelectList(db.Sections, "section_id", "day_of_week", registered.section_id);
            ViewBag.student_id = new SelectList(db.Students, "StudentID", "Fname", registered.student_id);
            return View(registered);
        }

        // GET: Registereds/Edit/5
        public ActionResult Edit(int sectionid, int studentid)
        {
            //if (sectionid == null && studentid == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            Registered registered = db.Registereds.Find(studentid,sectionid);
            if (registered == null)
            {
                return HttpNotFound();
            }
            ViewBag.section_id = new SelectList(db.Sections, "section_id", "day_of_week", registered.section_id);
            ViewBag.student_id = new SelectList(db.Students, "StudentID", "Fname", registered.student_id);
            return View(registered);
        }

        // POST: Registereds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "student_id,section_id,grade")] Registered registered)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registered).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.section_id = new SelectList(db.Sections, "section_id", "day_of_week", registered.section_id);
            ViewBag.student_id = new SelectList(db.Students, "StudentID", "Fname", registered.student_id);
            return View(registered);
        }

        // GET: Registereds/Delete/5
        public ActionResult Delete(int sectionid, int studentid)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            Registered registered = db.Registereds.Find(studentid,sectionid);
            if (registered == null)
            {
                return HttpNotFound();
            }
            return View(registered);
        }

        // POST: Registereds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int sectionid, int studentid)
        {
            Registered registered = db.Registereds.Find(studentid,sectionid);
            db.Registereds.Remove(registered);
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
    }
}
