using EmployeeManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService _weatherService;

        public WeatherController()
        {
            _weatherService = new WeatherService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(string city)
        {
            var weather = await _weatherService.GetWeatherAsync(city);
            return View(weather);
        }
    }
}