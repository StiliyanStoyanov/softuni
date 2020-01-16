using System;

namespace _04_TriangleOfDollars
{
    class TriangleOfDollars
    {
        static void Main(string[] args)
        {
            int dollarsToPrint = int.Parse(Console.ReadLine());
            for (int row = 1; row <= dollarsToPrint; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
