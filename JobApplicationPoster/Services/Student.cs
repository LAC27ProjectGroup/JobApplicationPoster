using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationPoster.Services
{
    public class Student
    {
        public string FirstName { get; private set; }
        public int StickerCount { get; private set; }

        public Student(string firstName)
        {
            FirstName = firstName;
            StickerCount = 0;
        }
    }
}
