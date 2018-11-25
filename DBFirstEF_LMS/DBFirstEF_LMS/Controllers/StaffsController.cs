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

namespace DBFirstEF_LMS
{
    public class StaffsController : Controller
    {
        private LMSDBEntities1 db = new LMSDBEntities1();

        // GET: Staffs
        public ActionResult Index()
        {
            var staffs = db.Staffs.Include(s => s.Department).Include(s => s.StaffLogin);
            return View(staffs.ToList());
        }

        // GET: Staffs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff staff = db.Staffs.Find(id);
            if (staff == null)
            {
                return HttpNotFound();
            }
            return View(staff);
        }

        // GET: Staffs/Create
        public ActionResult Create()
        {
            ViewBag.dept_id = new SelectList(db.Departments, "dept_id", "dept_name");
            ViewBag.staff_id = new SelectList(db.StaffLogins, "staff_id", "staff_pwd");
            return View();
        }

        // POST: Staffs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "staff_id,dept_id,first_name,last_name,date_hired,access_level")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                db.Staffs.Add(staff);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.dept_id = new SelectList(db.Departments, "dept_id", "dept_name", staff.dept_id);
            ViewBag.staff_id = new SelectList(db.StaffLogins, "staff_id", "staff_pwd", staff.staff_id);
            return View(staff);
        }

        // GET: Staffs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff staff = db.Staffs.Find(id);
            if (staff == null)
            {
                return HttpNotFound();
            }
            ViewBag.dept_id = new SelectList(db.Departments, "dept_id", "dept_name", staff.dept_id);
            ViewBag.staff_id = new SelectList(db.StaffLogins, "staff_id", "staff_pwd", staff.staff_id);
            return View(staff);
        }

        // POST: Staffs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "staff_id,dept_id,first_name,last_name,date_hired,access_level")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staff).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.dept_id = new SelectList(db.Departments, "dept_id", "dept_name", staff.dept_id);
            ViewBag.staff_id = new SelectList(db.StaffLogins, "staff_id", "staff_pwd", staff.staff_id);
            return View(staff);
        }

        // GET: Staffs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff staff = db.Staffs.Find(id);
            if (staff == null)
            {
                return HttpNotFound();
            }
            return View(staff);
        }

        // POST: Staffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Staff staff = db.Staffs.Find(id);
            db.Staffs.Remove(staff);
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

        public ActionResult ShowTeacherClasses(int? id)
        {
            int? sid = Convert.ToInt32(Session["sv_staffLogin"]);
            if (sid != null && sid != 0)
            {
                var q = from s in db.Staffs
                        join sec in db.Sections on s.staff_id equals sec.teacher_id
                        join cse in db.Courses on sec.course_id equals cse.course_id
                        where s.staff_id == sid
                        group sec by new { sec.course_id, sec.section_id, cse.course_name, sec.day_of_week, sec.start_time, sec.end_time, s.staff_id, s.first_name, s.last_name } into gp
                        select new
                        {
                            gp.Key.course_name,
                            gp.Key.course_id,
                            gp.Key.day_of_week,
                            gp.Key.start_time,
                            gp.Key.end_time,
                            gp.Key.staff_id,
                            gp.Key.first_name,
                            gp.Key.last_name,
                            gp.Key.section_id
                        };

                // create dynamic model to fix lack of reflection in anonymous type
                List<ExpandoObject> classList = new List<ExpandoObject>();
                List<Object> courseList = new List<Object>();
                List<Object> listview = new List<Object>();
                foreach (var v in q)
                {
                    IDictionary<string, object> itemExpando = new ExpandoObject();
                    foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(v.GetType()))
                    {
                        itemExpando.Add(prop.Name, prop.GetValue(v));
                    }
                    classList.Add(itemExpando as ExpandoObject);
                    courseList.Add(v);
                }

                dynamic model = new ExpandoObject();
                model.listofclasses = classList;

                //
                Staff staff = db.Staffs.Find(sid);
                ViewBag.staffName = staff.first_name + " " + staff.last_name;

                return View(model);
            }
            else
            {
                return RedirectToAction("Login", "StaffLogins");
            }
        }

        public ActionResult StaffClass(int? id)
        {
            int? sid = Convert.ToInt32(Session["sv_staffLogin"]);
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
                    var staff_assignment = db.Assignments.Include(a => a.Section.Course).Include(a => a.Section).Include(a => a.Section.Staff).Where(a => a.Section.Staff.staff_id == sid);
                    return View(staff_assignment);
                }
                else
                {
                    var staff_assignment = db.Assignments.Include(a => a.Section.Course).Include(a => a.Section).Include(a => a.Section.Staff).Where(a => a.Section.Staff.staff_id == sid && a.section_id == sectionid);
                    return View(staff_assignment);
                }
            }
        }



    }
}
