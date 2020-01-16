using System;

namespace _04_Sum_Numbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("How much numbers to summ:");
            var NumberstoRead = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < NumberstoRead; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());

                sum += readNumber;
            }
            Console.WriteLine(sum);
        }
    }
}

