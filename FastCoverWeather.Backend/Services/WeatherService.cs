using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FastCoverWeather.Backend.Services
{
    public interface IWeatherService
    {
        Task<string> SendRequest(double latitude, double longitude);

    }

    public class WeatherService : IWeatherService
    {

        private readonly IHttpClientFactory _httpClientFactory;
        private string _urlBase;

        public WeatherService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _urlBase = """https://api.open-meteo.com/v1/forecast""";
        }

        public async Task<string> SendRequest(double latitude, double longitude)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var url = $"{_urlBase}?latitude={latitude}&longitude={longitude}&hourly=temperature_2m&daily=weather_code&timezone=Australia%2FSydney";
            var response = await httpClient.GetAsync(url);

            var content = await response.Content.ReadAsStringAsync();
            if (string.IsNullOrEmpty(content))
            {
                return "Received empty or null response content.";
            } else
            {
                return content;
            }
        }
    }
}
