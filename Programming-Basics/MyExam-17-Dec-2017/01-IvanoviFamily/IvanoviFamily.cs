using System;

namespace _01_IvanoviFamily
{
    class IvanoviFamily
    {
        static void Main(string[] args)
        {
            var msIvanovaBudget = double.Parse(Console.ReadLine());
            var priceGift1 = double.Parse(Console.ReadLine());
            var priceGift2 = double.Parse(Console.ReadLine());
            var priceGift3 = double.Parse(Console.ReadLine());

            var totalGiftMoney = priceGift1 + priceGift2 + priceGift3;
            var remainingBudgetWithTaxes = (msIvanovaBudget - totalGiftMoney) * 0.9;

            Console.WriteLine($"{remainingBudgetWithTaxes:F2}");
        }
    }
}
