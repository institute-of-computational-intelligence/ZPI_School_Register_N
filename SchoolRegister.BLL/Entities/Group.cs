using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Group
    {
        public IEnumerable<Student> Students { get; set; }
        int ID { get; set; }
        [Required]
        string Name { get; set; }
    }
}
