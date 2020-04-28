using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationPoster.Models
{
    public class Application
    {
        [Key]
        public int ApplicationId { get; set; }

        [Display(Name = "Company Name")]
        public string Company { get; set; }

        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        public string Location { get; set; }
        public string Sticker { get; set; }

        public int? StudentId { get; set; }
        [ForeignKey("StudentIdentification")]

        public virtual Student StudentObj { get; set; }
    }
}
