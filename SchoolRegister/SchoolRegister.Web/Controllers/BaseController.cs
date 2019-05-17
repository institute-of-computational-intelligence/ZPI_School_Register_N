using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SchoolRegister.Web.Controllers
{
    [Authorize]
    // [EnableCors("AllowCors")]
    [Route("api/[controller]")]
    [Route("api/[controller]/[action]")]
    public abstract class BaseController : Controller
    {
        protected readonly ILogger _logger;
        protected BaseController(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<BaseController>();
        }
    }
}