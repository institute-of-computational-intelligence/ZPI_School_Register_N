using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Student : User
    {
        public double AverageGrade { get; set; }
        public IDictionary<string, double> AverageGradePerSubject{get; }
        public IList<Grade> Grades { get; set; }
        public Group Group { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public Parent Parent { get; set; }
        public int? ParentId { get; set; }
        /*   [NotMapped]
           public double AverageGrade => Math.Round(Grades.Average(g => (int)g.GradeValue), 1); */
    }
}
