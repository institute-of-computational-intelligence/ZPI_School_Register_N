using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    class Student
    {
        public double AverangeGrade { get; set; }
        public IDictionary<string, double> AverangeGradePerSubject { get; set; }
        public IList<Grade> Grades { get; set; }
        public Group Group { get; set; }
    }
}
