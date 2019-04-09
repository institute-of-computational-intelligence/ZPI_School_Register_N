using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolRegister.DAL.EF;

namespace SchoolRegister.Web.Controllers
{
    [Authorize]
    // [EnableCors("AllowCors")]
    [Route("api/[controller]")]
    public abstract class BaseController : Controller
    {
        protected readonly ApplicationDbContext _dbContext;
        protected readonly ILogger _logger;
        protected BaseController( ILoggerFactory loggerFactory, ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _logger = loggerFactory.CreateLogger<BaseController>();
        }
        protected void AddErrors(IdentityResult result, string validatorName = "")
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(validatorName, error.Description);
            }
        }
    }
}
