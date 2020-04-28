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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    AutoId = 1,
                    FirstName = "Benjamin",
                    StickerCount = 0
                },
                new Student
                {
                    AutoId = 2,
                    FirstName = "Daveena",
                    StickerCount = 0
                }
            );

            modelBuilder.Entity<Application>().HasData(
                new Application
                {
                    ApplicationId = 1,
                    StudentId = 1,
                    Company = "Amazon",
                    JobTitle = "Software Engineer",
                    Location = "Seattle",
                    Sticker = "forhire.png"
                }
            );
        }
    }
}
