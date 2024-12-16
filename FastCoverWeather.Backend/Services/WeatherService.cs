using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FastCoverWeather.Backend.DTOs;
using FastCoverWeather.Backend.Models;

namespace FastCoverWeather.Backend.Services
{
    public interface IWeatherService
    {
        Task<string> SendRequest(double latitude, double longitude);
        Task<(OpenMeteoDataDTO? Data, string? ErrorMessage)> GetWeatherAsync(string city);
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
                return "Received empty or null response content";
            } else
            {
                return content;
            }
        }

        public async Task<(OpenMeteoDataDTO? Data, string? ErrorMessage)> GetWeatherAsync(string city)
        {
            if (!CityCoordinates.Coordinates.ContainsKey(city)){
                return (null, "Input does not match any cities in the system");
            }
            
            var coordinates = CityCoordinates.Coordinates[city];

            var httpResponse = await this.SendRequest(coordinates.Latitude, coordinates.Longitude);
            
            if (httpResponse == "Received empty or null response content")
            {
                return (null, "Received empty or null response content");
            }

            try
            {
                var responseObject = JsonSerializer.Deserialize<OpenMeteoDataDTO>(httpResponse);
                return (responseObject, null);

            }
            catch (JsonException ex)
            {
                return (null, $"Deserialization error: {ex.Message}");

            }
            catch (Exception ex)
            {
                return (null, $"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
