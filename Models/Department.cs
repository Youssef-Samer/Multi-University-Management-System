using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Department
    {
        [Key]
        [Display(Name = "Department Name")]
        public int DepartmentId { get; set; }
        [Display(Name = "University Name")]
        public int UniversityId { get; set; }
        [Display(Name = "Faculty Name")]
        public string FacultyName { get; set; }

        [ForeignKey("Faculty")]
        public int FacultyId { get; set; }

        [Display(Name = "University Name")]
        public string UniversityName { get; set; }

        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }
    }
}
