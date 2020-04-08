using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationPoster.Services
{
    public class StudentProvider : IStudentProvider
    {
        public List<Student> StudentList { get; private set; }

        public StudentProvider()
        {
            StudentList = StudentInitializer();
        }

        private List<Student> StudentInitializer() 
        {
            List<Student> studentList = new List<Student>
            {
                new Student("Benjamin"),
                new Student("Daveena"),
                new Student("Demitrius"),
                new Student("Elias"),
                new Student("Emily"),
                new Student("Franck"),
                new Student("Hyoil"),
                new Student("Kiran"),
                new Student("Paul"),
                new Student("Raphael"),
                new Student("Raven"),
                new Student("Taylor"),
                new Student("Thomas"),
                new Student("Tyler")
            };

            return studentList;
        }
    }
}
