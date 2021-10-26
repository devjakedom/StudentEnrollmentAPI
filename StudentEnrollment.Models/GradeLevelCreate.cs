using StudentEnrollment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Models
{
    public class GradeLevelCreate
    {
        public int GradeNumber { get; set; }
        public string GradeName { get; set; }
        public List<Student> StudentList { get; set; }
    }
}
