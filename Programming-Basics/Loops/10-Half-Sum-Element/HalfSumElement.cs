using System;

namespace _10_Half_Sum_Element
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int numbersToRead = int.Parse(Console.ReadLine());
            int biggestNumber = int.MinValue;
            int sumOfAllNumbers = 0;
            for (int i = 0; i < numbersToRead; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());
                sumOfAllNumbers += readNumber;
                if (readNumber > biggestNumber)
                {
                    biggestNumber = readNumber;
                }
            }

            int sumOfOtherNumbers = sumOfAllNumbers - biggestNumber;

            if (biggestNumber == sumOfOtherNumbers)
            {
                // TODO: yes message
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {biggestNumber}");
            }
            else
            {
                // TODO: no message
                int difference = Math.Abs(biggestNumber - sumOfOtherNumbers);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}
