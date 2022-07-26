using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<University> University { get; set; }
        public DbSet<Faculty> Faculty { get; set; }

        public DbSet<Course> Course { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
