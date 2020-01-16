using System;

namespace _08_Sum_Of_Odd_Numbers
{
    class SumOddNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var sum = -1;
            var sum2 = 0;

            for (var i = 1; i <= number; i++)
            {
                sum += 2;
                Console.WriteLine($"{sum}");
                sum2 += sum;
            }
            Console.WriteLine($"Sum: {sum2}");
        }
    }
}
