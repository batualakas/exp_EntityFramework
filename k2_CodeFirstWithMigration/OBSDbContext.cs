using k2_CodeFirstWithMigration.Entities;
using k2_CodeFirstWithMigration.Entitiess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigration
{
    public class OBSDbContext :DbContext
    
    {
        public OBSDbContext()
        {
            this.Database.Connection.ConnectionString = "Server=.;Database=OBSDbBatu;User Id=sa;Password=123;";

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmenCourse> DepartmenCourse { get; set; }
        public DbSet<Faculty> Faculties { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }
}
