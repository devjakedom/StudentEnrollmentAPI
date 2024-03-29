﻿using System;
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
        public int CourseId { get; set; }
        public string CourseDescription { get; set; }
        public string CourseName { get; set; }
        public virtual GradeLevel GradeLevel { get; set; }

        [ForeignKey(nameof(GradeLevel))]
        public int GradeId { get; set; }


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
            set
            {
                bool val = true;
                System.TimeSpan diff = EndDate.Subtract(DateTime.Now);
                int days = diff.Days;
                if (days > 0)
                { val = value; }
                else
                {
                    val = false;
                    val = value;
                }

            }
        }

    }
}
