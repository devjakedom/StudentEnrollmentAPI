
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

        public int GradeId { get; set; }

        [MaxLength(1000, ErrorMessage = "Please be concise")]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

    }
}
