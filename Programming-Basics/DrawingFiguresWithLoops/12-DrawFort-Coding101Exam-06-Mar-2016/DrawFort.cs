using System;

namespace DrawFort
{
    class DrawFort  // Unfinished 
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int midSum = n * 2 - 4 - 2 * (n / 2); // 10 - (4) - 5
            Console.WriteLine("/{0}\\{1}/{2}\\", new string('^', n / 2), new string('_', midSum), new string('^', n / 2));
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("|" + new string(' ', n * 2 - 2) + "|");
            }
            Console.WriteLine("|{0}{1}{2}|", new string(' ', n / 2 + 1), new string('_', midSum), new string(' ', n / 2 + 1));
            Console.WriteLine("\\{0}/{1}\\{2}/", new string('_', n / 2), new string(' ', midSum), new string('_', n / 2));
        }
    }
}