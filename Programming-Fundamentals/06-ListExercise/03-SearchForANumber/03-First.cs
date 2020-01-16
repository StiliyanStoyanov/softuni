using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] numbersToCheck = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int counter = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int k = 0; k < numbersToCheck.Length-1; k++)
                {
                    if (numbersToCheck[k] == numbers[i])
                    {
                        counter++;
                    }
                }
            }
            if (counter == numbersToCheck.Length)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
