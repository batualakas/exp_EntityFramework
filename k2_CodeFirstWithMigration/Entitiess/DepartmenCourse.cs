using k2_CodeFirstWithMigration.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigration.Entitiess
{
    public class DepartmenCourse
    {

        [Key]
        [Column(Order =0)]
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
        [Key]
        [Column(Order =1)]
        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}
