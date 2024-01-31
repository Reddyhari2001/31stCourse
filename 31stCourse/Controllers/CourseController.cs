using _31stCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _31stCourse.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> Courses = new List<Course>()
        {
            new Course{CId=101,CName="Programming",CFee=5000,Technology="C#",StartDate = DateTime.Now, EndDate=DateTime.Now.AddMonths(3)},
            new Course{CId=102,CName="WebDevelopment",CFee=1000,Technology="Html,Css",StartDate = DateTime.Now, EndDate=DateTime.Now.AddMonths(1)}
        };
        public ActionResult Index()
        {
            return View(Courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        [HttpPost]
        public ActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                Courses.Add(course);
                return RedirectToAction("Index");
            }
            return View(course);
        }
    }
}