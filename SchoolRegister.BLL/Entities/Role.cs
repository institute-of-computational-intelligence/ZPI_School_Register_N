using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
   public class Role : Microsoft.AspNetCore.Identity.IdentityRole<int>
    {
        Role() { }
        Role(string name) { }
    }
}
