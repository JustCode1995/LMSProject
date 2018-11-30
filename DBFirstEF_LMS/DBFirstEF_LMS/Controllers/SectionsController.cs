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
    public class SectionsController : Controller
    {
        private LMSDBEntities1 db = new LMSDBEntities1();

        // GET: Sections
        public ActionResult Index()
        {
            var sections = db.Sections.Include(s => s.Course).Include(s => s.Semester).Include(s => s.Staff);
            return View(sections.ToList());
        }

        // GET: Sections/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Section section = db.Sections.Find(id);
            if (section == null)
            {
                return HttpNotFound();
            }
            return View(section);
        }

        // GET: Sections/Create
        public ActionResult Create()
        {
            ViewBag.secid = db.Sections.Select(s => s.section_id).Max() + 1;
            ViewBag.course_id = new SelectList(db.Courses, "course_id", "course_name");
            ViewBag.semester_id = new SelectList(db.Semesters, "sem_id", "sem_desc");
            ViewBag.teacher_id = new SelectList(db.Staffs, "staff_id", "first_name");
            return View();
        }

        // POST: Sections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "section_id,course_id,teacher_id,semester_id,day_of_week,start_time,end_time")] Section section)
        {
            if (ModelState.IsValid)
            {
                db.Sections.Add(section);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.course_id = new SelectList(db.Courses, "course_id", "course_name", section.course_id);
            ViewBag.semester_id = new SelectList(db.Semesters, "sem_id", "sem_desc", section.semester_id);
            ViewBag.teacher_id = new SelectList(db.Staffs, "staff_id", "first_name", section.teacher_id);
            return View(section);
        }

        // GET: Sections/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Section section = db.Sections.Find(id);
            if (section == null)
            {
                return HttpNotFound();
            }
            ViewBag.course_id = new SelectList(db.Courses, "course_id", "course_name", section.course_id);
            ViewBag.semester_id = new SelectList(db.Semesters, "sem_id", "sem_desc", section.semester_id);
            ViewBag.teacher_id = new SelectList(db.Staffs, "staff_id", "first_name", section.teacher_id);
            return View(section);
        }

        // POST: Sections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "section_id,course_id,teacher_id,semester_id,day_of_week,start_time,end_time")] Section section)
        {
            if (ModelState.IsValid)
            {
                db.Entry(section).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.course_id = new SelectList(db.Courses, "course_id", "course_name", section.course_id);
            ViewBag.semester_id = new SelectList(db.Semesters, "sem_id", "sem_desc", section.semester_id);
            ViewBag.teacher_id = new SelectList(db.Staffs, "staff_id", "first_name", section.teacher_id);
            return View(section);
        }

        // GET: Sections/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Section section = db.Sections.Find(id);
            if (section == null)
            {
                return HttpNotFound();
            }
            return View(section);
        }

        // POST: Sections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Section section = db.Sections.Find(id);
            db.Sections.Remove(section);
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
