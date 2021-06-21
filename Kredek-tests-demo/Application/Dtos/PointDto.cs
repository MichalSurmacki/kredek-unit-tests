using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class PointDto
    {
        public PointDto() { }
        public PointDto(int x, int y)
        {
            Y = y;
            X = x;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
