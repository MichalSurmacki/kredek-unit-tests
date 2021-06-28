using Application.Dtos;
using Application.Interfaces;
using Application.Services;
using AutoMapper;
using Domain.Models;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace Application.Tests
{
    public class DrawingServiceTests
    {
        private readonly Mock<IDemoRepository> _demoRepositoryMock = new Mock<IDemoRepository>();
        private readonly IMapper _mapper;
        private readonly DrawingService _drawingService;

        public DrawingServiceTests()
        {
            if(_mapper == null)
            {
                var mapCfg = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new Application.MappingProfile());
                });
                _mapper = mapCfg.CreateMapper();
            }
            _drawingService = new DrawingService(_demoRepositoryMock.Object, _mapper);
        }

        [Fact]
        public void CreateVectorRectangle_should_create_rect_with_4_lines()
        {
            // Arrange
            var origin = new PointDto(0, 0);
            _demoRepositoryMock.Setup(s => s.InsertRectangle(It.IsAny<List<Line>>())).Verifiable();

            // Act
            var rect = _drawingService.CreateVectorRectangle(origin, 10);

            // Assert
            Assert.Equal(4, rect.Count);
        }

        [Theory]
        [InlineData(10, 10)]
        [InlineData(6, 7)]
        [InlineData(1 ,1000)]
        public void CreateVectorRightTriangle_should_start_point_match_end_point(int a, int b)
        {
            // Arrange
            var origin = new PointDto(0, 0);
            _demoRepositoryMock.Setup(s => s.InsertTriangle(It.IsAny<List<Line>>())).Verifiable();

            // Act
            var triangle = _drawingService.CreateVectorRightTriangle(origin, a, b);

            // Assert
            Assert.Equal(triangle[0].Start.X, triangle[2].End.X);
            Assert.Equal(triangle[0].Start.Y, triangle[2].End.Y);
        }
    }
}
