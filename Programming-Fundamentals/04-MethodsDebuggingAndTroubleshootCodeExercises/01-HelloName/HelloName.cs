using System;

namespace _01_HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello, {GetName()}!");
        }

        static string GetName(string name = "")
        {
            return name = Console.ReadLine();
        }
    }
}
