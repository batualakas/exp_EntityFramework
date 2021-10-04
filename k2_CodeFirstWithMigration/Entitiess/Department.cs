using k2_CodeFirstWithMigration.Entitiess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigration.Entities
{
   public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        #region Relations
        public int FacultyID { get; set; }
        public Faculty Faculty { get; set; }
        public List<Student> Students { get; set; }
        public List<DepartmenCourse> DepartmenCourses { get; set; }

        #endregion
        #region Methods
        public override string ToString()
        {
            return $"{this.DepartmentName}";
        }
        #endregion
    }
}
