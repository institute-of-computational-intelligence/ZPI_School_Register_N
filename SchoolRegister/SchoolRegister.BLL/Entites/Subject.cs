﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entites
{
    class Subject
    {
        string Description { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        Teacher Teacher { get; set; }
    }
}