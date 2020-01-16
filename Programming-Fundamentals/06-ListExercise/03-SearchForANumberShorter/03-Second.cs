using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_SearchForANumberShorter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (numbers.Take(command[0]).Skip(command[1]).Contains(command[2]))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
