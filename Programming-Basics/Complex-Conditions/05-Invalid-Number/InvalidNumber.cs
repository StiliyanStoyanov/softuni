using System;

namespace _05_Invalid_Number
{
    class InvalidNumber
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            if (number >= 100 && number <= 200 || number == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
