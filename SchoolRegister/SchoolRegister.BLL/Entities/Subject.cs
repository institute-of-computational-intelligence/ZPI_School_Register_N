using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Subject
    {
        [Required]
        public string Description { get; set; }
        public virtual IList<Grade> Grades { get; set; }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual IList<SubjectGroup> SubjectGroups { get; set; }
        public Teacher Teacher { get; set; }
        [ForeignKey("TeacherId")]
        public int TeacherId { get; set; }
    }
}
