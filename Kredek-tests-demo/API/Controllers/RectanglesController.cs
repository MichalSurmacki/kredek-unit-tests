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
    public class RectanglesController : ControllerBase
    {
        private readonly IDrawingService _drawingService;
        private readonly MockRepository _mockRepository;

        public RectanglesController(IDrawingService drawingService, MockRepository mockRepository)
        {
            _drawingService = drawingService;
            _mockRepository = mockRepository;
        }
        
        [HttpPost]
        public IActionResult CreateRectangle(PointDto origin, int a)
        {
            _drawingService.CreateVectorRectangle(origin, a);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetGriangleById(int id)
        {
            if (id >= _mockRepository.Rectangles.Count)
                return BadRequest();
            
            return Ok(_mockRepository.Rectangles[id]);
        }
    }
}
