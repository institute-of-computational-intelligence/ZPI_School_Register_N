using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Subject
    {
        public String Description
        { get; set; }
        public int Id
        { get; set; }
        public String Name
        { get; set; }
        public Teacher Teacher
        { get; set; }
    }
}
