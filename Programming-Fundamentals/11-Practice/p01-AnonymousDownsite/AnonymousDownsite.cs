using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace p01_AnonymousDownsite
{
    class AnonymousDownsite
    {
        static void Main(string[] args)
        {
            int numberOfSites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            BigInteger token = BigInteger.Pow(securityKey, numberOfSites);

            string read = Console.ReadLine();
            string[] data = read.Split(' ').ToArray();

            List<string> websites = new List<string>();
            decimal totalLoss = 0;

            for (int i = 0; i < numberOfSites; i++)
            {
                string siteName = data[0];
                long visits = long.Parse(data[1]);
                decimal price = decimal.Parse(data[2]);
                websites.Add(siteName);

                totalLoss += (visits * price);

                read = Console.ReadLine();
                data = read.Split(' ').ToArray();
            }

            foreach (var site in websites)
            {
                Console.WriteLine($"{site}");
            }
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {token}");


        }
    }
}
