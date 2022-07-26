using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Display(Name = "User Name")]
        public string AdminUserName { get; set; }
        [Display(Name = "Password")]
        public string AdminPassword { get; set; }
    }
}
