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
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student("Benjamin"));
            studentList.Add(new Student("Daveena"));
            studentList.Add(new Student("Demitrius"));
            studentList.Add(new Student("Elias"));
            studentList.Add(new Student("Emily"));
            studentList.Add(new Student("Franck"));
            studentList.Add(new Student("Hyoil"));
            studentList.Add(new Student("Kiran"));
            studentList.Add(new Student("Paul"));
            studentList.Add(new Student("Raphael"));
            studentList.Add(new Student("Raven"));
            studentList.Add(new Student("Taylor"));
            studentList.Add(new Student("Thomas"));
            studentList.Add(new Student("Tyler"));

            return studentList;
        }
    }
}
