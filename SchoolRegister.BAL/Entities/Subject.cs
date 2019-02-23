using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BAL.Entities
{
    class Subject
    {
        string Descryption { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        Teacher Teacher { get; set; }
    }
}
