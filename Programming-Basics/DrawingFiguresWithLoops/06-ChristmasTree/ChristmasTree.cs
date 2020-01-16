using System;

namespace _06_ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int countOfWhiteSpaces = size;
            int rows = size + 1;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < countOfWhiteSpaces; col++)
                {
                    Console.Write('-');
                }

                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");

                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                countOfWhiteSpaces--;
                Console.WriteLine();

            }
        }
    }
}
