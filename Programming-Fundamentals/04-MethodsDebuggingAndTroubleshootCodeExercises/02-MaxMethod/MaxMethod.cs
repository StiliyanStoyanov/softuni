using System;

namespace _02_MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int result = Math.Max(Math.Max(a, b), c);
            Console.WriteLine(result);
        }

    }
}
