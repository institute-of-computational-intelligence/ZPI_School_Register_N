using SchoolRegister.DAL.EF;
using SchoolRegister.Services.Interfaces;
using SchoolRegister.ViewModels.DTOs;
using SchoolRegister.ViewModels.VMs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SchoolRegister.Services.Services
{
    public class SubjectServices : BaseService, ISubjectService
    {
        public SubjectServices(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public SubjectVm AddOrUpdate(AddOrUpdateSubjectDto addorUpdateSubjectDto)
        {
            throw new NotImplementedException();
        }

        public SubjectVm GetSubject(Expression<Func<SubjectVm, bool>> filterPredicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubjectVm> GetSubjects(Expression<Func<SubjectVm, bool>> filterPredicate = null)
        {
            throw new NotImplementedException();
        }
    }
}
