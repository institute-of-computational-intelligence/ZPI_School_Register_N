using SchoolRegister.BLL.Entities;
using SchoolRegister.ViewModels.DTOs;
using SchoolRegister.ViewModels.VMs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SchoolRegister.Services.Interfaces
{
    public interface ISubjectServices
    {
        SubjectVm AddOrUpdate(AddOrUpdateSubjectDto addOrUpdateSubjectDto);
        SubjectVm GetSubject(Expression<Func<Subject, bool>> filterPredicate);
        IEnumerable<SubjectVm> GetSubjects(Expression<Func<Subject, bool>> filterPredicate = null);
    }
}
