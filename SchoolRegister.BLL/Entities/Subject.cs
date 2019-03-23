using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    class Subject
    {
         [Required]
        string Description { get; set; }
        int ID { get; set; }
        [Required]
        string Name { get; set; }
        Teacher Teacher { get; set; }
    }
}
