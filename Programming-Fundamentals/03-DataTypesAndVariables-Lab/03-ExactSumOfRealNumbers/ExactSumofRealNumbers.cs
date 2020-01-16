using System;

namespace _03_ExactSumOfRealNumbers
{
    class ExactSumofRealNumbers
    {
        static void Main(string[] args)
        {
            int numbersToRead = int.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int i = 1; i <= numbersToRead; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
