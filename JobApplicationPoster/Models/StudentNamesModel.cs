using JobApplicationPoster.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationPoster.Models
{
    public class StudentNamesModel
    {
        public List<string> studentNames;
        public string SelectedName { get; set; }
    }
}
