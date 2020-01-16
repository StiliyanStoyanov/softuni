using System;

namespace _09_Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int formula = size * 2;
            string kant = new string('*', formula);
            string middleKant = new string(' ', size);
            string topAndBotRow = kant + middleKant + kant;

            Console.WriteLine("{0}{1}{0}", kant, middleKant);

            int targetRow = (size - 1) / 2 - 1;
            for (int row = 0; row < size - 2; row++)
            {
                char symbol = ' ';
                if (row == targetRow)
                {
                    symbol = '|';
                }
                string forwardSlash = new string('/', formula - 2);
                string middlePart = new string(symbol, size);
                Console.WriteLine("*{0}*{1}*{0}*", forwardSlash, middlePart);
            }

            Console.WriteLine("{0}{1}{0}", kant, middleKant);
        }
    }
}
