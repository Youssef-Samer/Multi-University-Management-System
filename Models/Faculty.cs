using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Faculty
    {
        [Key]
        public int FacultyId { get; set; }
        [ForeignKey("University")]

        [Display(Name ="University Name")]
        public int UniverstyId { get; set; }
        [Display(Name = "Faculty Name")]
        public string FacultyName { get; set; }
        [Display(Name = "University Name")]
        public string UniversityName { get; set; }
        public IEnumerable<Department> DepartmentList { get; set; }
        public string Description { get; set; }
        [Display(Name = "Area Of Expertise")]
        public string AreaOfExpertise { get; set; }
    }
}
