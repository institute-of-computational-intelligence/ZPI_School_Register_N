using SchoolRegister.DAL.EF;
using SchoolRegister.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.Services.Services
{
    public class GroupService: BaseService, IGroupService
    {
        public GroupService(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
