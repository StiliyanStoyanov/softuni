using System;

namespace _03_RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hallName = "";
            double price = 0;
            double discountNormal = 0.95;
            double discountGold = 0.90;
            double discountPlatinum = 0.85;


            if (guests <= 50)
            {
                hallName = "Small Hall";
                price += 2500;
            }
            else if (guests > 50 && guests <= 100)
            {
                hallName = "Terrace";
                price += 5000;

            }
            else if (guests > 100 && guests <= 120 )
            {
                hallName = "Great Hall";
                price += 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            if (package == "Normal") price = (price + 500) * discountNormal;
            else if (package == "Gold") price = (price + 750) * discountGold;
            else if (package == "Platinum") price = (price + 1000) * discountPlatinum;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {price/guests:F2}$");


        }
    }
}
