using SchoolRegister.ViewModels.DTOs;
using SchoolRegister.ViewModels.VMs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SchoolRegister.Services.Interfaces
{
    public interface ISubjectService
    {
        SubjectVm AddOrUpdate(AddOrUpdateSubjectDto addorUpdateSubjectDto);
        SubjectVm GetSubject(Expression<Func<SubjectVm, bool>> filterPredicate);
        IEnumerable<SubjectVm> GetSubjects(Expression<Func<SubjectVm, bool>> filterPredicate = null);
    }
}
