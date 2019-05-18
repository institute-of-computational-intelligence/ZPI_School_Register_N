using Kolokwium.BLL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Kolokwium.DAL
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly ConnectionStringDto _connectionStringDto;
        public ApplicationDbContext(ConnectionStringDto connectionStringDto)
        {
            _connectionStringDto = connectionStringDto;
        }
    }
}
