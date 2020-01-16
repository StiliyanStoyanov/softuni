using System;
using System.Linq;

namespace _06_MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        { 
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int counterMax = 1;
            int numberMax = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i+1])
                {
                    counter++;
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        numberMax = arr[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            for (int i = 0; i < counterMax; i++)
            {
                Console.Write($"{numberMax} ");
            }
        }
    }
}
