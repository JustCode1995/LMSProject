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
    public class StudentAssignmentsController : Controller
    {
        private LMSDBEntities1 db = new LMSDBEntities1();

        // GET: StudentAssignments
        public ActionResult Index(int? id)
        {
            int? sid = Convert.ToInt32(Session["sv_studentLogin"]);
            int? tid = Convert.ToInt32(Session["sv_staffLogin"]);
            int? asgnid = id;
            if (sid == null || sid == 0)
            {
                if(tid == null || tid ==0)
                {
                    return View();
                }
                else
                {
                    if (asgnid == null || asgnid == 0)
                    {
                        var studentAssignments = db.StudentAssignments.Include(s => s.Assignment).Include(s => s.Section).Include(s => s.Student).Where(s => s.Section.teacher_id == tid);
                        return View(studentAssignments.ToList());
                    }
                    else
                    {
                        var studentAssignments = db.StudentAssignments.Include(s => s.Assignment).Include(s => s.Section).Include(s => s.Student).Where(s => s.Section.teacher_id == tid && s.assignment_id == asgnid);
                        return View(studentAssignments.ToList());
                    }                    
                }
            }
            else
            {
                if(asgnid == null || asgnid == 0)
                {
                    var studentAssignments = db.StudentAssignments.Include(s => s.Assignment).Include(s => s.Section).Include(s => s.Student).Where(s => s.studentID == sid);
                    return View(studentAssignments.ToList());
                }
                else
                {
                    var studentAssignments = db.StudentAssignments.Include(s => s.Assignment).Include(s => s.Section).Include(s => s.Student).Where(s => s.studentID == sid && s.assignment_id == asgnid);
                    return View(studentAssignments.ToList());
                }
            }
            //var studentAssignments = db.StudentAssignments.Include(s => s.Assignment).Include(s => s.Section).Include(s => s.Student);
            //return View(studentAssignments.ToList());
        }

        // GET: StudentAssignments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssignment studentAssignment = db.StudentAssignments.Find(id);
            if (studentAssignment == null)
            {
                return HttpNotFound();
            }
            return View(studentAssignment);
        }

        // GET: StudentAssignments/Create
        public ActionResult Create()
        {
            ViewBag.assignment_id = new SelectList(db.Assignments, "assignment_id", "assignment_name");
            ViewBag.section_id = new SelectList(db.Sections, "section_id", "day_of_week");
            ViewBag.studentID = new SelectList(db.Students, "StudentID", "Fname");
            return View();
        }

        // POST: StudentAssignments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "section_id,assignment_id,studentID,grade")] StudentAssignment studentAssignment)
        {
            if (ModelState.IsValid)
            {
                db.StudentAssignments.Add(studentAssignment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.assignment_id = new SelectList(db.Assignments, "assignment_id", "assignment_name", studentAssignment.assignment_id);
            ViewBag.section_id = new SelectList(db.Sections, "section_id", "day_of_week", studentAssignment.section_id);
            ViewBag.studentID = new SelectList(db.Students, "StudentID", "Fname", studentAssignment.studentID);
            return View(studentAssignment);
        }

        // GET: StudentAssignments/Edit/5
        public ActionResult Edit(int? secid, int? aid, int? sid)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            StudentAssignment studentAssignment = db.StudentAssignments.Find(secid,aid,sid);
            if (studentAssignment == null)
            {
                return HttpNotFound();
            }
            ViewBag.assignment_id = new SelectList(db.Assignments, "assignment_id", "assignment_name", studentAssignment.assignment_id);
            ViewBag.section_id = new SelectList(db.Sections, "section_id", "day_of_week", studentAssignment.section_id);
            ViewBag.studentID = new SelectList(db.Students, "StudentID", "Fname", studentAssignment.studentID);
            return View(studentAssignment);
        }

        // POST: StudentAssignments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "section_id,assignment_id,studentID,grade")] StudentAssignment studentAssignment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentAssignment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.assignment_id = new SelectList(db.Assignments, "assignment_id", "assignment_name", studentAssignment.assignment_id);
            ViewBag.section_id = new SelectList(db.Sections, "section_id", "day_of_week", studentAssignment.section_id);
            ViewBag.studentID = new SelectList(db.Students, "StudentID", "Fname", studentAssignment.studentID);
            return View(studentAssignment);
        }

        // GET: StudentAssignments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssignment studentAssignment = db.StudentAssignments.Find(id);
            if (studentAssignment == null)
            {
                return HttpNotFound();
            }
            return View(studentAssignment);
        }

        // POST: StudentAssignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentAssignment studentAssignment = db.StudentAssignments.Find(id);
            db.StudentAssignments.Remove(studentAssignment);
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
