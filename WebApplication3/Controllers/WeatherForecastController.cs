using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebApplication3.Controllers
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

        public HttpClient HttpClient { get; }

        public WeatherForecastController(ILogger<WeatherForecastController> logger, HttpClient httpClient)
        {
            _logger = logger;
            HttpClient = httpClient;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        //[HttpGet]
        //public InverterModel GetInverterData()
        //{
        //    var response = HttpClient.GetStringAsync("http://192.168.178.29/measurements.xml").GetAwaiter().GetResult();
        //    XmlSerializer xmlResponse = new XmlSerializer(typeof(InverterModel));
        //    using (var streamReader = new StringReader(response))
        //    {
        //        InverterModel inverterData = (InverterModel)xmlResponse.Deserialize(streamReader);
        //        return inverterData;
        //    }
        //}

        [HttpGet]
        public Rootobject GetJson()
        {
            var result = HttpClient.GetFromJsonAsync<Rootobject>("http://192.168.178.29/yields.json?day=first&_=1618507950571").GetAwaiter().GetResult();
            return result;
        }
    }
}
