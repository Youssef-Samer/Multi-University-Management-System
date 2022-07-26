using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Display(Name = "Faculty Name")]
        public string FacultyName { get; set; }

        [Display(Name = "University Name")]
        public string UniversityName { get; set; }
        public int UniversityId { get; set; }
        public int FacultyId { get; set; }

        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }


    }
}
