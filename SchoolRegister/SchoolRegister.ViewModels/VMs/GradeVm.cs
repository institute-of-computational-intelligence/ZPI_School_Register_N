using SchoolRegister.BLL.Entities;
using System;

namespace SchoolRegister.ViewModels.VMs
{
    public class GradeVm
    {
        public DateTime DateOfIssue { get; set; }
        public GradeScale GradeValue { get; set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }
    }
}
