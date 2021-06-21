using Application.Dtos;
using Application.Interfaces;
using Application.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers   
{
    [Route("api/[controller]")]
    [ApiController]
    public class RightTrianglesController : ControllerBase
    {
        private readonly IDrawingService _drawingService;
        private readonly MockRepository _mockRepository;

        public RightTrianglesController(IDrawingService drawingService, MockRepository mockRepository)
        {
            _drawingService = drawingService;
            _mockRepository = mockRepository;
        }

        [HttpPost]
        public IActionResult CreateRightTriangle(PointDto origin, int a, int b)
        {
            _drawingService.CreateVectorRightTriangle(origin, a, b);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetRightTriangleById(int id)
        {
            if (id >= _mockRepository.Triangles.Count)
                return BadRequest();

            return Ok(_mockRepository.Triangles[id]);
        }
    }
}
