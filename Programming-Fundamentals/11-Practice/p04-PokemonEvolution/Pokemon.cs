using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_PokemonEvolution
{
    class PokemonEvolution
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<Tuple<string, int>>> pokemons = new Dictionary<string, List<Tuple<string, int>>>();

            while (input != "wubbalubbadubdub")
            {
                string[] mon = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string pokemon = mon[0];

                if (mon.Length == 3)
                {
                    string power = mon[1];
                    int evolution = int.Parse(mon[2]);
                    bool firstCheck = true;
                    if (!pokemons.ContainsKey(pokemon))
                    {
                        firstCheck = false;
                        var evopower = new List<Tuple<string, int>>();
                        evopower.Add(new Tuple<string, int>(power, evolution));
                        pokemons.Add(pokemon, evopower);
                    }
                    else if (pokemons.ContainsKey(pokemon) && firstCheck == true)
                    {
                        pokemons[pokemon].Add((new Tuple<string, int>(power, evolution)));
                    }
                }
                else
                {
                    if (pokemons.ContainsKey(pokemon))
                    {
                        Console.WriteLine($"# {pokemon}");
                        foreach (var evoluton in pokemons[pokemon])
                        {
                            Console.WriteLine($"{evoluton.Item1} <-> {evoluton.Item2}");
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var poke in pokemons)
            {
                Console.WriteLine($"# {poke.Key}");
                foreach (var evoluton in poke.Value.OrderByDescending(x => x.Item2))
                {
                    Console.WriteLine($"{evoluton.Item1} <-> {evoluton.Item2}");
                }
            }
        }
    }
}
