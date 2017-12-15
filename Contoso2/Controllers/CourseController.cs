using Contoso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contoso2.Controllers
{
    public class CourseController : Controller
    {
        private ApplicationDbContext db= new ApplicationDbContext();
        // GET: Course
        public ActionResult Index()
        {
            var courselist = db.Courses.ToList();


            return View(courselist);
        }

        public ActionResult Details(int id)
        {

            var CourseDetails = db.Courses.SingleOrDefault(c=>c.CourseID==id);
            return View(CourseDetails);
        }

        public ActionResult New()
        {
            return View();
        }
    }
}