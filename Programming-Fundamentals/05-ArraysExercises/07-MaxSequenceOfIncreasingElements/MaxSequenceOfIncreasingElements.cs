using System;
using System.Linq;

namespace _07_MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int counterMax = 1;
            int position = 0; /// last position of sequencing numbers

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] < arr[i+1])
                {
                    counter++;
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        position = i + 1;
                    }
                }
                else
                {
                    counter = 1;
                }

            }

            int start = position - counterMax + 1;
            int end = position;
            for (int i = start; i <= end; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
