﻿using System;
using System.Collections.Generic;
using System.Text;
 // bla bla
namespace SchoolRegister.BLL.Entities
{
    public class Grade
    {
        public DateTime DateOfIssue
        { get; set; }
        public GradeScale GradeValue
        { get; set; }
        public Subject Subject
        { get; set; }
    }
}
