﻿using SchoolRegister.BLL.Entities;
using SchoolRegister.ViewModels.DTOs;
using SchoolRegister.ViewModels.VMs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SchoolRegister.Services.Interfaces
{
    interface ISubjectService
    {
        SubjectVm AddOrUpdate(AddOrUpdateSubjectDto addOrUpdateDto);
        SubjectVm GetSubject(Expression<Func<Subject, bool>> filterPredicate);
        IEnumerable<SubjectVm> GetSubjects(Expression<Func<Subject, bool>> filterPredicate = null);

    }
}
