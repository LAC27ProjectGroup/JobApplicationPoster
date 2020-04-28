using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using JobApplicationPoster.Database;
using JobApplicationPoster.Models;
using Microsoft.EntityFrameworkCore;


namespace JobApplicationPoster.Repositories
{
    public class JobRepository : IJobRepository
    {
        private JobContext _context;
        public JobRepository(JobContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetStudents()
        {
            return _context.StudentData.ToList();
        }

        public IEnumerable<Application> GetApplications(int id)
        {

            var result = (from app in _context.ApplicationData
                          where app.StudentId == id

                          select new Application
                          {
                              ApplicationId = app.ApplicationId,
                              StudentId = app.StudentId,
                              Company = app.Company,
                              JobTitle = app.JobTitle,
                              Location = app.Location,
                              Sticker = app.Sticker
                          }).ToList();

            return result;
        }

        public Student GetStudentById(int id)
        {
            return _context.StudentData.SingleOrDefault(c => c.AutoId == id);
        }

        public Application GetApplicationById(int id)
        {
            return _context.ApplicationData.SingleOrDefault(c => c.ApplicationId == id);
        }

        public void AddStudent(Student student)
        {
            _context.Add(student);
            _context.SaveChanges();
        }

        public void AddApplication(Application application)
        {
            _context.Add(application);
            _context.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var selectStudent = _context.StudentData.SingleOrDefault(c => c.AutoId == id);

            // need to delete this selected 
            var selectedApplication = from x in _context.ApplicationData
                         where x.StudentId == id
                         select x;

            _context.StudentData.Remove(selectStudent);
            _context.SaveChanges();
        }

        public void DeleteApplication(int id)
        {
            var selectApplication = _context.ApplicationData.SingleOrDefault(c => c.ApplicationId == id);
            _context.ApplicationData.Remove(selectApplication);
            _context.SaveChanges();
        }

        // Update total value in Student class
        public void UpdateTotalApplications(int id)
        {
            int result = (int)(from appli in _context.ApplicationData                          
                          where appli.StudentId == id
                          select appli.Sticker).Sum();

            var student = new Student { AutoId = id };
            student.StickerCount = result;
            _context.Entry(student).Property("Total").IsModified = true;
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        // creates sorted collection 
        public IQueryable<Student> PopulateStudentsDropDownList()
        {
            var students = from stu in _context.StudentData
                           orderby stu.FirstName
                           select stu;
            return students;
        }
    }
}
