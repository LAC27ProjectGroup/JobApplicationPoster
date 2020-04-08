using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationPoster.Services
{
    public class Student
    {
        public string FirstName { get; set; }
        public int StickerCount { get; set; }

        public Student(string firstName)
        {
            FirstName = firstName;
            StickerCount = 0;
        }
    }
}
