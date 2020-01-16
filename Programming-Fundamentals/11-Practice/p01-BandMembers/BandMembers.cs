using System;

namespace p01_BandMembers
{
    class BandMembers
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double priceGuitar = double.Parse(Console.ReadLine());
            double priceDrum = (priceGuitar) * 1.5;

            int vocalist = 1;
            int guitarists = (int)Math.Floor((decimal)(1 / 3.0 * count)); /// ???????????
            int drummers = count - vocalist - (int)guitarists;

            double guitarTotal = guitarists * priceGuitar;
            double drumTotal = drummers * priceDrum;
            double micTotal = drumTotal - guitarTotal;
            double rentPerMonth = (guitarTotal + drumTotal + micTotal) / count;
            double rentPerYear = rentPerMonth * 12;

            double totalCost = guitarTotal + drumTotal + micTotal + rentPerYear;

            Console.WriteLine($"Total cost: {totalCost:F2}lv.");
        }
    }
}
