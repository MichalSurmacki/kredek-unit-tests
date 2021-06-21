using Application.Dtos;
using AutoMapper;
using Domain.Models;

namespace Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Line, LineDto>();
            CreateMap<Point, PointDto>();

            CreateMap<LineDto, Line>();
            CreateMap<PointDto, Point>();
        }
    }
}
