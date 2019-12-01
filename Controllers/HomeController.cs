using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Greeting = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.Username = "Ahmet";
            return View(); 
        }

        public IActionResult About()
        { return View(); }

    }
}
