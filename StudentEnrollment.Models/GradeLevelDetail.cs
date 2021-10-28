using StudentEnrollment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Models
{
    public class GradeLevelDetail
    {
        public int GradeId { get; set;}
        public int GradeNumber { get; set; }
        public string GradeName { get; set; }
        public IEnumerable<Student> StudentList { get; set; }
    }
}
