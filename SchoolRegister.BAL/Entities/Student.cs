using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BAL.Entities
{
    class Student : User
    {
        double AverageGrade { get; }
        IDictionary<string, double> AverangeGradePerSubject { get; }
        IList<Grade> Grades { get; set; }

        Group Group { get; set; }
    }
}
