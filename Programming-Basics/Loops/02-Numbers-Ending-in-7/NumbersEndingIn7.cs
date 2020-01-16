using System;

namespace _02_Numbers_Ending_in_7
{
    class NumbersEndingIn7
    {
        static void Main(string[] args)
        {
            for (double i = 0; i < 1000; i++)
            {
                if (i % 10 == 7)
                    Console.WriteLine(i);
            }

        }
    }
}
