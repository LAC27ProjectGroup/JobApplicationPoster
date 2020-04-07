using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationPoster.Services
{
    public interface IStudentProvider
    {
        List<Student> StudentList { get; }
    }
}
