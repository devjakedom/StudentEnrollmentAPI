using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Data
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string CourseDescription { get; set; }
        public string CourseName { get; set; }

        [ForeignKey(nameof(GradeLevel))]
        public int GradeNumber { get; set; }
        public virtual GradeLevel GradeLevel { get; set; }
        /*
          stretch goals
        //course start
        [Required]
        public DateTime StartDate { set; get; }

        //course end
        [Required]
        public DateTime EndDate { set; get; }
        //currently running
        public bool InSession
        {
            get
            {
                System.TimeSpan diff = EndDate.Subtract(DateTime.Now);
                int days = diff.Days;
                if (days > 0)
                { return true; }
                else { return false; }

            }
        }
        */
    }
}
