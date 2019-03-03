using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolRegister.BAL.Entities
{
    public class Subject
    {
        public string Descryption { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public  Teacher Teacher { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }

        public IList<Group> Groups { get; set; }


    }
}
