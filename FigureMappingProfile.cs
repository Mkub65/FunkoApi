using AutoMapper;
using FunkoApi.Entities;

namespace FunkoApi
{
    public class FigureMappingProfile : Profile
    {
        public FigureMappingProfile()
        {
            CreateMap<Figure, FigureDto>();
        }
    }
}
