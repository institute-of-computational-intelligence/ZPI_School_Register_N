using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SchoolRegister.Services.Interfaces;
using SchoolRegister.ViewModels.VMs;

namespace SchoolRegister.Web.Controllers
{
    public class ChatController : BaseController
    {
        private readonly IGroupService _groupService;
        private readonly IStudentService _studentService;
        public IActionResult GetGroups()
        {
            var chatGroups = _groupService.GetGroups();
            return Ok(chatGroups);
        }

        public IActionResult GetStudents()
        {
            var students = _studentService.GetStudents().ToList();
            students.Add(new StudentVm()
            {
                Name = "All"
            });
            return Ok(students);
        }

        public ChatController(ILoggerFactory loggerFactory, IGroupService groupService, IStudentService studentService) : base(loggerFactory)
        {
            _groupService = groupService;
            _studentService = studentService;
        }
    }
}