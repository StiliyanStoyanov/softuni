using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_AMinerTask
{
    class Mine
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mine = new Dictionary<string, int>();
            string command = Console.ReadLine();
            string metal = "";
            int quantity = 0;

            while (command != "stop")
            {
                metal = command;
                quantity = int.Parse(Console.ReadLine());
                if (mine.ContainsKey(metal) == false)
                {
                    mine.Add(metal, quantity);
                }
                else
                {
                    mine[metal] += quantity;
                }
                command = Console.ReadLine();

                foreach (var pair in mine)
                {
                    Console.WriteLine($"{pair.Value} -> {pair.Key}");
                }
            }
        }
    }
}
