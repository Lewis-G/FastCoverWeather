using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FastCoverWeather.Backend.DTOs
{
    public class OpenMeteoDataDTO
    {
        [JsonPropertyName("hourly")]
        public HourlyInfo Hourly { get; set; } = new HourlyInfo();

        [JsonPropertyName("daily")]
        public DailyInfo Daily { get; set; } = new DailyInfo();
    }

    public class HourlyInfo
    {
        [JsonPropertyName("time")]
        public List<string> Time { get; set; } = new List<string>();

        [JsonPropertyName("temperature_2m")]
        public List<double> Temperature2m { get; set; } = new List<double>();
    }

    public class DailyInfo
    {
        [JsonPropertyName("time")]
        public List<string> Time { get; set; } = new List<string>();

        [JsonPropertyName("weather_code")]
        public List<int> Weather_code { get; set; } = new List<int>();
    }
}
