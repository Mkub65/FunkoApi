using Microsoft.AspNetCore.Mvc;

namespace FunkoApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class FiguresController : ControllerBase
    {
        private readonly ILogger<FiguresController> _logger;

        public FiguresController(ILogger<FiguresController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetFigureById/{id}")]
        public IEnumerable<WeatherForecast> Get(string Id)
        {
            return (IEnumerable<WeatherForecast>)NotFound();
        }
    }
}