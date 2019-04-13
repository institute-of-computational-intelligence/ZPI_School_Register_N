﻿using System;
using System.Collections.Generic;
using System.Text;
using SchoolRegister.BLL.Entities;

namespace SchoolRegister.ViewModels.VMs
{
    public class GradesReportVm
    {
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string ParentName { get; set; }
        public string GroupName { get; set; }
        public IDictionary<string, List<GradeScale>> StudentGradesPerSubject { get; set; }
        public double AverageGrade { get; set; }
        public IDictionary<string, double> AverageGradePerSubject { get; set; }
    }
}
