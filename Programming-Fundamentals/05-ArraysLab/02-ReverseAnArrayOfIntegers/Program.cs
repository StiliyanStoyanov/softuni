using System;

namespace _02_ReverseAnArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());

            int[] arrayValue = new int [arrayLength];

            for (int i = arrayLength - 1; i >= 0; i--)
            {
                int readNumbers = int.Parse(Console.ReadLine());
                arrayValue[i] = readNumbers;
            }

            Array.Reverse(arrayValue);


            var result = string.Join(" ", arrayValue);
            Console.WriteLine(result);
        }
    }
}
