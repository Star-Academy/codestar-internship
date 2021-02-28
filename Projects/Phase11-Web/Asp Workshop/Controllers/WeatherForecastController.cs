using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Workshop.Abstarction;
using Asp_Workshop.Business;
using Asp_Workshop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Asp_Workshop.Controllers {
    [ApiController]
    [Route ("api/[Controller]/[Action]")]
    public class WeatherForecastController : ControllerBase {
        private readonly IPersonBusiness business;

        public WeatherForecastController (IPersonBusiness business) {
            this.business = business;
        }

        private static readonly string[] Summaries = new [] {
            "Freezing",
            "Bracing",
            "Chilly",
            "Cool",
            "Mild",
            "Warm",
            "Balmy",
            "Hot",
            "Sweltering",
            "Scorching"
        };

        [HttpGet]
        public IEnumerable<WeatherForecast> Get () {
            var rng = new Random ();
            return Enumerable.Range (1, 5).Select (index => new WeatherForecast {
                    Date = DateTime.Now.AddDays (index),
                        TemperatureC = rng.Next (-20, 55),
                        Summary = Summaries[rng.Next (Summaries.Length)]
                })
                .ToArray ();
        }

        [HttpPost ("{userName}/{age}")]
        public IActionResult HelloWorld (string userName, int age) {
            return BadRequest ();
        }

        [HttpPost ("{userName}/{age}")]
        public IActionResult GetPerson (string userName, int age,string temp, [FromBody] List<Person> persons) {
            return Ok (new {temp,userName, age, persons});
        }
    }
}