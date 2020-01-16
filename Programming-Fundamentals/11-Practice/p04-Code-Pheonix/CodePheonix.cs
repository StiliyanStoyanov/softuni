using System;
using System.Linq;
using System.Collections.Generic;

namespace p04_Code_Pheonix
{
    class CodePheonix
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] info = input.Split("-> ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();


            while (input != "Blaze it!")
            {
                string key = info[0];
                string value = info[1];
                if (key != value)
                {
                    if (!data.ContainsKey(key))
                    {
                        data.Add(key, new List<string>());
                        data[key].Add(value);
                    }
                    else
                    {
                        if (!data[key].Contains(value))
                        {
                            data[key].Add(value);
                        }
                    }
                }
                input = Console.ReadLine();
                info = input.Split("-> ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            var result = new Dictionary<string, List<string>>();
            foreach (var item in data)
            {
                result.Add(item.Key, new List<string>());

                foreach (var mate in item.Value)
                {
                    if (data.ContainsKey(mate) && data[mate].Contains(item.Key))
                    {
                        continue;
                    }

                    else
                    {
                        result[item.Key].Add(mate);
                    }
                }
            }

            foreach (var item in result.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
        }
    }
}
