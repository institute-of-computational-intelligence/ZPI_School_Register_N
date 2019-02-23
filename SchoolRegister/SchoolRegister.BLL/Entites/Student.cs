using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entites
{
    class Student : User
    {
        double AverageGrade { get; set; }
        IDictionary<string, double> AverageGradePerSubject{get; }
        IList<Grade> Grades { get; set; }
        Group Group { get; set; }

    }
}
