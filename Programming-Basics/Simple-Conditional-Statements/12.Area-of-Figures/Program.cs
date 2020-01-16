using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var FigureType = (Console.ReadLine());
            if (FigureType == "square")
            {
                var squareside = double.Parse(Console.ReadLine());
                var SquareArea = squareside * squareside;
                Console.WriteLine(SquareArea);
            }
            else if (FigureType == "rectangle")
            {
                var RectangleSide1 = double.Parse(Console.ReadLine());
                var RectangleSide2 = double.Parse(Console.ReadLine());
                var RectangleArea = RectangleSide1 * RectangleSide2;
                Console.WriteLine(RectangleArea);
            }
            else if (FigureType == "circle")
            {
                var CircleRadius = double.Parse(Console.ReadLine());
                var CircleArea = (CircleRadius * CircleRadius) * Math.PI;
                Console.WriteLine(CircleArea);
            }
            else if (FigureType == "triangle")
            {
                var TriangleBase = double.Parse(Console.ReadLine());
                var TriangleHeight = double.Parse(Console.ReadLine());
                var AreaOfTriangle = (TriangleBase * TriangleHeight) / 2;
                Console.WriteLine(AreaOfTriangle);
            }
        }
    }
}
