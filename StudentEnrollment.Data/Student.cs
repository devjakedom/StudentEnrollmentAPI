using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }

        public virtual GradeLevel GradeLevel { get;set; }
        [ForeignKey(nameof(GradeLevel))]
        
        public int GradeId { get; set; }
    }
}
