using System;

namespace _01_Rectangle10x10
{
    class Rectangle10x10
    {
        static void Main(string[] args)
        {
            for (int rows = 1; rows <= 10; rows++)
            {
                for (int col = 1; col <= 10; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
