using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationPoster.Models
{
    public interface IStudentProvider
    {
        List<Student> StudentList { get; }
    }
}
