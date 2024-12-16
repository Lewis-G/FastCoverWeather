using FastCoverWeather.Backend.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCoverWeather.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public async Task<ActionResult> GetWeather([FromQuery] string city)
        {
            var results = await _weatherService.SendRequest(52.52, 13.41);
            return Ok(results);
        }

    }
}
