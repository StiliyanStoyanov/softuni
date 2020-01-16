using System;

namespace _05_Max_Number
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            var numberstoRead = int.Parse(Console.ReadLine());
            var maxNumber = int.MinValue;

            for (int i = 0; i < numberstoRead; i++)
            {
                var readNumber = int.Parse(Console.ReadLine());
                if (readNumber > maxNumber)
                {
                    maxNumber = readNumber;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
