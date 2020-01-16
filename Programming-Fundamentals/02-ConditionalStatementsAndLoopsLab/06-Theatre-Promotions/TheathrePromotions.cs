using System;

namespace _06_Theatre_Promotions
{
    class TheathrePromotions
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            var price = 0;

            if (typeOfDay == "weekday")
            {
                if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                {
                    price = 12;
                }
                if (age > 18 && age <= 64)
                {
                    price = 18;
                }
            }
            else if (typeOfDay == "weekend")
            {
                if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                {
                    price = 15;
                }
                if (age > 18 && age <= 64)
                {
                    price = 20;
                }
            }
            else if (typeOfDay == "holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                if (age > 64 && age <= 122)
                {
                    price = 10;
                }
            }
            if (price != 0)
            {
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
