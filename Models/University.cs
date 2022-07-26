using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class University
    {
        [Key]
        public int UniversityId { get; set; }

        [Display(Name ="University Name")]
        public string UniversityName { get; set; }
        [Display(Name = "Logo")]
        public byte[] UniversetyPhotoLink { get; set; }

        public string Description { get; set; }
        public IEnumerable<Faculty> FacultyList { get; set; }
    }
}
