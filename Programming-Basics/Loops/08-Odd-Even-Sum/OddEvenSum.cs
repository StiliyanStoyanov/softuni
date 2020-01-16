using System;

namespace _08_Odd_Even_Sum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            var numbersToRead = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < numbersToRead; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += readNumber;
                }
                else
                {
                    oddSum += readNumber;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes, sum = " + evenSum);
            }
            else
            {
                var difference = Math.Abs(evenSum - oddSum);
                Console.WriteLine($"No diff = {difference}");
            }
        }
    }
}
