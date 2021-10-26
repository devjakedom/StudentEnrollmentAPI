using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Models
{
    public class CreateStudent
    {
        [Required]
        public string StudentName { get; set; }
        [Required]
        public Guid StudentId { get; set; }
        [Required]
        public int StudentGradeLevel { get; set; }
    }
}
