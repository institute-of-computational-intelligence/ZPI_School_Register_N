using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Teacher
    {
        public IList<Subject> Subjects
        { get; set; }
        public String Title
        { get; set; }
    }
}
