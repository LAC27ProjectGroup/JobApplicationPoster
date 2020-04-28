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
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<Application> JobData { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>().HasData(
               new Job
               {
                   JobID = 1,
                   Name = "John Doe",
                   CompanyName = "Microsoft",
                   JobTitle = "SDE 1",
                   Location = "Redmond, WA",
                   Sticker = "Pink.png"
               });
        }*/
    }
}
