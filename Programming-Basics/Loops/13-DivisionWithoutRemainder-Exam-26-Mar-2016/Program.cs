using System;

namespace _13_Division_Without_Remainder_Exam26March2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersToRead = int.Parse(Console.ReadLine()) * 1;
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            for (int i = 1; i <= numbersToRead; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
            }
            p1 = p1 / numbersToRead * 100;
            p2 = p2 / numbersToRead * 100;
            p3 = p3 / numbersToRead * 100;
            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
        }
    }
}
