using System;

namespace _09_ReverseCharacters
{
    class ReverseCharacters
    {
        static void Main(string[] args)
        {
            char[] array = new char[3];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = char.Parse(Console.ReadLine());
            }

            Array.Reverse(array);
            string str = new string(array);
            Console.WriteLine(str);
        }
    }
}
