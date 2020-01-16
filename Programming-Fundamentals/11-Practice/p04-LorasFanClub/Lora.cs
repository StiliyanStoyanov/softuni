using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_LorasFanClub
{
    class Lora
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            List<Tuple<string, int>> test = new List<Tuple<string, int>>();
            Dictionary<string, Dictionary<string, int>> book = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Make a decision already!")
            {
                string name = data[0];
                if (input != $"{data[0]} does Gyubek!")
                {
                    string trait = data[1];
                    int value = int.Parse(data[2]);
                    if (trait == "Kind")
                    {
                        value *= 2;
                    }
                    else if (trait == "Handsome")
                    {
                        value *= 3;
                    }
                    else if (trait == "Smart")
                    {
                        value *= 5;
                    }
                    else if (trait == "Greedy" || trait == "Rude" || trait == "Dumb")
                    {
                        value *= -1;
                    }

                    if (!book.ContainsKey(name))
                    {
                        book.Add(name, new Dictionary<string, int>());
                    }
                    if (!book[name].ContainsKey(trait))
                    {
                        book[name].Add(trait, value);
                    }
                    if (book[name][trait] < value)
                    {
                        book[name][trait] = value;
                    }
                }
                else
                {
                    if (book.ContainsKey(name))
                    {
                        book[name] = book[name].Where(x => x.Value < 0).ToDictionary(x => x.Key, y => y.Value);
                    }
                }
                input = Console.ReadLine();
                data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var kvp in book.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"# {kvp.Key}: {kvp.Value.Values.Sum()}");
                foreach (var item in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"!!! {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
