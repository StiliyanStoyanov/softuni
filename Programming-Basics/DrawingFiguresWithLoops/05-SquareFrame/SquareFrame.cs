using System;

namespace _05_Square_Frame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int calculatedSize = size - 2;

            string topAndBotRow = "+";
            for (int col = 1; col <= calculatedSize; col++)
            {
                topAndBotRow = topAndBotRow + " -";
            }
            topAndBotRow = topAndBotRow + " +";
            Console.WriteLine(topAndBotRow);
            string middleRows = "|";
            for (int col = 1; col <= calculatedSize; col++)
            {
                middleRows = middleRows + " -";
            }
            middleRows = middleRows + " |";
            for (int row = 0; row < calculatedSize; row++)
            {
                Console.WriteLine(middleRows);
            }
            Console.WriteLine(topAndBotRow);
        }
    }
}
