using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationPoster.Models
{
    public class Job
    {
        [Key]
        public int JobID { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        
        public string Name { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Please enter the company name.")]
        public string CompanyName { get; set; }

        [Display(Name = "Job Title")]
        [Required(ErrorMessage = "Please enter the Job title.")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Please enter the job location.")] 
        public string Location { get; set; }

        [Required(ErrorMessage = "Please select a sticker.")]
        public string Sticker { get; set; }

    }
}
