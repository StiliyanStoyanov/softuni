using System;

namespace _06_Min_Number
{
    class MinValue
    {
        static void Main(string[] args)
        {
            var numberstoRead = int.Parse(Console.ReadLine());
            var minNumber = int.MaxValue;

            for (int i = 0; i < numberstoRead; i++)
            {
                var readNumber = int.Parse(Console.ReadLine());
                if (readNumber < minNumber)
                {
                    minNumber = readNumber;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}

