using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.BAL.Entities
{
    class User : IdentityUser<int>
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime RegistrationDate { get; set; }
    }
}
