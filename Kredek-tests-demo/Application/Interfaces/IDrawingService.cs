using Application.Dtos;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IDrawingService
    {
        public List<LineDto> CreateVectorRectangle(PointDto origin, int a);

        // Aby z trzech odcinków zbudować trójkąt, najdłuższy z nich musi być krótszy niż suma długość dwóch pozostałych.
        public List<LineDto> CreateVectorRightTriangle(PointDto origin, int a, int b);

    }
}
