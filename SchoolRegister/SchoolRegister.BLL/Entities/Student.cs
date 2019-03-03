using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Student : User
    {

        IDictionary<string, double> AverageGradePerSubject{get; }
        IList<Grade> Grades { get; set; }
        Group Group { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }

     /*   [NotMapped]
        public double AverageGrade => Math.Round(Grades.Average(g => (int)g.GradeValue), 1); */
    }
}
