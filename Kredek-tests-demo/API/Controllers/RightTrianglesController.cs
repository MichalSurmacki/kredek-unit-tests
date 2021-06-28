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
    [ApiController]
    public class RightTrianglesController : ControllerBase
    {
        private readonly IDrawingService _drawingService;
        private readonly IDemoRepository _demoRepository;

        public RightTrianglesController(IDrawingService drawingService, IDemoRepository demoRepository)
        {
            _drawingService = drawingService;
            _demoRepository = demoRepository;
        }

        [HttpPost("api/[controller]")]
        public IActionResult CreateRightTriangle(PointDto origin, int a, int b)
        {
            _drawingService.CreateVectorRightTriangle(origin, a, b);
            return Ok();
        }

        [HttpGet("api/[controller]")]
        public IActionResult GetRightTriangles()
        {
            return Ok(_demoRepository.GetTriangles());
        }

        [HttpGet("api/[controller]/{id}")]
        public IActionResult GetRightTriangleById(int id)
        {
            if (id >= _demoRepository.GetTriangles().Count)
                return BadRequest();

            return Ok(_demoRepository.GetTriangles()[id]);
        }
    }
}
