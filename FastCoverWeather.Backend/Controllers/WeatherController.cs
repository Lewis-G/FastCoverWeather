using FastCoverWeather.Backend.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastCoverWeather.Backend.Models;

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
            var (data, error) = await _weatherService.GetWeatherAsync(city);
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return BadRequest(error);
            }
            
        }

    }
}
