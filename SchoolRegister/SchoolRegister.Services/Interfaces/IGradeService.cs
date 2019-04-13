using SchoolRegister.BLL.Entities;
using SchoolRegister.ViewModels.DTOs;
using SchoolRegister.ViewModels.VMs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.Services.Interfaces
{
    public interface IGradeService
    {
        Grade AddGradeToStudent(AddGradeToStudentDto addGradeToStudentDto);
        GradesReportVm GetGradesReportForStudent(GetGradesDto getGradesDto);
    }
}
