using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class CourseAndListOfUFD
    {
            public Course Course { get; set; }
            public IEnumerable<Department> Departments { get; set; }
            public IEnumerable<Faculty> Faculties { get; set; }
            public IEnumerable<University> Universities { get; set; }
    }
}
