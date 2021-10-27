using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Data
{
    public class GradeLevel
    {
       [ Key, Required]
        public int GradeNumber { get; set; }
        [Required]
        public string GradeName { get; set; }
        [ForeignKey(nameof(Student))]
        public IEnumerable<Student> StudentList
        {
            get
            {
                using (var ctx = new ApplicationDbContext())
                {
                    var studentList = ctx.Students.Select
                        (e => new Student
                        {
                            StudentName = e.StudentName
                        }
                        );
                    return studentList.ToArray();
                }
            }
        }
        public virtual Student Student { get; set; }
    }
}
