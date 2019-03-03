using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.ViewModels.VMs
{
    public class JwtIssuerOptions
    {
        public string Issuer { get; set; }
        public string Audiance { get; set; }
        public string SecretKey { get; set; }
    }
}
