using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Student : User
    {
        public double AverageGrade { get; }
        public IDictionary<string, double> AverageGradePerSubject { get; }
        public IList<Grade> Grades { get; set; }
        public Group Group { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public Parent Parent { get; set; }
        public int? ParentId { get; set; }
        
        

    }
}
