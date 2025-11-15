using Microsoft.EntityFrameworkCore;
using System;
using ass1_ef__core.ItiModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_ef__core.DatabseContext
{
    internal class ItiDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITIDatabase;Trusted_Connection=true;TrustServerCertificate=true");
        }
        public DbSet<Course> Courses {  get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student>students { get; set; }
        
        
    }
}
