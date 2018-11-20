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
    public class StudentsController : Controller
    {
        private LMSDBEntities1 db = new LMSDBEntities1();

        // GET: Students
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentID,Fname,Lname,DOB")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentID,Fname,Lname,DOB")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
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

        public ActionResult ShowStudentClasses(int id)
        {

            if (id != null)
            {
                var quer = from s in db.Students
                           join r in db.Registereds on s.StudentID equals r.student_id
                           join sec in db.Sections on r.section_id equals sec.section_id
                           join cse in db.Courses on sec.course_id equals cse.course_id
                           join sem in db.Semesters on sec.semester_id equals sem.sem_id
                           where s.StudentID == id
                           select new
                           {
                               stud_id = s.StudentID,
                               stud_fname = s.Fname,
                               stud_lname = s.Lname,
                               sec_id = r.section_id,
                               sec_dow = sec.day_of_week,
                               sec_stim = sec.start_time,
                               sec_etim = sec.end_time,
                               sem_dsc = sem.sem_desc,
                               sem_sdt = sem.start_dt,
                               sem_edt = sem.end_dt,
                               cse_nm = cse.course_name,
                               cse_dsc = cse.course_desc,
                               cse_id = cse.course_id,
                               cse.Department.dept_desc
                           };


                List<Section> listofSections = new List<Section>();
                List<Course> listofCourses = new List<Course>();
                List<SelectListItem> listSectionCourse = new List<SelectListItem>();
                Student student = db.Students.Find(id);

                foreach (var item in quer)
                {
                    listofSections.Add(db.Sections.Find(Convert.ToInt32(item.sec_id)));
                    listofCourses.Add(db.Courses.Find(Convert.ToInt32(item.cse_id)));
                    //listSectionCourse.Add(db.Sections.Find(Convert.ToInt32(item.sec_id)),db.Courses.Find(Convert.ToInt32(item.cse_id)))
                }

                //List<SelectListItem> listSectionCourse = new List<SelectListItem>();
                //foreach (var item in quer)
                //{
                //    listSectionCourse.Add(new SelectListItem { Value = , Text = item.stud_id.ToString() });
                //}
                //ViewBag.stdregList = stdreg;

                ViewBag.Sections = listofSections;
                ViewBag.Courses = listofCourses;
                ViewBag.Student = student;
                ViewBag.Query = quer;

                return View(student);
            }
            else
            {
                return View("StudentLogins/Login");

            }

        }


    }
}
