using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BAL.Entities
{
    public class Role : IdentityRole<int>
    {
        Role() { }
        Role(string name) { }


    }
}
