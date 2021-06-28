using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IDemoRepository
    {
        List<List<Line>> GetTriangles();
        List<List<Line>> GetRectangles();
        void InsertTriangle(List<Line> triangle);
        void InsertRectangle(List<Line> rectangle);
    }
}
