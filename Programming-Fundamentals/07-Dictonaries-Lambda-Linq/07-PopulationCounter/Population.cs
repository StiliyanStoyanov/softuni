using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_PopulationCounter
{
    class Population
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();
            string[] input = Console.ReadLine().Split('|').ToArray();
            string country;
            string city;
            long population = 0;

            while (input[0] != "report")
            {
                city = input[0];
                country = input[1];
                population = long.Parse(input[2]);


                if (countries.ContainsKey(country) != true)
                {
                    Dictionary<string, long> currentCity = new Dictionary<string, long>();
                    currentCity.Add(city, population);
                    countries.Add(country, currentCity);
                }
                else
                {
                    if (countries[country].ContainsKey(city) != true)
                    {
                        countries[country].Add(city, population);
                    }
                }
                input = Console.ReadLine().Split('|').ToArray();
            }

            foreach (var pair in countries.OrderByDescending(c => c.Value.Values.Sum()))
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");
                foreach (var cityPair in pair.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{cityPair.Key}: {cityPair.Value}");
                }
            }
        }
    }
}


