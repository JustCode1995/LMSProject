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
    public class Student_AssignmentController : Controller
    {
        private LMSDBEntities1 db = new LMSDBEntities1();

        // GET: Student_Assignment
        public ActionResult Index()
        {
            int? sid = Convert.ToInt32(Session["sv_studentLogin"]);
            var student_Assignment = db.Student_Assignment.Include(s => s.Assignment.Section.Course).Include(s => s.Assignment).Include(s => s.Section).Include(s => s.Student).Where(s => s.studentID == sid);
            return View(student_Assignment.ToList());
        }

        public ActionResult ClassDetails()
        {
            int? sid = Convert.ToInt32(Session["sv_studentLogin"]);
            var student_Assignment = db.Student_Assignment.Include(s => s.Assignment.Section.Course).Include(s => s.Assignment).Include(s => s.Section).Include(s => s.Student).Where(s => s.studentID == sid);
            return View(student_Assignment.ToList());
        }

        // GET: Student_Assignment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Assignment student_Assignment = db.Student_Assignment.Find(id);
            if (student_Assignment == null)
            {
                return HttpNotFound();
            }
            return View(student_Assignment);
        }

        // GET: Student_Assignment/Create
        public ActionResult Create()
        {
            ViewBag.assignment_id = new SelectList(db.Assignments, "assignment_id", "assignment_name");
            ViewBag.section_id = new SelectList(db.Sections, "section_id", "day_of_week");
            ViewBag.studentID = new SelectList(db.Students, "StudentID", "Fname");
            return View();
        }

        // POST: Student_Assignment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "section_id,assignment_id,studentID,grade")] Student_Assignment student_Assignment)
        {
            if (ModelState.IsValid)
            {
                db.Student_Assignment.Add(student_Assignment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.assignment_id = new SelectList(db.Assignments, "assignment_id", "assignment_name", student_Assignment.assignment_id);
            ViewBag.section_id = new SelectList(db.Sections, "section_id", "day_of_week", student_Assignment.section_id);
            ViewBag.studentID = new SelectList(db.Students, "StudentID", "Fname", student_Assignment.studentID);
            return View(student_Assignment);
        }

        // GET: Student_Assignment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Assignment student_Assignment = db.Student_Assignment.Find(id);
            if (student_Assignment == null)
            {
                return HttpNotFound();
            }
            ViewBag.assignment_id = new SelectList(db.Assignments, "assignment_id", "assignment_name", student_Assignment.assignment_id);
            ViewBag.section_id = new SelectList(db.Sections, "section_id", "day_of_week", student_Assignment.section_id);
            ViewBag.studentID = new SelectList(db.Students, "StudentID", "Fname", student_Assignment.studentID);
            return View(student_Assignment);
        }

        // POST: Student_Assignment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "section_id,assignment_id,studentID,grade")] Student_Assignment student_Assignment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student_Assignment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.assignment_id = new SelectList(db.Assignments, "assignment_id", "assignment_name", student_Assignment.assignment_id);
            ViewBag.section_id = new SelectList(db.Sections, "section_id", "day_of_week", student_Assignment.section_id);
            ViewBag.studentID = new SelectList(db.Students, "StudentID", "Fname", student_Assignment.studentID);
            return View(student_Assignment);
        }

        // GET: Student_Assignment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Assignment student_Assignment = db.Student_Assignment.Find(id);
            if (student_Assignment == null)
            {
                return HttpNotFound();
            }
            return View(student_Assignment);
        }

        // POST: Student_Assignment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student_Assignment student_Assignment = db.Student_Assignment.Find(id);
            db.Student_Assignment.Remove(student_Assignment);
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
