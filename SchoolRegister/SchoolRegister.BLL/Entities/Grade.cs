using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Grade
    {
        public DateTime DateOfIssue { get; set; }
        public GradeScale GradeValue { get; set; }

        public Subject Subject { get; set; }

        public int SubjectId { get; set; }

        public Student Student { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }
    }
}
