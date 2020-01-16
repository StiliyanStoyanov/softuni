using System;

namespace _15_FastPrimeChecker_Refactor
{
    class FastPrimeCheckerRefactor
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(i); divisor++)
                {
                    if (i % divisor == 0)
                    {
                            isPrime = false;
                            break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }     
        }
    }
}
