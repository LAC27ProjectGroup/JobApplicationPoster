using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JobApplicationPoster.Models;
using Microsoft.AspNetCore.Http;

namespace JobApplicationPoster.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly IStudentProvider _studentProvider;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(IStudentProvider studentProvider)
        {
            _studentProvider = studentProvider;
        }

        public IActionResult Index()
        {
            StudentNames sn = new StudentNames
            {
                studentNames = new List<string>() { "Benjamin", "Daveena", "Demitrius", "Elias", "Emily", "Franck", "Hyoil", "Kiran", "Paul", "Raphael", "Raven", "Taylor", "Thomas", "Tyler" }
            };

            //TEST: Elias
            Dictionary<string, List<string>> stickers = new Dictionary<string, List<string>>();
            stickers.Add("Elias", new List<string> { "stickers/red.png", "stickers/orange.png" });
            stickers.Add("Emily", new List<string> { "stickers/green.png", "stickers/purple.png" });
            stickers.Add("Thomas", new List<string> { "stickers/blue.png", "stickers/black.png" });
            ViewBag.Stickers = stickers;

            ViewBag.StudentNames = sn.studentNames;
            ViewBag.Students = _studentProvider.StudentList;
            //ViewBag.SelectedStudent = sn.SelectedName;
            //string selectedStudent = Request.Form["StudentNamesList"].ToString();
            //ViewBag.SelectedStudent = selectedStudent;
            return View(sn);
        }

        // Trying to save the selected student from the dropdown
        //[HttpPost]
        //public IActionResult Index(StudentNames sn)
        //{
        //    ViewBag.Hello = "Hello World!";
        //    string selectedStudent = Request.Form["StudentNamesList"].ToString();
        //    ViewBag.SelectedStudent = selectedStudent;
        //    return View(sn);
        //}

        public IActionResult SelectStudent(StudentNames sn)
        {
            ViewBag.SelectedStudent = sn.SelectedName;
            var position = sn.studentNames.IndexOf(sn.SelectedName); // NullReferenceException...
            ViewBag.StudentPosition = position;
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
