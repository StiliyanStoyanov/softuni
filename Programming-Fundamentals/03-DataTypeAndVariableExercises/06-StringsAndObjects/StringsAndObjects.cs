using System;

namespace _06_StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string n = "Hello";
            string n1 = "World";
            object obj = n + " " + n1;
            string n2 = (string)obj;

            Console.WriteLine(n2);

        }
    }
}
