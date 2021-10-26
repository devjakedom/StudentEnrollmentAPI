using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Models
{
    public class StudentList
    {
        public string StudentName
        {
            get; set;
        }
        public Guid StudentId
        {
            get; set;
        }
        public int StudentGradeLevel
        {
            get; set;
        }
     }
}
