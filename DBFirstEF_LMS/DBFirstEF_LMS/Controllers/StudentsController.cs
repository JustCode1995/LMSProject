using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Dynamic;
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

        public ActionResult ShowStudentClasses(int? id)
        {
            int? sid = Convert.ToInt32(Session["sv_studentLogin"]);
            if (sid != null && sid != 0)
            {
                ////var query = from s in db.Students
                ////           join r in db.Registereds on s.StudentID equals r.student_id
                ////           join sec in db.Sections on r.section_id equals sec.section_id
                ////           join cse in db.Courses on sec.course_id equals cse.course_id
                ////           join sem in db.Semesters on sec.semester_id equals sem.sem_id
                ////           where s.StudentID == id
                ////           select new
                ////           {
                ////               stud_id = s.StudentID,
                ////               stud_fname = s.Fname,
                ////               stud_lname = s.Lname,
                ////               sec_id = r.section_id,
                ////               sec_dow = sec.day_of_week,
                ////               sec_stim = sec.start_time,
                ////               sec_etim = sec.end_time,
                ////               sem_dsc = sem.sem_desc,
                ////               sem_sdt = sem.start_dt,
                ////               sem_edt = sem.end_dt,
                ////               cse_nm = cse.course_name,
                ////               cse_dsc = cse.course_desc,
                ////               cse_id = cse.course_id,
                ////               cse.Department.dept_desc
                ////           };

                // query
                var q = from s in db.Students
                        join r in db.Registereds on s.StudentID equals r.student_id
                        join sec in db.Sections on r.section_id equals sec.section_id
                        join cse in db.Courses on sec.course_id equals cse.course_id
                        join sem in db.Semesters on sec.semester_id equals sem.sem_id
                        where s.StudentID == sid
                        group sec by new { sec.course_id, sec.section_id, cse.course_name, sec.day_of_week, sec.start_time, sec.end_time, s.StudentID, s.Fname, s.Lname } into gp
                        select new
                        {
                            gp.Key.course_name, gp.Key.course_id, gp.Key.day_of_week, gp.Key.start_time, gp.Key.end_time, gp.Key.StudentID, gp.Key.Fname, gp.Key.Lname, gp.Key.section_id
                        };

                // create dynamic model to fix lack of reflection in anonymous type
                List <ExpandoObject> classList = new List<ExpandoObject>();
                List<Object> courseList = new List<Object>();
                List<Object> listview = new List<Object>();
                foreach (var v in q)
                {
                    IDictionary<string, object> itemExpando = new ExpandoObject();
                    foreach(PropertyDescriptor prop in TypeDescriptor.GetProperties(v.GetType()))
                    {
                        itemExpando.Add(prop.Name, prop.GetValue(v));
                    }
                    classList.Add(itemExpando as ExpandoObject);
                    courseList.Add(v);
                }

                dynamic model = new ExpandoObject();
                model.listofclasses = classList;

                //
                Student student = db.Students.Find(sid);
                ViewBag.studentName = student.Fname + " " + student.Lname;

                return View(model);
            }
            else
            {
                return RedirectToAction("Login", "StudentLogins");
            }

        }

        public ActionResult ShowGPA()
        {
            double gpa = 0;
            int count = 1;

            int? sid = Convert.ToInt32(Session["sv_studentLogin"]);
            if (sid == null || sid == 0)
            {
                ViewBag.Message = "Please login to view GPA.";
                return View();
            }
            else {
                ViewBag.Message = "Your current year-to-date GPA is: ";
                  }
            //////var query = from r in db.Registereds
            //////            where r.student_id == id
            //////            group r by new { r.student_id, r.section_id } into nGroup
            //////            select new
            //////            {
            //////                section_id = nGroup.Key.section_id,
            //////                Total = nGroup.Sum(x)
            //////            }

            var query = from r in db.Registereds
                        where r.student_id == sid
                        select new
                        {
                            grade = r.grade
                        };
            foreach (var g in query)
            {

                count++;
                if (g.grade >= 90 && g.grade <= 100)
                {
                    gpa += 4.0;
                }
                else if (g.grade >= 80 && g.grade <= 89)
                {
                    gpa += 3.0;
                }
                else if (g.grade >= 70 && g.grade <= 79)
                {
                    gpa += 2.0;
                }
                else if (g.grade >= 60 && g.grade <= 69)
                {
                    gpa += 1.0;
                }
                else if (g.grade < 60)
                {
                    gpa += 0.0;
                }
            }

            gpa = gpa / (count - 1);
            ViewBag.gpa = gpa;

            return View();
        }

        public ActionResult StudentClass(int? id)
        {
            int? sid = Convert.ToInt32(Session["sv_studentLogin"]);
            if (sid == null || sid == 0)
            {
                ViewBag.Message = "Please login to view classes.";
                return View();
            }
            else
            {
                int? sectionid = id;
                if (id == null)
                {
                    var student_Assignment = db.StudentAssignments.Include(s => s.Assignment.Section.Course).Include(s => s.Assignment).Include(s => s.Section).Include(s => s.Student).Where(s => s.studentID == sid);
                    return View(student_Assignment.ToList());
                }
                else
                {
                    var student_Assignment = db.StudentAssignments.Include(s => s.Assignment.Section.Course).Include(s => s.Assignment).Include(s => s.Section).Include(s => s.Student).Where(s => s.studentID == sid && s.section_id == sectionid);
                    return View(student_Assignment.ToList());
                }
            }
        }


    }
}
