using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD

namespace SchoolRegister.Web.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
=======
using SchoolRegister.Services.Interfaces;

namespace SchoolRegister.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    
    public class SampleDataController : Controller
    {
        private readonly ISubjectService _subjectService;

>>>>>>> 98f1feb474bc06c1ac3fcae03211fd492ab72b62
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

<<<<<<< HEAD
        [HttpGet("[action]")]
=======
        public SampleDataController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

>>>>>>> 98f1feb474bc06c1ac3fcae03211fd492ab72b62
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

<<<<<<< HEAD
=======
        public IActionResult GetSubjects()
        {
            var subjects = _subjectService.GetSubjects();
            return Ok(subjects);
        }
>>>>>>> 98f1feb474bc06c1ac3fcae03211fd492ab72b62
        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
