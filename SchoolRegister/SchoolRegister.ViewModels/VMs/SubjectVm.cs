<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;
=======
﻿using System.Collections.Generic;
>>>>>>> 98f1feb474bc06c1ac3fcae03211fd492ab72b62

namespace SchoolRegister.ViewModels.VMs
{
    public class SubjectVm
    {
        public int Id { get; set; }
<<<<<<< HEAD
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<GroupVm> Groups { get; set; }
        public string TeacherName { get; set; }


=======

        public string Name { get; set; }

        public string Description { get; set; }

        public IList<GroupVm> Groups { get; set; }

        public string TeacherName { get; set; }
        public int? TeacherId { get; set; }
>>>>>>> 98f1feb474bc06c1ac3fcae03211fd492ab72b62
    }
}
