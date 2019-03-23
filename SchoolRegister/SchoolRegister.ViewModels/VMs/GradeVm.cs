using SchoolRegister.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.ViewModels.VMs
{
    class GradeVm
    {
        public DateTime DateOfIssue { get; set; }
        public GradeScale GradeValue { get; set; }

        public Subject Subject { get; set; }
        public int SubjectId { get; set; }
    }
}
