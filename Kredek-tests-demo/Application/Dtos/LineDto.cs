using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class LineDto
    {
        public LineDto() { }
        public LineDto(PointDto start, PointDto end)
        {
            Start = start;
            End = end;
        }
        public PointDto Start { get; set; }
        public PointDto End { get; set; }

    }
}