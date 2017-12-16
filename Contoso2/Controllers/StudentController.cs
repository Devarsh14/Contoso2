using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso2.Models;
using Contoso2.ViewModels;

namespace Contoso2.Controllers
{
    public class StudentController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Student
        public ActionResult Index()
        {
            
            var student = db.Students.ToList();
            return View(student);

        }


        public ActionResult Details(int? id)
        {
            var student2 = db.Students.SingleOrDefault(c => c.ID == id);

            return View(student2);
        }

        public ActionResult New()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Student studentcreate)
        {
            if(studentcreate.ID==0)
            {
                db.Students.Add(studentcreate);
            }
            else
            {
                var studentIndb = db.Students.Single(c => c.ID == studentcreate.ID);
                studentIndb.LastName = studentcreate.LastName;
                studentIndb.FirstMidName = studentcreate.FirstMidName;
                studentIndb.EnrollmentDate = studentcreate.EnrollmentDate;
                

            }
            
            db.SaveChanges();

            return RedirectToAction("Index", "Student");
        }


        public ActionResult Edit(int id)
        {
            var student = db.Students.SingleOrDefault(c => c.ID == id);
                if (student == null)
                return HttpNotFound();



            return View("New",student);
        }
    }
}