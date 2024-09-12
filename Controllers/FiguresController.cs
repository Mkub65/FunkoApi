using FunkoApi.Entities;
using Microsoft.AspNetCore.Mvc;
using static FunkoApi.Services.AccountService;
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
        public Figure Get(string Id)
        {
            var figure = _figuresService.GetById(Id);
            return figure;
        }
    }
}