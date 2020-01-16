using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_AnonymousCache
{
    class AnonymousCache
    {
        static void Main(string[] args)
        {
            string read = Console.ReadLine();
            string[] input = read.Split(" |->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> cache = new Dictionary<string, Dictionary<string, int>>();


            while (read != "thetinggoesskrra")
            {

                if (input.Length == 1)
                {
                    string key = input[0];
                    if (!data.ContainsKey(key))
                    {
                        if (cache.ContainsKey(key))
                        {
                            data[key] = new Dictionary<string, int>(cache[key]);
                            cache.Remove(key);
                        }
                        else
                        {
                            data.Add(key, new Dictionary<string, int>());
                        }
                    }
                }
                else
                {
                    string key = input[2];
                    int sum = int.Parse(input[1]);
                    string type = input[0];

                    if (data.ContainsKey(key))
                    {
                        data[key].Add(type, sum);
                    }
                    else    
                    {
                        if (cache.ContainsKey(key))
                        {
                            cache[key].Add(type, sum);
                        }
                        else
                        {
                            cache.Add(key, new Dictionary<string, int>());
                            cache[key].Add(type, sum);
                        }
                    }

                }
                if (data.Count > 0)
                {
                    KeyValuePair<string, Dictionary<string, int>> result = data.OrderByDescending(ds => ds.Value.Sum(d => d.Value)).First();

                    Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(d => d.Value)}");

                    foreach (var value in result.Value)
                    {
                        Console.WriteLine("$.{0}", value.Key);
                    }
                }

                read = Console.ReadLine();
                input = read.Split(" |->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }
    }
}
