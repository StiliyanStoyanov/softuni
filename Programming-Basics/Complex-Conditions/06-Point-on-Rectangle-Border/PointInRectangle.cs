using System;

namespace _06_Point_on_Rectangle_Border
{
    class PointInRectangle
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            bool isOnRight = (x == x2) && y <= y2 && y >= y1;
            bool isOnLeft = (x == x1) && y <= y2 && y >= y1;
            bool isOnUpside = (y == y1) && x >= x1 && x <= x2;
            bool isOnDownSide = (y == y2) && x >= x1 && x <= x2;
            if (isOnRight || isOnLeft || isOnUpside || isOnDownSide)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
