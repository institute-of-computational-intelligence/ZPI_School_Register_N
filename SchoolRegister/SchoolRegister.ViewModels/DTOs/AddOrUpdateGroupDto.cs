using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SchoolRegister.ViewModels.DTOs
{
    public class AddOrUpdateGroupDto
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
