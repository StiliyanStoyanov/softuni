using System;

namespace _02_NewYearParty
{
    class NewYearParty
    {
        static void Main(string[] args)
        {
            int guestNumber = int.Parse(Console.ReadLine());
            int ivanoviBudget = int.Parse(Console.ReadLine());

            var kuvert = guestNumber * 20;
            if (ivanoviBudget >= kuvert)
            {
                double remainder = ivanoviBudget - kuvert;
                double fireworksMoney = remainder * 0.40;
                double donation = remainder - fireworksMoney;
                Console.WriteLine($"Yes! {fireworksMoney:F0} lv are for fireworks and {donation:F0} lv are for donation.");
            }
            else if (ivanoviBudget < kuvert)
            {
                var moneyNeeded = Math.Abs(ivanoviBudget - kuvert);
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {moneyNeeded:F0} lv more.");
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
