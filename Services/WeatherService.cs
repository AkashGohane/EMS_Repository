using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Services
{
    public interface IWeatherService
    {
        Task<WeatherResponse> GetWeatherAsync(string city);
    }

    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<WeatherResponse> GetWeatherAsync(string city)
        {
            var apiKey = "fdf3305021d8a2df1f0d18ba1967470d"; // Replace with your actual API key
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(responseContent);

            return weatherResponse;
        }
    }

    public class WeatherResponse
    {
        public Main Main { get; set; }
        public string Name { get; set; }
    }

    public class Main
    {
        public double Temp { get; set; }
    }
}