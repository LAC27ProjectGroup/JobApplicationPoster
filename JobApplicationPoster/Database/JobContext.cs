using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobApplicationPoster.Models;

namespace JobApplicationPoster.Database
{
    public class JobContext: DbContext
    {
        public DbSet<Student> StudentData { get; set; }
        public DbSet<Application> ApplicationData { get; set; }

        public JobContext(DbContextOptions<JobContext> options) : base(options)
        {
        }
    }
}
