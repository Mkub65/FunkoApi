using FunkoApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FunkoApi.Controllers
{
    [ApiController]
    [Route("api/Figures")]
    public class FiguresController : ControllerBase
    {
        private readonly ILogger<FiguresController> _logger;

        public FiguresController(ILogger<FiguresController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetFigureById/{id}")]
        public IEnumerable<Role> Get(string Id)
        {
            return (IEnumerable<Role>)NotFound();
        }
    }
}