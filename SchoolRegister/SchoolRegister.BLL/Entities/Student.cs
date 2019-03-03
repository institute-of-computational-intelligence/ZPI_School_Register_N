using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Student : User
    {
        public double AvarageGrade { get; set; }
        public IDictionary<string, double> AvarageGradePerSubject { get;}
        public IList<Grade> Grades { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }
    }
}
