using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JobApplicationPoster.Models;
using JobApplicationPoster.Services;

namespace JobApplicationPoster.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        IStudentProvider _studentProvider;

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
            List<string> studentNames = new List<string>() { "Benjamin", "Daveena", "Demitrius", "Elias", "Emily", "Franck", "Hyoil", "Kiran", "Paul", "Raphael", "Raven", "Taylor", "Thomas" };
            ViewBag.StudentNames = studentNames;
            ViewBag.Students = _studentProvider.StudentList;
            return View();
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
