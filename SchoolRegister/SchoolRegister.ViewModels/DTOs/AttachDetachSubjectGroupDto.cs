using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SchoolRegister.ViewModels.DTOs
{
        public class AttachDetachSubjectGroupDto
        {
            [Required]
            public int SubjectId { get; set; }
            [Required]
            public int GroupId { get; set; }
        }
}
