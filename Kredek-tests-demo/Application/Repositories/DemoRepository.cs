using Application.Interfaces;
using Domain.Models;
using System.Collections.Generic;

namespace Application.Repositories
{
    public class DemoRepository : IDemoRepository
    {
        private static List<List<Line>> _rectangles { get; set; } = new List<List<Line>>();
        private static List<List<Line>> _triangles { get; set; } = new List<List<Line>>();

        public List<List<Line>> GetTriangles()
        {
            return _triangles;
        }
        public List<List<Line>> GetRectangles()
        {
            return _rectangles;
        }
        public void InsertTriangle(List<Line> triangle)
        {
            _triangles.Add(triangle);
        }
        public void InsertRectangle(List<Line> rectangle)
        {
            _rectangles.Add(rectangle);
        }
    }
}
