using System;

namespace _04_Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;
                if (nights > 7)
                {
                    studioPrice *= 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;
                if (nights > 14)
                {
                    doublePrice = doublePrice * 0.90;
                }

            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;
                if (nights > 14)
                {
                    suitePrice = suitePrice * 0.85;
                }
            }
            if (month == "September" || month == "October" && nights > 7)
            {
                studioPrice = studioPrice*(1 - (1.0 / nights));
            }
            Console.WriteLine($"Studio: {studioPrice * nights:F2} lv.");
            Console.WriteLine($"Double: {doublePrice * nights:F2} lv.");
            Console.WriteLine($"Suite: {suitePrice * nights:F2} lv.");
        }
    }
}
