using System;

namespace _11_Diamond  // Unfinished
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int countOfStars = size % 2 == 0 ? 2 : 1;
            int countOfDashesh = (size - countOfStars) / 2;

        }
    }
}
