using SchoolRegister.DAL.EF;
using SchoolRegister.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.Services.Services
{
    public class TeacherService : BaseService, ITeacherService
    {
        public TeacherService(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
