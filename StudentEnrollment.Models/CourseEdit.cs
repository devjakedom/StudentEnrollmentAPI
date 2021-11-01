using StudentEnrollment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Models
{
    public class CourseEdit
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int GradeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    } 
}
