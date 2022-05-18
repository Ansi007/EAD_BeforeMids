using Microsoft.AspNetCore.Mvc;
using MVC_PRACTICE.Models;
using System.Diagnostics;

namespace MVC_PRACTICE.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SignUp(Student s)
        {
            StudentRepositry.AddStudent(s);
            return View("Thanks",s);
        }

        public ViewResult ListStudents()
        {
            if(StudentRepositry.students.Count > 0)
            {
                Student u = StudentRepositry.students[0];
                ViewBag.user1 = u;
            }
            return View(StudentRepositry.students);
        }
    }
}