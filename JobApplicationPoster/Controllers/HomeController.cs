using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using JobApplicationPoster.Models;
using JobApplicationPoster.Repositories;

namespace JobApplicationPoster.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IJobRepository _repository;

        public HomeController(IJobRepository repository, ILogger<HomeController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_repository.GetStudents());
        }

        // Add new Student
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student, Application appli)
        {
            if (!ModelState.IsValid)
                return View();

            _repository.AddStudent(student);
            _repository.SaveChanges();

            return RedirectToAction("Index");
        }

        // Display Applications
        public IActionResult Applications(int id)
        {
            ViewBag.StuId = id;
            ViewBag.StudentName = _repository.GetStudentById(id).FirstName;
            return View(_repository.GetApplications(id));
        }

        // Add new Application
        [HttpGet]
        public IActionResult CreateApplication()
        {
            return View();
        }

        [HttpPost, ActionName("CreateApplication")]
        public IActionResult CreateApplication(Application app, int id)
        {
            app.StudentId = id;
            app.Sticker = "forhire.png";

            ViewBag.StuId = id;
            var selectedStudent = _repository.GetStudentById(id);
            ViewBag.StudentName = selectedStudent.FirstName;

            _repository.AddApplication(app);
            _repository.UpdateTotalApplications(id);

            return View("Applications", _repository.GetApplications(id));
        }

        // Delete Application
        [HttpPost, ActionName("DeleteApplication")]
        public IActionResult DeleteApplication(int appId, int id)
        {
            _repository.DeleteApplication(appId);
            _repository.UpdateTotalApplications(id);

            //return RedirectToAction("Applications", _repository.GetApplications(id));
            return RedirectToAction("Index");
        }

        // Edit Application
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var application = _repository.GetApplicationById(id);
            if (application == null)
            {
                return NotFound();
            }

            return View();
        }

        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> EditReturn(int id)
        {
            var application = _repository.GetApplicationById(id);
            bool isUpdated = await TryUpdateModelAsync<Application>(
                application, "",
                c => c.Company,
                c => c.JobTitle,
                c => c.Location);
            if (isUpdated == true)
            {
                _repository.SaveChanges();
                return RedirectToAction("Index");
            }

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
