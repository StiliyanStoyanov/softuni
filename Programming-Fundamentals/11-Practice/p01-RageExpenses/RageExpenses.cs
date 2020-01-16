using System;

namespace p01_RageExpenses
{
    class RageExpenses  /// 100%
    {
        static void Main(string[] args)
        {
            long lostGames = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            long trashehHeadsets = lostGames / 2;
            long trashedMouse = lostGames / 3;
            long trashedKeyboard = trashedMouse / 2;
            long trashedDispay = 0;
            if (trashedKeyboard >= 2)
            {
                trashedDispay = trashedKeyboard / 2;
            }

            decimal total = (trashehHeadsets * headsetPrice)
                + (trashedMouse * mousePrice)
                + (trashedKeyboard * keyboardPrice)
                + (trashedDispay * displayPrice);

            Console.WriteLine($"Rage expenses: {total:F2} lv.");
        }
    }
}
