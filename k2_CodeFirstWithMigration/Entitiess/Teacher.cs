using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigration.Entities
{
    public class Teacher
    {
        #region Properties

        
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        
        public string Faculty { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        #endregion
    }
}
