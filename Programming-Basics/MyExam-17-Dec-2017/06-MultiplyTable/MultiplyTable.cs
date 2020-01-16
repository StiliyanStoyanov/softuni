using System;

namespace MultiplyTable
{
    class MultiplyTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int first = 1; first <= n % 10; first++)
            {
                for (int second = 1; second <= n / 10 % 10; second++)
                {
                    for (int third = 1; third <= n / 100; third++)
                    {
                        var sum = first * second * third;
                        Console.WriteLine("{0} * {1} * {2} = {3};", first, second, third, sum);
                    }
                }
            }
        }
    }
}