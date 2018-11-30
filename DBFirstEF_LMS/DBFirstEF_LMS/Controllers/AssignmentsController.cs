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
    public class AssignmentsController : Controller
    {
        private LMSDBEntities1 db = new LMSDBEntities1();

        // GET: Assignments
        public ActionResult Index()
        {
            var assignments = db.Assignments.Include(a => a.Section);
            return View(assignments.ToList());
        }

        // GET: Assignments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = db.Assignments.Find(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }

        // GET: Assignments/Create
        //public ActionResult Create()
        //{
        //    ViewBag.section_id = new SelectList(db.Sections);
        //    return View();
        //}

        public ActionResult Create(int? id)
        {
            var maxID = db.Assignments.Select(a => a.assignment_id).Max();
            maxID++;
            ViewBag.asgnid = maxID;

            ViewBag.section_id = new SelectList(db.Sections);
            if (id == null || (id.ToString().Length < 1))
            {                
                var dict = new Dictionary<int, string>();
                foreach(var v in db.Sections.Include(s => s.Course).Select(i => new { i.section_id, i.Course.course_name}).ToList())
                {
                    dict.Add(v.section_id, v.section_id + " " + v.course_name);
                }                
                ViewBag.sectionlist = new SelectList(dict, "Key", "Value");
                return this.View();
            }
            ViewBag.sectionlist = new SelectList(new[] { id });
            return View();
        }

        // POST: Assignments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "assignment_id,section_id,assignment_name,assignment_due_dt,assignment_open_dt")] Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                //assignment.section_id = 
                db.Assignments.Add(assignment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.section_id = new SelectList(db.Sections, "section_id", "day_of_week", assignment.section_id);
            return View(assignment);
        }

        // GET: Assignments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = db.Assignments.Find(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            ViewBag.section_id = new SelectList(db.Sections, "section_id", "section_id", assignment.section_id);
            return View(assignment);
        }

        // POST: Assignments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "assignment_id,section_id,assignment_name,assignment_due_dt,assignment_open_dt")] Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assignment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.section_id = new SelectList(db.Sections, "section_id", "day_of_week", assignment.section_id);
            return View(assignment);
        }

        // GET: Assignments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = db.Assignments.Find(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }

        // POST: Assignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Assignment assignment = db.Assignments.Find(id);
            db.Assignments.Remove(assignment);
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
