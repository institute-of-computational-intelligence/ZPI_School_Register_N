using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolRegister.BLL.Entities
{
    public class Grade
    {
        [Key]
        public DateTime DateOfIssue { get; set; }
        public GradeScale GradeValue { get; set; }
        public Subject Subject { get; set; }
    }
}
