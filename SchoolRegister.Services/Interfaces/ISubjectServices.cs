using SchoolRegister.ViewModels.DTOs;
using SchoolRegister.ViewModels.VMs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


namespace SchoolRegister.Services.Interfaces
{
  public  interface ISubjectServices
    {
        SubjectVm AddOrUpdate(AddOrUpdateSubjectDto addOrUpdateSubjectDto);
        SubjectVm GetSubject(Expression<Func<ISubjectServices, bool>> filterPredicate);
        IEnumerable<SubjectVm> GetSubjects(Expression<Func<ISubjectServices, bool>> filterPredicate = null);

    }
}
