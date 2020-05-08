using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationPoster.Models
{
    public class Student
    {
        [Key]
        public int AutoId { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string FirstName { get; set; }

        public int? StickerCount { get; set; }
        public virtual List<Application> ApplicationObj { get; set; }

/*        public Student()
        {
            ApplicationObj = GetApplications()
        }*/
    }
}
