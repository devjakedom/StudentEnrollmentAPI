using StudentEnrollment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Models
{
    public class GradeLevelList
    {
        public int GradeId { get; set; }
        public int GradeNumber { get; set; }
        public string GradeName { get; set; }
        public virtual ICollection<Student> StudentList { get; set; } = new List<Student>();
    }
}
