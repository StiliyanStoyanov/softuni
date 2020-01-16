using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_SumReversedNumbers
{
    class SumReversed
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                List<char> reversed = numbers[i].ToString().ToList();
                reversed.Reverse();
                sum += int.Parse(string.Join("", reversed));
            }

            Console.WriteLine(sum);
        }
    }
}
