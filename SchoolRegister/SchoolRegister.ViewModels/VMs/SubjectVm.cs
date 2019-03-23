using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.ViewModels.VMs
{
    public class SubjectVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<GroupVm> TeacherId { get; set; }
        public string TecherName { get; set; }
    }
}
