using System;
using System.Collections.Generic;
using System.Text;
using SchoolRegister.ViewModels.DTOs;
using SchoolRegister.ViewModels.VMs;

namespace SchoolRegister.Services.Interfaces
{
    public interface IGradeService
    {
        GradesReportVm GetGradesReportForStudent(GetGradeDto getGradesDto);
        GradeVm AddGradeToStudent(AddGradeToStudentDto addGradeToStudentDto);
    }
}