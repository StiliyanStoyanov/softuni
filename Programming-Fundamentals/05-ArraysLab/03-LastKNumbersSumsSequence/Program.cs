using System;

namespace _03_LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            int[] array = new int[length];

            array[0] = 1;

            for (int i = 1; i <= length-1; i++)
            {
                int sum = 0;
                int counter = 0;
                for (int j = i; j >= 0; j--)
                {
                    sum += array[j];
                    counter++;
                    if (counter > count)
                    {
                        break;
                    }

                }
                array[i] = sum;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
