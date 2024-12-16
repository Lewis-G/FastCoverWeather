using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCoverWeather.Backend.Models
{
    public static class CityCoordinates
    {

        public static readonly Dictionary<string, (double Latitude, double Longitude)> Coordinates = new Dictionary<string, (double Latitude, double Longitude)>
        {
            { "New York, USA", (40.7128, -74.0060) },
            { "Los Angeles, USA", (34.0522, -118.2437) },
            { "Chicago, USA", (41.8781, -87.6298) },
            { "Houston, USA", (29.7604, -95.3698) },
            { "Miami, USA", (25.7617, -80.1918) },
            { "London, UK", (51.5074, -0.1278) },
            { "Paris, France", (48.8566, 2.3522) },
            { "Berlin, Germany", (52.5200, 13.4050) },
            { "Madrid, Spain", (40.4168, -3.7038) },
            { "Rome, Italy", (41.9028, 12.4964) },
            { "Sydney, Australia", (-33.8688, 151.2093) },
            { "Melbourne, Australia", (-37.8136, 144.9631) },
            { "Tokyo, Japan", (35.6895, 139.6917) },
            { "Seoul, South Korea", (37.5665, 126.9780) },
            { "Beijing, China", (39.9042, 116.4074) },
            { "Dubai, UAE", (25.2048, 55.2708) },
            { "Singapore, Singapore", (1.3521, 103.8198) },
            { "Toronto, Canada", (43.6511, -79.3470) },
            { "Vancouver, Canada", (49.2827, -123.1207) },
            { "Mexico City, Mexico", (19.4326, -99.1332) },
            { "Buenos Aires, Argentina", (-34.6037, -58.3816) },
            { "São Paulo, Brazil", (-23.5505, -46.6333) },
            { "Cape Town, South Africa", (-33.9249, 18.4241) },
            { "Nairobi, Kenya", (-1.2864, 36.8172) },
            { "Cairo, Egypt", (30.0444, 31.2357) },
            { "Moscow, Russia", (55.7558, 37.6173) },
            { "Istanbul, Turkey", (41.0082, 28.9784) },
            { "Bangkok, Thailand", (13.7563, 100.5018) },
            { "New Delhi, India", (28.6139, 77.2090) },
            { "Jakarta, Indonesia", (-6.2088, 106.8456) }
        };
    }
}
