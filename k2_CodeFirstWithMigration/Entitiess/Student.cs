using k2_CodeFirstWithMigration.Entitiess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigration.Entities
{
    public class Student
    {
        #region Properties

        
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int StudentNo { get; set; }
        public string Faculty { get; set; }
        public string TCKN { get; set; }
        #endregion



        #region Relations
        public int TeacherID { get; set; }

        public Teacher Teacher { get; set; }
        public int DepartmentID { get; set; }
        public Department Department { get; set; }

        public  List<Course> Courses { get; set; }
        public  List<StudentCourse> StudentCourses { get; set; }

        #endregion
    }
}
