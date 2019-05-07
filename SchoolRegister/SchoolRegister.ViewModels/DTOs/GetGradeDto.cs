using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SchoolRegister.ViewModels.DTOs
{
    public class GetGradeDto
    {
        [Required]
        public int StudentId { get; set; }
        [Required]
        public int GetterUserId { get; set; }
    }
}
