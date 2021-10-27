
using StudentEnrollment.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Models
{
    public class CourseCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Enter Course Info")]
        [MaxLength(100, ErrorMessage = "Limit Yourself")]

        public string CourseName { get; set; }
        [Required]
        public GradeLevel GradeLevel { get; set; }
        public string Description { get; set; }

    }
}
