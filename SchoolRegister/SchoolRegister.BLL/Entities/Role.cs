using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.BLL.Entities
{
    public class Role : IdentityRole<int>
    {
       Role() { }
       Role(string name) { }
    }
}
