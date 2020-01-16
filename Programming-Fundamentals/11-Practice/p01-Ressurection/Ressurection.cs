using System;

namespace p01_Ressurection
{
    class Ressurection
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long totalLength = 0;
            decimal totalWidth = 0m;
            int wingLength = 0;

            for (int i = 0; i < n; i++)
            {
                totalLength = long.Parse(Console.ReadLine());
                totalWidth = decimal.Parse(Console.ReadLine());
                wingLength = int.Parse(Console.ReadLine());
                decimal totalYears = 0m;
                for (int x = 0; x < (n * 3) / n; x++)
                {
                    totalYears = (totalLength * totalLength) * (totalWidth + (2 * wingLength));
                }
                Console.WriteLine(totalYears);
            }
        }
    }
}
