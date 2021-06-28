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
    public class RectanglesController : ControllerBase
    {
        private readonly IDrawingService _drawingService;
        private readonly IDemoRepository _demoRepository;

        public RectanglesController(IDrawingService drawingService, IDemoRepository demoRepository)
        {
            _drawingService = drawingService;
            _demoRepository = demoRepository;
        }
        
        [HttpPost("api/[controller]")]
        public IActionResult CreateRectangle(PointDto origin, int a)
        {
            _drawingService.CreateVectorRectangle(origin, a);
            return Ok();
        }

        [HttpGet("api/[controller]")]
        public IActionResult GetRectangles()
        {
            return Ok(_demoRepository.GetRectangles());
        }

        [HttpGet("api/[controller]/{id}")]
        public IActionResult GetRectangleById([FromRoute] int id)
        {
            if (id >= _demoRepository.GetRectangles().Count)
                return BadRequest();
            
            return Ok(_demoRepository.GetRectangles()[id]);
        }
    }
}
