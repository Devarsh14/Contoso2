using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso2.Models;

namespace Contoso2.Controllers
{
    public class StudentController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Student
        public ActionResult Index()
        {
            var Students =db.Students.ToList();
            return View(Students);
        }


        public ActionResult Details(int? id)
        {
            var student2 = db.Students.SingleOrDefault(c => c.ID == id);

            return View(student2);
        }
    }
}