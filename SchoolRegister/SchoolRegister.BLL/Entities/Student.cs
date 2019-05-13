using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace SchoolRegister.BLL.Entities
{
    public class Student : User
    {
        public IDictionary<string, double> AverageGradePerSubject
        { get; }
        public IList<Grade> Grades
        { get; set; }
        [NotMapped]
        public double AverageGrade => Math.Round(Grades.Average(g => (int)g.GradeValue), 1);
        public Group Group
        { get; set; }
        [ForeignKey("Group")]
        public int GroupId
        { get; set; }
    }
}
