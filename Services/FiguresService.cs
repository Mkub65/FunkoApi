using FunkoApi.Entities;
using FunkoApi.Exceptions;
using static FunkoApi.Entities.FiguresDbConntext;

namespace FunkoApi.Services
{
    public class FiguresService
    {
        public interface IFiguresService
        {
            public Figure GetById(string id);
        }

        public class FiguresServices : IFiguresService 
        {
            private readonly FigurestDbContext _context;
            public FiguresServices(FigurestDbContext context)
            {
                _context = context;
            }

            public Figure GetById(string id)
            {
                var idAsInt = Int32.Parse(id);
                var figure = GetFigureById(idAsInt);

                if (figure == null)
                {
                    throw new NotFoundException("Figure not found");
                }

                return figure;
            }

            private Figure GetFigureById(int id)
            {
                var figure = _context.Figures.FirstOrDefault(f => f.Id == id);
                return figure;
            }
        }

    }
}
