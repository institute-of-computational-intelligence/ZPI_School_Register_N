using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SchoolRegister.BAL.Entities
{
    public class Student : User
    {
        [NotMapped]
        public double AverageGrade => Math.Round(Grades.Average(g => (int)g.GradeValue), 1);
        public IDictionary<string, double> AverangeGradePerSubject { get; }
        public IList<Grade> Grades { get; set; }
        public Group Group { get; set; }

        [ForeignKey("Group")]
        public int GroupId { get; set; }

        public Parent Parent { get; set; }
        [ForeignKey("Parent")]
        public int ParentId { get; set; }

    }
}
