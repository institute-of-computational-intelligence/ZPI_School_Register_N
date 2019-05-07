using System;
using System.Collections.Generic;
using System.Text;
using SchoolRegister.BLL.Entities;
using SchoolRegister.ViewModels.DTOs;
using SchoolRegister.ViewModels.VMs;
using System.Linq.Expressions;

namespace SchoolRegister.Services.Interfaces
{
   public interface IGroupService
    {
        GroupVm AddOrUpdateGroup(AddOrUpdateGroupDto addOrUpdateGroupDto);
        IEnumerable<GroupVm> GetGroups(Expression<Func<Group, bool>> filterPredicate = null);
        GroupVm GetGroup (Expression<Func<Group, bool>> filterPredicate);
        StudentVm AttachStudentToGroup(AttachDetachStudentToGroupDto attachStudentToGroupDto);
        StudentVm DetachStudentFromGroup(AttachDetachStudentToGroupDto detachStudentToGroupDto);
        GroupVm AttachSubjectToGroup(AttachDetachSubjectGroupDto attachSubjectGroup);
        GroupVm DetachSubjectFromGroup(AttachDetachSubjectGroupDto detachDetachSubject);
    }
}
