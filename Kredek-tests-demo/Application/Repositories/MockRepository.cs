using Domain.Models;
using System.Collections.Generic;

namespace Application.Repositories
{
    public class MockRepository
    {
        public List<List<Line>> Rectangles { get; set; } = new List<List<Line>>();
        public List<List<Line>> Triangles { get; set; } = new List<List<Line>>();
    }
}
