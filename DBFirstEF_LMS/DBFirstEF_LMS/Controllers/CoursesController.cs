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
    public class CoursesController : Controller
    {
        private LMSDBEntities1 db = new LMSDBEntities1();

        // GET: Courses
        public ActionResult Index()
        {
            var courses = db.Courses.Include(c => c.Department);
            return View(courses.ToList());
        }

        // GET: Courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // GET: Courses/Create
        public ActionResult Create()
        {
            ViewBag.dept_id = new SelectList(db.Departments, "dept_id", "dept_name");
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "course_id,dept_id,course_name,course_desc")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Courses.Add(course);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.dept_id = new SelectList(db.Departments, "dept_id", "dept_name", course.dept_id);
            return View(course);
        }

        // GET: Courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            ViewBag.dept_id = new SelectList(db.Departments, "dept_id", "dept_name", course.dept_id);
            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "course_id,dept_id,course_name,course_desc")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Entry(course).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.dept_id = new SelectList(db.Departments, "dept_id", "dept_name", course.dept_id);
            return View(course);
        }

        // GET: Courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Course course = db.Courses.Find(id);
            db.Courses.Remove(course);
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

        public ActionResult StudentCourses()
        {
            int? sid = Convert.ToInt32(Session["sv_studentLogin"]);
            if (sid == null || sid == 0)
            {
                ViewBag.Message = "Please login to view GPA.";
                return View();
            }
            //query
            var q = from s in db.Students
                join r in db.Registereds on s.StudentID equals r.student_id
                join sec in db.Sections on r.section_id equals sec.section_id
                join cse in db.Courses on sec.course_id equals cse.course_id
                join sasgn in db.Student_Assignment on s.StudentID equals sasgn.studentID
                join asgn in db.Assignments on sasgn.assignment_id equals asgn.assignment_id
                where s.StudentID == sid
                group sec by new {sec.section_id, cse.course_id, sasgn.assignment_id, sasgn.studentID, asgn.assignment_name, asgn.assignment_due_dt, asgn.assignment_open_dt, cse.course_name, sasgn.grade } into gp
                select new
                {
                    gp.Key.course_name, gp.Key.assignment_id, gp.Key.course_id, gp.Key.assignment_open_dt, gp.Key.assignment_due_dt, gp.Key.grade
                };
            // dynamic model
          

            return View();
        }
    }
}
