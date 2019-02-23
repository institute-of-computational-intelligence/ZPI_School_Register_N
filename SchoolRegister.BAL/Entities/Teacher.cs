using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BAL.Entities
{
    class Teacher : User
    {
        IList<Subject> Subjects { get; set; }
        string Title { get; set; }
    }
}
