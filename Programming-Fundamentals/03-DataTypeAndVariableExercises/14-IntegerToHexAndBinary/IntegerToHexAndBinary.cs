using System;

namespace _14_IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numberInHex = Convert.ToString(number, 16).ToUpper();
            string numberInBinary = Convert.ToString(number, 2);

            Console.WriteLine(numberInHex);
            Console.WriteLine(numberInBinary);
        }
    }
}
