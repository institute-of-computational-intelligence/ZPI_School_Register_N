﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolRegister.BLL.Entities
{
    public class Grade
    {
        public DateTime DateOfIssue { get; set; }
        public GradeScale GradeValue { get; set; }
        public virtual Subject Subject { get; set; }
        
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
