using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Student: User
    {
        [NotMapped]
        public double AverangeGrade { get; }
        [NotMapped]
        public IDictionary<string, double> AverangeGradePerSubject { get; }
        public IList<Grade> Grades { get; set; }
        public Group Group { get; set; }
        public int GropupId { get; set; }
        public Parent Parent { get; set; }
        public int? ParentId { get; set; }
    }
}
