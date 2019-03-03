using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    class Subject
    {
        string Description { get; set; }
        int ID { get; set; }
        string Name { get; set; }
        Teacher Teacher { get; set; }
    }
}
