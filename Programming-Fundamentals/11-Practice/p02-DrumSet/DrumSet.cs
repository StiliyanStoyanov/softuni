using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_DrumSet
{
    class DrumSet
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            List<int> initialDrums = input.Split(' ').Select(int.Parse).ToList();
            List<int> currentDrums = new List<int>(initialDrums);

            while (true)
            {
                input = Console.ReadLine();
                if (input == "Hit it again, Gabsy!")
                {
                    break;
                }
                
                int drumDamage = int.Parse(input);
                for (int i = 0; i < currentDrums.Count; i++)
                {
                    currentDrums[i] -= drumDamage;
                }
                for (int i = 0; i < currentDrums.Count; i++)
                {
                    currentDrums[i] -= drumDamage;
                    if (currentDrums[i] <= 0)
                    {
                        int drumPrice = initialDrums[i] * 3;
                        if (money > drumPrice)
                        {
                            money -= drumPrice;
                            currentDrums[i] = initialDrums[i];
                        }
                        else
                        {
                            initialDrums.RemoveAt(i);
                            currentDrums.RemoveAt(i);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", currentDrums));
            Console.WriteLine($"Gabsy has {money:F2}lv.");
        }
    }
}
