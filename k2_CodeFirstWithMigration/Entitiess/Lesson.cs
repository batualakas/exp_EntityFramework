using k2_CodeFirstWithMigration.Entitiess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigration.Entities
{
    public class Course

    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseNo { get; set; }


        #region Relations


        public int TeacherID { get; set; }
        public  Teacher Teacher { get; set; }

        public List<Student> Students { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }

        public List<Course> DepartmenCourses { get; set; }
        



        #endregion

    }
}
