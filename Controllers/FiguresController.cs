using FunkoApi.Entities;
using Microsoft.AspNetCore.Mvc;
using static FunkoApi.Services.FiguresService;

namespace FunkoApi.Controllers
{
    [ApiController]
    [Route("api/Figures")]
    public class FiguresController : ControllerBase
    {
        private readonly IFiguresService _figuresService;

        public FiguresController(IFiguresService figuresService)
        {
            _figuresService = figuresService;
        }

        [HttpGet]
        [Route("GetFigureById/{Id}")]
        public Figure GetById(string Id)
        {
            var figure = _figuresService.GetById(Id);
            return figure;
        }

        [HttpPost]
        [Route("AddFigure")]
        public ActionResult AddNewFigure([FromBody] Figure figure)
        {
            _figuresService.AddNewFigure(figure);
            return Ok();
        }

        [HttpDelete]
        [Route("Delete/{Id}")]
        public ActionResult DeleteFigure(string Id)
        {
            _figuresService.DeleteFigure(Id);
            return Ok();
        }
    }
}