using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ExamExcercise1_PriceOfTransport
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = double.Parse(Console.ReadLine());
            var dayornight = (Console.ReadLine());
            var taxistart = 0.70;
            var taxiday = 0.79;
            var taxinight = 0.90;
            var bus = 0.09; /// само над 20км
            var train = 0.06; /// само над 100км
            if (km < 20 && dayornight == "day")
            {
                var TaxiPriceDay = taxistart + (taxiday * km);
                Console.WriteLine($"{TaxiPriceDay:F2}");
            }
            else if (km < 20 && dayornight == "night")
            {
                var TaxiPriceNight = taxistart + (taxinight * km);
                Console.WriteLine($"{TaxiPriceNight:F2}");
            }
            if (km >= 20 && km < 100 && dayornight == "day")
            {
                var BusPrice = bus * km;
                Console.WriteLine($"{BusPrice:F2}");
            }
            else if (km >= 20 && km < 100 && dayornight == "night")
            {
                var BusPrice = bus * km;
                Console.WriteLine($"{BusPrice:F2}");
            }
            if (km >= 100 && km <=5000 && dayornight =="day")
            {
                var TrainPrice = train * km;
                Console.WriteLine($"{TrainPrice:F2}");
            }
            else if (km >= 100 && km <= 5000 && dayornight == "night")
            {
                var TrainPrice = train * km;
                Console.WriteLine($"{TrainPrice:F2}");
            }
        }
    }
}
