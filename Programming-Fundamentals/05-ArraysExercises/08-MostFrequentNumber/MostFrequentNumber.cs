using System;
using System.Linq;

namespace _08_MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int counterMax = 1;
            int numberMax = 0;

            for (int num1 = 0; num1 < arr.Length; num1++)
            {
                for (int num2 = 0; num2 < arr.Length; num2++)
                {
                    if (arr[num1] == arr[num2])
                    {
                        counter++;
                        if (counter > counterMax)
                        {
                            counterMax = counter;
                            numberMax = arr[num1];
                        }
                    }
                }
                counter = 1;
            }
            Console.WriteLine(numberMax);
        }
    }
}
