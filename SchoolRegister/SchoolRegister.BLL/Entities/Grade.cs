﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class Grade
    {
        public DateTime DateofIssue { get; set; }
        public GradeScale GradeValue { get; set; }
        public Subject Subject { get; set; }
    }
}
