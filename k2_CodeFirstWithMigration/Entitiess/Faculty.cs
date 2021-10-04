using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigration.Entities
{
    public class Faculty
    {
        public int FacultyID { get; set; }
        public string FacultyName { get; set; }

        public List<Department> Departments { get; set; }
        #region Methods
        public override string ToString()
        {
            return $"{this.FacultyName}";
        }

        #endregion
    }
}
