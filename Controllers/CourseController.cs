﻿using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {

        public IActionResult Index()
        { return View(); }


        public IActionResult List()
        {
            var students = Repository.Students.Where(i => i.Confirm == true);
            return View(students);

        }


        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Apply(Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else
            {
                return View(student);
            }
        }


        public IActionResult Details()
        {
            var course = new Course();
            course.Name = "Core MVC";
            course.Description = "iyi güzel";
            course.IsPublished = true;
            return View(course);
        }

    }
}
