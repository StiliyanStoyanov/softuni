using System;

namespace _09_Multiplication_Table
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                var output = num * i;
                Console.WriteLine($"{num} X {i} = {output}");
            }
        }
    }
}
