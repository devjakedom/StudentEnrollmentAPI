﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Models
{
    public class CourseDetail
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool InSession { get; set; }
    }
}
