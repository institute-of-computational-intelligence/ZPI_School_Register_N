using SchoolRegister.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SchoolRegister.ViewModels.DTOs
{
    public class GetTeachersGroupsDto
    {
        public int TeacherId { get; set; }
        public Expression<Func<Student, bool>> GroupsFilterPredicate { get; set; }
    }
}
