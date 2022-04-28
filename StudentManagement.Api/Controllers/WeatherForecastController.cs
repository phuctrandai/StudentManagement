using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentManagement.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IStudentBusiness _studentBusiness;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IStudentBusiness studentBusiness)
        {
            _logger = logger;
            _studentBusiness = studentBusiness;
        }

        [HttpGet]
        [Route("{order-id}/closing/document/total")]
        public IEnumerable<WeatherForecast> Get([FromRoute(Name = "order-id")] int order_id)
        {
            _studentBusiness.Test();

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
