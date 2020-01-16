using System;

namespace _03_IvanoviHoliday
{
    class IvanoviHoliday
    {
        static void Main(string[] args)
        {
            int noshtuvki = int.Parse(Console.ReadLine());
            var destination = (Console.ReadLine());
            var transport = (Console.ReadLine());

            var price1 = 0.0;
            var price2 = 0.0;

            if (destination == "Miami")
            {
                if (noshtuvki >= 1 && noshtuvki <= 10) price1 = noshtuvki * (2 * 24.99 + 3 * 14.99);
                else if (noshtuvki >= 11 && noshtuvki <= 15) price1 = noshtuvki * (2 * 22.99 + 3 * 11.99);
                else if (noshtuvki > 15) price1 = noshtuvki * (2 * 20.00 + 3 * 10.00);
            }
            else if (destination == "Canary Islands")
            {
                if (noshtuvki >= 1 && noshtuvki <= 10) price1 = noshtuvki * (2 * 32.50 + 3 * 28.50);
                else if (noshtuvki >= 11 && noshtuvki <= 15) price1 = noshtuvki * (2 * 30.50 + 3 * 25.60);
                else if (noshtuvki > 15) price1 = noshtuvki * (2 * 28.00 + 3 * 22.00);
            }
            else if (destination == "Philippines")
            {
                if (noshtuvki >= 1 && noshtuvki <= 10) price1 = noshtuvki * (2 * 42.99 + 3 * 39.99);
                else if (noshtuvki >= 11 && noshtuvki <= 15) price1 = noshtuvki * (2 * 41.00 + 3 * 36.00);
                else if (noshtuvki > 15) price1 = noshtuvki * (2 * 38.50 + 3 * 32.40);
            }
            if (transport == "train")
            {
                price2 = 2 * 22.30 + 3 * 12.50;
            }
            else if (transport == "bus")
            {
                price2 = 2 * 45.00 + 3 * 37.00;
            }
            else if (transport == "airplane")
            {
                price2 = 2 * 90.00 + 3 * 68.50;
            }
            Console.WriteLine($"{(price1 * 1.25) + price2:F3}");
        }
    }
}
