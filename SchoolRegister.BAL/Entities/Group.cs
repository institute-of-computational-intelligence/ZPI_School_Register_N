using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolRegister.BAL.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Student> Students { get; set; }

        public Subject Subject { get; set; }
        [ForeignKey("Subject")]
        public int SubjectID { get; set; }

    }
}
