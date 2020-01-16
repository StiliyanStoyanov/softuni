using System;

namespace _06_IntervalofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                for (int i = number2; i < number1 + 1; i++)
                {
                    Console.WriteLine(number2);
                    number2++;
                }
            }
            else if (number2 > number1)
            {
                for (int i = number1; i < number2 + 1; i++)
                {
                    Console.WriteLine(number1);
                    number1++;
                }
            }
        }
    }
}
