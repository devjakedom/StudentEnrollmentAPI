﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Models
{
    public class CreateEnrollment
    {
        
        public int StudentId { get; set; }
        
        public int StudentGrade { get; set; }
        
        public int CourseId { get; set; }
    }
}
