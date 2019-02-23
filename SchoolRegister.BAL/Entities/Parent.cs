using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BAL.Entities
{
    class Parent : User
    {
        IList<Student> Students { get; set; }
    }
}
