using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Models
{
    public class EnrollmentListItem
    {
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }

        public int StudentGrade { get; set; }

        public int CourseId { get; set; }
    }
}
