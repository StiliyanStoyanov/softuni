using System;

namespace _02.ChooseADrink2
{
    class ChooseADrink2
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double waterPrice = 0.70;
            double coffeePrice = 1.00;
            double beerPrice = 1.70;
            double teaPrice = 1.20;

            if (profession == "Athlete")
            {
                Console.WriteLine($"The {profession} has to pay {waterPrice * quantity:F2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine($"The {profession} has to pay {coffeePrice * quantity:F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine($"The {profession} has to pay {beerPrice * quantity:F2}.");
            }
            else
            {
                Console.WriteLine($"The {profession} has to pay {teaPrice * quantity:F2}.");
            }
        }
    }
}