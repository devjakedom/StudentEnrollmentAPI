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
       [Key]
        public int GradeId { get; set; }
        public int GradeNumber { get; set; }
        
        public string GradeName { get; set; }
        public virtual Student Student { get; set; }
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
    }
}
