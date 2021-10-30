using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Data
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }

        public virtual Student Student { get; set; }
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        //public virtual GradeLevel GradeLevel { get; set; }
        //[ForeignKey(nameof(GradeLevel))]
        public int GradeId { get; set; }
        public virtual Course Course { get; set; }
        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }

        


        //public Guid OwnerId { get; set; }

    }
}
