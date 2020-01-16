using System;

namespace _02_CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F12}", Math.PI * radius * radius);
        }
    }
}
