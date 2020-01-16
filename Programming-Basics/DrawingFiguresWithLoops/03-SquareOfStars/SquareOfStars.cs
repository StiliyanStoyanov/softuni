using System;

namespace _03_SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            int readstars = int.Parse(Console.ReadLine());
            for (int row = 1; row <= readstars; row++)
            {
                for (int col = 1; col <= readstars - 1; col++)
                {
                    Console.Write("* ");
                }
                Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
