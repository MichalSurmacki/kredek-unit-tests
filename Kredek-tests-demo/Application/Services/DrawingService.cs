using Application.Dtos;
using Application.Interfaces;
using Application.Repositories;
using AutoMapper;
using Domain.Models;
using System.Collections.Generic;

namespace Application.Services
{
    public class DrawingService : IDrawingService
    {
        private readonly MockRepository _mockRepository;

        public IMapper _mapper { get; }

        public DrawingService(MockRepository mockRepository, IMapper mapper)
        {
            _mockRepository = mockRepository;
            _mapper = mapper;
        }
        /// <summary>
        /// 'origin' is the ''left'' bottom point of rectangle.
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public List<LineDto> CreateVectorRectangle(PointDto origin, int a)
        {
            var vectorRectangle = new List<LineDto>();

            vectorRectangle.Add(new LineDto(
                                    new PointDto(origin.X, origin.Y), 
                                    new PointDto(origin.X + a, origin.Y)
                                    ));
            vectorRectangle.Add(new LineDto(
                                    new PointDto(origin.X + a, origin.Y),
                                    new PointDto(origin.X + a, origin.Y + a)
                                    ));
            vectorRectangle.Add(new LineDto(
                                    new PointDto(origin.X + a, origin.Y + a),
                                    new PointDto(origin.X, origin.Y + a)
                                    ));
            vectorRectangle.Add(new LineDto(
                                    new PointDto(origin.X, origin.Y + a),
                                    new PointDto(origin.X, origin.Y)
                                    ));

            _mockRepository.Rectangles.Add(_mapper.Map<List<Line>>(vectorRectangle));

            return vectorRectangle;
        }

        /// <summary>
        /// 'origin' is the ''left'' point of base line, 'b' is length of line from ''right'' point of base, 'c' is the length of line from 'b' back to the base.
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public List<LineDto> CreateVectorRightTriangle(PointDto origin, int a, int b)
        {
            var vectorRightTriangle = new List<LineDto>();

            vectorRightTriangle.Add(new LineDto(
                                    new PointDto(origin.X, origin.Y),
                                    new PointDto(origin.X + a, origin.Y)
                                    ));
            vectorRightTriangle.Add(new LineDto(
                                    new PointDto(origin.X + a, origin.Y),
                                    new PointDto(origin.X, origin.Y + b)
                                    ));
            vectorRightTriangle.Add(new LineDto(
                                    new PointDto(origin.X, origin.Y + b),
                                    new PointDto(origin.X, origin.Y)
                                    ));

            _mockRepository.Triangles.Add(_mapper.Map<List<Line>>(vectorRightTriangle));

            return vectorRightTriangle;
        }
    }
}