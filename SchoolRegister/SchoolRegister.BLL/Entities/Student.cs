using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Student: User
    {
        [NotMapped]
        public double AverangeGrade { get; set; }
        public IDictionary<string, double> AverangeGradePerSubject { get; set; }
        public IList<Grade> Grades { get; set; }
        public Group Group { get; set; }
        public int GropupId { get; set; }
    }
}
