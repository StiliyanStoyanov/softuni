using System;

namespace p01_PadwanEquipment
{
    class PadwanEquipment
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int freeSaber = 0;
            if (count > 6)
            {
                freeSaber = count / 6;
            }
            double saberTotal = saberPrice * (Math.Ceiling(count * 1.1));
            double robeTotal = robesPrice * count;
            double beltTotal = beltPrice * (count - freeSaber);

            double sumTotal = saberTotal + robeTotal + beltTotal;

            if (sumTotal > amount)
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(amount - sumTotal):F2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {sumTotal:F2}lv.");
            }

        }
    }
}
