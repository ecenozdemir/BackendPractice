using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsrController : ControllerBase
    {
        [HttpGet]
        public IActionResult Google()
        {
            return Redirect("https://www.google.com");
        }
        [HttpGet("get-weather")]
        public IActionResult GetWeatherLocal()
        {
            return LocalRedirect("/WeatherForecast/Get");
        }

        [HttpGet("get-weather-with-action")]
        public IActionResult GetWeatherWithAction()
        {
            return RedirectToAction("Get", "WeatherForecast");
        }
    }


}
