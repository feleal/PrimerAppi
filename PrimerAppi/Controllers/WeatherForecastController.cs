using Microsoft.AspNetCore.Mvc;
using PrimerAppi.Modelos;

namespace PrimerAppi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet]
        public string ObtenerSaludo()
        {
            return "Hola Mundo desde mi api";
        }
    }
}