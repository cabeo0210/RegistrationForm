using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationForm.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View("myView");
        }

        public IActionResult Register() {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Student student) {
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else {
                return View();
            }
        }
        public IActionResult StudentList() {
            return View(Repository.GetStudents());
        }
    }
}